using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using System.Windows;
using Motywator.Resources;
using Microsoft.Phone.Marketplace;

using Atrx.WindowsPhone.Motywuj;
using Atrx.WindowsPhone.Motywuj.Free;

namespace Motywator.Motywator

{
	class CitationManagement : INotifyPropertyChanged
	{
		// Ustawienie pierwszego startu
		private const string FIRST_STATRT_SETTINGS = "FirstStartSettings";
		// Ustawienie indeks sortowania
		private const string SORT_INDEX_SETTINGS = "SortIndexSettings";
		// Widoczność kontrolek w podglądzie. Początkowo ustawione jako nie widoczne. 
		// Gdy wybierany jest cytat wylosowany to kontrolki są nie widoczne. 
		// Gdy wybieramy cytat z listy to kontrolki są widoczne.
		public bool ControlsVisibility { get; set; }
		// Liczba elementów w bazie
		private int _maxItemsCount;
		// Ostatni wylosowany indeks
		private int _lastRandomizedIndex = 0;
		// Określa czy przy pierwszym uruchomieniu pokazywać przewodnik
		public bool GuideStart { get; set; }


		// Plik bazy danych
		private const string DATA_BASE_FILE = @"Data Source=isostore:/MotywatorData.sdf";

		#region SINGLETON

		private static CitationManagement _instance = null;
		public static CitationManagement Instatnce
		{
			get
			{
				if (_instance == null) _instance = new CitationManagement();
				return _instance;
			}
		}

		#endregion

		#region KONSTRUKTORY

		public CitationManagement()
		{ 
			// Sprawdź czy program jest uruchomiony po raz pierwszy
			FirstStart = CheckFirstStart();

			// Ustaw aby uruchomić przewodnik
			GuideStart = FirstStart;

			// Jeśli jest taka potrzeba to utwórz bazę danych - pirwszy start
			CreateDataBase(FirstStart);

			// Odczytaj indeks sortowania
			LoadSortIndex();

            // Odczytaj liczbę elementów
            _maxItemsCount = GetCitationsSortAlphabeticallyByCitation().Count();

			// Wylosuj cytat
			RandomCitation();

			// Wyczyść pokazywany cytat
			ViewCitation = null;

			// Widoczność kontrolek w podglądzie, ustaw początkowo jako nie widoczne
			ControlsVisibility = false;

            // Dodaj aktualizacje
            AddUpdates();
		}

		#endregion

		// 1.0.0.4
		#region WYBRANY CYCAT

		// Wylosowany cytat
		public Citation SelectedCitation { get; set; }
		// Prezentowany cytat na stronie View
		public Citation ViewCitation { get; set; }

		//
		// Ustaw prezentowany cytat
		// 1.0.0.4
		public void SetViewCitation(int id)
		{
			/*
			 * CEL:
			 * Ustawia prezentowany cytat
			 */

			// Ustaw prezentowany cytat
			ViewCitation = GetCitationOfId(id);

			//Odśwież cytat
			NotifyPropertyChanged("ViewCitation");
		}

		#endregion

		// 1.0.0.4
		#region WCZYTYWANIE CYTATÓW Z BAZY

		// Lista cytatów
		public List<Citation> CitationList
		{
			get 
			{
				return GetCitations();
			}
		}

		// Indeks sortowania
		private byte _sortIndex = 0;
		public byte SortIndex
		{
			get { return _sortIndex; }
			set 
			{
				if (_sortIndex != value)
				{
					_sortIndex = value;
					// zapisz indeks
					using (SettingsManagement sm = new SettingsManagement())
					{
						sm.SaveSortIndex(SORT_INDEX_SETTINGS, _sortIndex);
					}
					// Odśwież listę cytatów
					NotifyPropertyChanged("CitationList");
					//NotifyPropertyChanged("SortText");
				}
			}
		}
		
		// Opis wybranego typu sortowania
		public string SortText { get; set; }

		//
		// Odczytuje indeks/typ sortowania zapisany w ustawieniach
		// 1.0.0.4
		private void LoadSortIndex()
		{
			/*
			 * CEL:
			 * Odczytuje indeks/typ sortowania zapisany w ustawieniach
			 *	0 - sortowanie wg. cytatu
			 *	1 - sortowanie wg. autora
			 *	2 - tylko ulubione cytaty
			 */

			// Odczytaj ustawienia
			using (SettingsManagement sm = new SettingsManagement())
			{
				SortIndex = sm.LoadSortIndex(SORT_INDEX_SETTINGS);
			}
		}

		//
		// Zwraca cytaty na podstawie indeksu/typu sortowania
		// 1.0.0.4
		public List<Citation> GetCitations()
		{
			/*
			 * CEL:
			 * Odczytuje indeks/typ sortowania i na jego podstawie zwraca listę cytatów
			 *	0 - sortowanie wg. cytatu
			 *	1 - sortowanie wg. autora
			 *	2 - tylko ulubione cytaty
			 */

			// Lista zwracanych cytatów
			List<Citation> citations = null;

			// Zewróć cytaty
			switch (SortIndex)
			{
				case 0:
					// Sortowanie wg. cytatu
					citations = GetCitationsSortAlphabeticallyByCitation();
					SortText = AppResources.TextByCitation;
					break;
				case 1:
					// Sortowanie wg. autora
					citations = GetCitationsSortAlphabeticallyByAuthor();
					SortText = AppResources.TextByAuthor;
					break;
				case 2:
					// Zwraca tylko ulubione cytaty
					citations = GetCitationsSortOnlyFavorite();
					SortText = AppResources.TextOnlyFavorite;
					break;
			}

			// Odświerz tekst sortowania
			NotifyPropertyChanged("SortText");

			// zwróć cytaty
			return citations;
		}

		// Zwróć cytaty posortowane alfabetycznie wg cytatów
		private List<Citation> GetCitationsSortAlphabeticallyByCitation()
		{
			/*
			 * CEL:
			 * Zwraca cytaty posortowane wg. cytatu alfabetycznie
			 */

			// Lista zwróconych cytatów
			List<Citation> citations = null;
			// Użyj bazy
			using (CitationDataContext dc = new CitationDataContext(DATA_BASE_FILE))
			{
				// Zwróć cytaty posortowane alfabetycznie wg. cytatu
				citations = (from cit in dc.Citations orderby cit.Content ascending select cit).ToList();
			}

			// zwróć cytaty
			return citations;
		}

		//
		// Zwróć cytaty posortowane alfabetycznie wg autora
		//
		private List<Citation> GetCitationsSortAlphabeticallyByAuthor()
		{
			/*
			 * CEL:
			 * Zwraca cytaty posortowane wg. autora alfabetycznie
			 */

			// Lista zwróconych cytatów
			List<Citation> citations = null;
			// Użyj bazy
			using (CitationDataContext dc = new CitationDataContext(DATA_BASE_FILE))
			{
				// Zwróć cytaty posortowane alfabetycznie wg. autora
				citations = (from cit in dc.Citations orderby cit.Author ascending select cit).ToList();
			}

			// zwróć cytaty
			return citations;
		}

		//
		// Zwróć tylko usubione cytaty 
		// 1.0.0.4
		private List<Citation> GetCitationsSortOnlyFavorite()
		{
			/*
			 * CEL:
			 * Zwraca tylko usubione cytaty posortowane wg. cytatu alfabetycznie
			 */

			// Lista zwróconych cytatów
			List<Citation> citations = null;
			// Użyj bazy
			using (CitationDataContext dc = new CitationDataContext(DATA_BASE_FILE))
			{
				// Zwróć cytaty ulubione, posortowane alfabetycznie wg. cytatu
				citations = (from cit in dc.Citations where cit.IsFavorite == true orderby cit.Content ascending select cit).ToList();
			}

			// zwróć cytaty
			return citations;
		}

		//
		// Zwróć cytat o podanym Id
		// 1.0.0.4
		private Citation GetCitationOfId(int id)
		{
			/*
			 * CEL:
			 * Zwraca cytat o podanym id
			 * 
			 * WARTOŚĆ WEJŚCIOWA:
			 * id:int - id cytatu
			 */

			// Wybrany cytat
			Citation selectCitation = null;

			// Użyj bazę danych
			using (CitationDataContext dc = new CitationDataContext(DATA_BASE_FILE))
			{
				// Wybierz cytat o podanym id
				selectCitation = (from cit in dc.Citations where cit.Id == id select cit).FirstOrDefault();
			}

			// Zwróć cytat
			return selectCitation;
		}

		#endregion

		// 1.0.0.4
		#region LOSUJ CYTAT

		//
		// Losuje cytat
		// 1.0.0.4
		public void RandomCitation()
		{
			/*
			 * CEL:
			 * Losuje cytat z listy cytatów.
			 * Wylosowany cytat nie powtarza się z poprzednim
			 */

			// Wylosowany indeks
			int randomIndex = 0;
			// Losuj indeks jeśli powtarza się to wylosuj ponownie
			do
			{
				randomIndex = new Random().Next(1, (_maxItemsCount + 1));
			}while(_lastRandomizedIndex == randomIndex);
			// Uapamiętaj wylosowany indeks
			_lastRandomizedIndex = randomIndex;
			
			// Zwróć cytat o wylosowanym indeksie i przypisz go do SelectedCitation
			SelectedCitation = GetCitationOfId(randomIndex);

			// Odśwież wybrany cytat
			NotifyPropertyChanged("SelectedCitation");
		}

		#endregion

		// 1.0.0.4
		#region UAKTUALNIJ CYTAT

		//
		// Aktualizuje wartość isFavorite 
		//
		public void UpdateFavoriteCitation(int id, bool favorit)
		{
			/*
			 * CEL:
			 * Ustawia cytat jako ulubiony lub nie 
			 * 
			 * WARTOŚĆ WEJŚCIOWA:
			 * id:int - id cytatu zmienianego
			 * favorite:bool - wartość ustawiana
			 */

			// Użyj CitationDataContext
			using (CitationDataContext dc = new CitationDataContext(DATA_BASE_FILE))
			{
				// Zwróć wszystkie cytaty 
				IQueryable<Citation> cq = from cit in dc.Citations where cit.Id == id select cit;
				// Zwróć jeden cytat spełniający powyższy warunek
				Citation citationToUpdate = cq.FirstOrDefault();
				// Ustaw wartość IsFavorite dla wybranego cytatu
				citationToUpdate.IsFavorite = favorit;
				// Zapisz zmiany
				dc.SubmitChanges();
			}

            // Ustaw nową wartość w wybranym cytacie
            //SelectedCitation.IsFavorite = favorit;

			// Odśwież listę cytatów
			NotifyPropertyChanged("CitationList");
			// Odśwież wybrany cytat
			NotifyPropertyChanged("SelectedCitation");
			// Odśwież prezentowany cytat
			NotifyPropertyChanged("ViewCitation");
		}

		#endregion


        #region UDOSTĘPNIJ CYTAT

        //
        //udostępnia notatkę za pomocą sms
        ////v1.1.0.2
        public void ShareViaSms()
        {
            /*
             * CEL:
             * Udostępnia notatkę za pomocą sms
             */

            //udostępnij
            using (ShareManagement sm = new ShareManagement())
            {
                sm.ShareViaSms(ViewCitation.Content, ViewCitation.Author);
            }
        }

        //
        //udostępnia notatkę za pomocą email
        ////v1.1.0.2
        public void ShareViaEmail()
        {
            /*
             * CEL:
             * Udostępnia notatkę za pomocą email
             */

            //udostępnij
            using (ShareManagement sm = new ShareManagement())
            {
                sm.ShareViaEmail(ViewCitation.Content, ViewCitation.Author);
            }
        }

        //
        //udostępnia notatkę jako status w sieci
        ////v1.1.0.2
        public void ShareYourStatus()
        {
            /*
             * CEL:
             * Udostępnia notatkę jako status w sieci
             */

            //udostępnij
            using (ShareManagement sm = new ShareManagement())
            {
                sm.ShareViaSocialNetwork(ViewCitation.Content, ViewCitation.Author);
            }
        }

        #endregion

        // 1.0.0.4
		#region PIERWSZY START

		// Określa wartość czy program został pierwszy raz uruchomiony
		// true - pierwsze uruchomienie
		// false - kolejne uruchomienie
		private bool _firstStart;
		public bool FirstStart 
		{
			get { return _firstStart; }
			private set
			{
				if (_firstStart != value)
				{
					_firstStart = value;
					// Zapisz to w ustawieniach
					using (SettingsManagement sm = new SettingsManagement())
					{
						// Zapisz to w ustawieniach
						sm.SaveFirstStart(FIRST_STATRT_SETTINGS, _firstStart);
					}
				}
			}
		}

		//
		// Sprawdza czy program jest uruchamiany po raz pierwszy
		//
		private bool CheckFirstStart()
		{
			bool firstStart = true;
			using (SettingsManagement sm = new SettingsManagement())
			{
				firstStart = sm.LoadFirstStart(FIRST_STATRT_SETTINGS);

				// Jeśli uruchomiono po raz pierwszy to zapisz to w ustawieniach
				//if (firstStart) sm.SaveFirstStart(FIRST_STATRT_SETTINGS, !firstStart);
			}

			return firstStart;
		}

		// Tworzy bazę danych 
		private void CreateDataBase(bool create)
		{ 
			// Sprawdź czy utowrzyć
			if (create)
			{
				using (CitationDataContext dataBase = new CitationDataContext(DATA_BASE_FILE))
				{
					if (dataBase.DatabaseExists() == false)
					{
						// Utwórz bazę danych
						dataBase.CreateDatabase();
					}
					else
					{
						//MessageBox.Show("Employee Database already exists!!!");
					}
					// Dodaj cytaty do bazy
					FirstStart = !(UpdateCietations.AddCitationsToBaseFirstStart(dataBase));
				}
			}
		}

		#endregion

        // 1.1.0.2
        #region AKTUALIZACJE

        //
        // Dodaje aktualizacje
        //
        private void AddUpdates()
        {
            // Dodaj aktualizacje 1.1.0.2
            AddUpdate_1102();
            // Dodaj aktualizacje 1.1.1.2
            AddUpdate_1112();
            // Dodaj aktualizację 1.1.2.2
            AddUpdate_1122();
        }


        //
        // Dodaj aktualizacje 1.1.2.2
        //
        private void AddUpdate_1122()
        {
            const string ADD_UPDATE_1122_SETTINGS = "Update1122";

            // Sprawdz czy dodano aktualizacje
            // Jeśli nie to aktualizuj
            if (CheckUpdateSettings(ADD_UPDATE_1122_SETTINGS))
            {
                // Dodaj aktualizacje
                using (CitationDataContext dataBase = new CitationDataContext(DATA_BASE_FILE))
                {
                    // Dodaje aktualizacje 1.1.2.2
                    UpdateCietations.AddUpdate_1122(dataBase);
                }

                // Zapisz informacje od dodaniu aktualizacji
                SaveUpdateSettings(ADD_UPDATE_1122_SETTINGS, false);
            }
        }


        //
        // Dodaj aktualizacje 1.1.1.2
        //
        private void AddUpdate_1112()
        {
            const string ADD_UPDATE_1112_SETTINGS = "Update1112";

            // Sprawdz czy dodano aktualizacje
            // Jeśli nie to aktualizuj
            if (CheckUpdateSettings(ADD_UPDATE_1112_SETTINGS))
            {
                // Dodaj aktualizacje
                using (CitationDataContext dataBase = new CitationDataContext(DATA_BASE_FILE))
                {
                    // Dodaje aktualizacje 1.1.1.2
                    UpdateCietations.AddUpdate_1112(dataBase);
                }

                // Zapisz informacje od dodaniu aktualizacji
                SaveUpdateSettings(ADD_UPDATE_1112_SETTINGS, false);
            }
        }


        //
        // Dodaj aktualizacje 1.1.0.2
        //
        private void AddUpdate_1102()
        {
            const string ADD_UPDATE_1102_SETTINGS = "Update1102";

            // Sprawdz czy dodano aktualizacje
            // Jeśli nie to aktualizuj
            if (CheckUpdateSettings(ADD_UPDATE_1102_SETTINGS))
            { 
                // Dodaj aktualizacje
                using (CitationDataContext dataBase = new CitationDataContext(DATA_BASE_FILE))
                {
                    // Dodaje aktualizacje 1.1.0.2
                    UpdateCietations.AddUpdate_1102(dataBase);
                }

                // Zapisz informacje od dodaniu aktualizacji
                SaveUpdateSettings(ADD_UPDATE_1102_SETTINGS, false);
            }
        }


        //
        // Sprawdza czy program był aktualizowany - odczytuje z ustawień
        //
        private static bool CheckUpdateSettings(string settingName)
        {
            bool update = true;
            using (SettingsManagement sm = new SettingsManagement())
            {
                // Sprawdz aktualizację 1.1.0.2
                update = sm.LoadFirstStart(settingName);
            }
            return update;
        }

        //
        // Zapisuje informacje o aktualizacji
        //
        private static void SaveUpdateSettings(string settingName, bool value)
        {
            using (SettingsManagement sm = new SettingsManagement())
            {
                sm.SaveFirstStart(settingName, value);
            }
        }

        #endregion

        //
        #region LICENCJA

        private LicenseInformation _license = new LicenseInformation();

        private bool _isTrial = true;
        public bool IsTrial
        {
            get { return _isTrial; }
            private set 
            {
                if (_isTrial != value)
                {
                    _isTrial = value;
                    NotifyPropertyChanged("IsTrial");
                }
            }
        }

        public void ChecekLicense()
        {
#if TRIAL
            IsTrial = true;
#else
            IsTrial = _license.IsTrial();
#endif
        }

        #endregion

        #region NotifyPropertyChanged

        //
		// Implementacja NotifyPropertyChanged
		//
		public event PropertyChangedEventHandler PropertyChanged;
		private void NotifyPropertyChanged(String propertyName)
		{
			//PropertyChangedEventHandler handler = PropertyChanged;
			//if (null != handler)
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
				//handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion
	}
}
