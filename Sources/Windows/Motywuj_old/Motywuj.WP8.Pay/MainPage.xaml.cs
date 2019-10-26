using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;

using Microsoft.Phone.Tasks;
using Microsoft.Phone.Shell;
using Motywator.Motywator;
using Motywator.Resources;

using Atrx.WindowsPhone.Motywuj;
using System.Windows.Media;

namespace Motywator
{
	public partial class MainPage : PhoneApplicationPage
	{
        // Instancja motywuj
		private CitationManagement _citations = CitationManagement.Instatnce;


		// Konstructor
		public MainPage()
		{
			InitializeComponent();

			// DataConstext
			DataContext = _citations;

            // Ustaw appBar
            ApplicationBar = CreateRandomPageAppBar();
		}

        
        //
		// Polecenia uruchamiane ze startem strony
        //
		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
            // Ustaw zaznaczenie przycisku ulubiony
			//btnFavourite.IsChecked = _citations.SelectedCitation.IsFavorite;

			// Uruchom przewodnik
			if (_citations.GuideStart) NavigationService.Navigate(new Uri("/Pages/GuidePage.xaml", UriKind.Relative));
		}


        //
        // Naciśnięcie cytatu
        //
		private void stpCitation_Tap(object sender, System.Windows.Input.GestureEventArgs e)
		{
			// Przełącz na nową stronę i przekaż parametr - wskazaną notatkę
			NavigationService.Navigate(new Uri("/Pages/ViewPage.xaml?selectedItem=" + (_citations.SelectedCitation as Citation).Id, UriKind.Relative));
		}

		
        //
        // Naciśnięcie przycisku losuj
        //
		private void btnRandom_Click(object sender, RoutedEventArgs e)
		{
            // Wylosuj cytat
			_citations.RandomCitation();
            // Ustaw zaznaczenie przycisku
			//btnFavourite.IsChecked = _citations.SelectedCitation.IsFavorite;
		}

		
        //
        // Naciśnięcie cytatu na liście
        //
		private void lstCitations_Tap(object sender, System.Windows.Input.GestureEventArgs e)
		{
			// Jeśli nic nie wybrano to porzuć
			if (lstCitations.SelectedItem == null)
				return;

			// Przełącz na nową stronę i przekaż parametr - wskazaną notatkę
			NavigationService.Navigate(new Uri("/Pages/ViewPage.xaml?selectedItem=" + (lstCitations.SelectedItem as Citation).Id, UriKind.Relative));

			// Ustaw wybrany element na null - brak wyboru
			lstCitations.SelectedItem = null;	

			// Pokazać kontrolki w widoku
			_citations.ControlsVisibility = true;
		}


        //
        // Naciśnięcie przycisku sortuj wg. cytatu
        //
		private void btnSortByCitation_Click(object sender, RoutedEventArgs e)
		{
            // Pokaż wg. cytatu
			_citations.SortIndex = 0;
		}


        //
        // Naciśnięcie przycisku sortuj wg. autora
        //
		private void btnSortByAuthor_Click(object sender, RoutedEventArgs e)
		{
            // Pokaż wg. autora
			_citations.SortIndex = 1;
		}

        //
        // Naciśnięcie przycisku tylko ulubione
        //
		private void btnOnlyFavorite_Click(object sender, RoutedEventArgs e)
		{
            // Pokaż tylko usubione
			_citations.SortIndex = 2;
		}

        //
        // Zaznaczenie przycisku ulubione
        //
		private void btnFavourite_Checked(object sender, RoutedEventArgs e)
		{
            // Jeśli cytat nie jest ulubiony to oznacz go jako nie lubiany
			if (_citations.SelectedCitation.IsFavorite == false)
			{
				// Aktualizuj
				_citations.UpdateFavoriteCitation(_citations.SelectedCitation.Id, true);
			}
			
		}

        //
        // Odznaczenie przycisku ulubione
        //
		private void btnFavourite_Unchecked(object sender, RoutedEventArgs e)
		{
            // Jeśli cytat nie jest ulubiony to oznacz jako ulubiony
			if(_citations.SelectedCitation.IsFavorite == true)
			{
				// Aktualizuj
				_citations.UpdateFavoriteCitation(_citations.SelectedCitation.Id, false);
			}
		}


        private void btnRemoveAd_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Idź do sklepu", "Czy chcesz usunąć reklamę?", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                MarketplaceDetailTask mdt = new MarketplaceDetailTask();
                //mdt.ContentIdentifier = "219eb8f4-356a-4821-b4a7-8e9d56edfd4b";
                mdt.Show();
            }
        }

        private void btnPin_Click(object sender, RoutedEventArgs e)
        {
            // Przełącz na nową stronę Przypnij
            NavigationService.Navigate(new Uri("/Pages/TilePage.xaml", UriKind.Relative));
        }


        #region AppBars

        //
        // Tworzy ApplicationBar dla strony Losowy cytat
        //
        private ApplicationBar CreateRandomPageAppBar()
        {
            // Nowy AppBar
            ApplicationBar newAppBar = new ApplicationBar();

            //ustawienia paska
            newAppBar.Mode = ApplicationBarMode.Default;
            newAppBar.Opacity = 0.75;
            newAppBar.IsVisible = true;
            newAppBar.IsMenuEnabled = true;
            newAppBar.ForegroundColor = Colors.White;
            newAppBar.BackgroundColor = Color.FromArgb(255, 54, 89, 14);


            // Przycisk losujący nowy cytat
            ApplicationBarIconButton btnRandomCitation = new ApplicationBarIconButton();
            btnRandomCitation.IconUri = new Uri("/Images/RandomNewCitation_48.png", UriKind.Relative);
            btnRandomCitation.Text = AppResources.ButtonRandomCitation;
            btnRandomCitation.Click += new EventHandler(btnRandomCitation_click);
            newAppBar.Buttons.Add(btnRandomCitation);

            // Pozycja menu usuń reklamę - tylko dla wersji trial
            if (_citations.IsTrial)
            {
                ApplicationBarMenuItem mnuRemoveAdd = new ApplicationBarMenuItem();
                mnuRemoveAdd.Text = AppResources.TextRemoveAdd;
                mnuRemoveAdd.Click += new EventHandler(mnuRemoveAdd_click);
                newAppBar.MenuItems.Add(mnuRemoveAdd);
            }

            // Pozycja menu przewodnik
            ApplicationBarMenuItem mnuGuide = new ApplicationBarMenuItem();
            mnuGuide.Text = AppResources.ButtonGuide;
            mnuGuide.Click += new EventHandler(mnuGuide_click);
            newAppBar.MenuItems.Add(mnuGuide);

            // Pozycja menu ustawienia
            //TODO Dodać ustawienia
            //ApplicationBarMenuItem mnuSettings = new ApplicationBarMenuItem();
            //mnuSettings.Text = AppResources.ButtonSettings;
            //mnuSettings.Click += new EventHandler(mnuSettings_click);
            //newAppBar.MenuItems.Add(mnuSettings);

            // Pozycja menu o programie
            ApplicationBarMenuItem mnuAbout = new ApplicationBarMenuItem();
            mnuAbout.Text = AppResources.ButtonAbout;
            mnuAbout.Click += new EventHandler(mnuAbout_click);
            newAppBar.MenuItems.Add(mnuAbout);

            // Zwróć AppBar
            return newAppBar;
        }


        // Przejdź aby usunąć reklamę
        private void mnuRemoveAdd_click(object sender, EventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Idź do sklepu", "Czy chcesz usunąć reklamę?", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                MarketplaceDetailTask mdt = new MarketplaceDetailTask();
                //mdt.ContentIdentifier = "219eb8f4-356a-4821-b4a7-8e9d56edfd4b";
                mdt.Show();
            }
        }


        // Otwiera stronę o programie
        private void mnuAbout_click(object sender, EventArgs e)
        {
            // Przejdz na stronę
            NavigationService.Navigate(new Uri("/Pages/AboutPage.xaml", UriKind.Relative));
        }


        // Przejdź na stronę ustawienia
        private void mnuSettings_click(object sender, EventArgs e)
        {
            // Przejdz na stronę
            NavigationService.Navigate(new Uri("/Pages/SettingsPage.xaml", UriKind.Relative));
        }


        // Przejdź na stronę przewodnik
        private void mnuGuide_click(object sender, EventArgs e)
        {
            // Przejdz na stronę
            NavigationService.Navigate(new Uri("/Pages/GuidePage.xaml", UriKind.Relative));
        }


        // Losuj cytat
        private void btnRandomCitation_click(object sender, EventArgs e)
        {
            // Wylosuj cytat
            _citations.RandomCitation();
        }


        //
        // Tworzy ApplicationBar dla strony Losowy cytat
        //
        private ApplicationBar CreateCitationPageAppBar()
        {
            // Nowy AppBar
            ApplicationBar newAppBar = new ApplicationBar();

            //ustawienia paska
            newAppBar.Mode = ApplicationBarMode.Minimized;
            newAppBar.Opacity = 0.75;
            newAppBar.IsVisible = true;
            newAppBar.IsMenuEnabled = true;
            newAppBar.ForegroundColor = Colors.White;
            newAppBar.BackgroundColor = Color.FromArgb(255, 54, 89, 14);


            // Przycisk dodaj nowy cytat
            //ApplicationBarIconButton btnAddCitation = new ApplicationBarIconButton();
            //btnAddCitation.IconUri = new Uri("/Toolkit.Content/ApplicationBar.Add.png", UriKind.Relative);
            //btnAddCitation.Text = AppResources.ButtonAddCitation;
            //btnAddCitation.Click += new EventHandler(btnAddCitation_click);
            //newAppBar.Buttons.Add(btnAddCitation);

            // Pozycja menu usuń reklamę - tylko dla wersji trial
            if (_citations.IsTrial)
            {
                ApplicationBarMenuItem mnuRemoveAdd = new ApplicationBarMenuItem();
                mnuRemoveAdd.Text = AppResources.TextRemoveAdd;
                mnuRemoveAdd.Click += new EventHandler(mnuRemoveAdd_click);
                newAppBar.MenuItems.Add(mnuRemoveAdd);
            }

            // Pozycja menu przewodnik
            ApplicationBarMenuItem mnuGuide = new ApplicationBarMenuItem();
            mnuGuide.Text = AppResources.ButtonGuide;
            mnuGuide.Click += new EventHandler(mnuGuide_click);
            newAppBar.MenuItems.Add(mnuGuide);

            // Pozycja menu ustawienia
            //TODO Dodać ustawienia
            //ApplicationBarMenuItem mnuSettings = new ApplicationBarMenuItem();
            //mnuSettings.Text = AppResources.ButtonSettings;
            //mnuSettings.Click += new EventHandler(mnuSettings_click);
            //newAppBar.MenuItems.Add(mnuSettings);

            // Pozycja menu o programie
            ApplicationBarMenuItem mnuAbout = new ApplicationBarMenuItem();
            mnuAbout.Text = AppResources.ButtonAbout;
            mnuAbout.Click += new EventHandler(mnuAbout_click);
            newAppBar.MenuItems.Add(mnuAbout);

            // Zwróć AppBar
            return newAppBar;
        }


        // Przejdź na stronę nowego cytatu
        private void btnAddCitation_click(object sender, EventArgs e)
        {
            // Przejdz na stronę
            NavigationService.Navigate(new Uri("/Pages/AddCitationPage.xaml", UriKind.Relative));
        }

        #endregion

        // Zmienia appBar po przesunięciu widoku
        private void panCitation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Zmień appBar
            switch (panCitation.SelectedIndex)
            { 
                case 0:
                    ApplicationBar = CreateRandomPageAppBar();
                    break;
                case 1:
                    ApplicationBar = CreateCitationPageAppBar();
                    break;
            }
        }
    }
}