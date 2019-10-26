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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Coding4Fun.Toolkit.Controls;

using Atrx.WindowsPhone.Motywuj;

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

            // Ustaw AppBar
            ChangeApplicationBar(0);
		}


        //
		// Polecenia uruchamiane ze startem strony
        //
		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
            // Wylosuj cytat
            //RandomNewCitation();
			// Uruchom przewodnik
			if (_citations.GuideStart) NavigationService.Navigate(new Uri("/Pages/GuidePage.xaml", UriKind.Relative));
            // Ustaw przycisk ButtonFabourite
            SetButtonFabourite(_citations.SelectedCitation.IsFavorite);
		}


        //
        // Zdarzenie zachodzi gdy przewijane są strony
        //
        private void panPanel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Zmień ApplicationBar
            ChangeApplicationBar(panPanel.SelectedIndex);
        }


        #region APPLICATIONBARS

        //
        // Zmienia ApplicationBar
        //
        private void ChangeApplicationBar(int barIndex)
        { 
            // Znieniaj AppBar w zależności od strony
            switch (barIndex)
            { 
                    // Strona Losowy cytat
                case 0:
                    ApplicationBar = CreateRandomPageAppBar();
                    // Ustaw przycisk ButtonFabourite
                    SetButtonFabourite(_citations.SelectedCitation.IsFavorite);
                    break;
                    // Strona Ulubione cytaty
                case 1:
                    ApplicationBar = CreateFavouritesPageAppBar();
                    break;
                    // Strona Wszystkie cytaty
                case 2:
                    ApplicationBar = CreateAllCitationPageAppBar();
                    break;
            }

        }


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


            // Przycisk dodawania do ulubionych
            ApplicationBarIconButton btnFavouriteCitation = new ApplicationBarIconButton();
            btnFavouriteCitation.IconUri = new Uri("/Images/FavoriteCitation_48.png", UriKind.Relative);
            btnFavouriteCitation.Text = AppResources.AppBarFavouriteCitation;
            btnFavouriteCitation.Click += new EventHandler(btnFavouriteCitation_click);
            newAppBar.Buttons.Add(btnFavouriteCitation);

            // Przycisk losujący nowy cytat
            ApplicationBarIconButton btnRandomCitation = new ApplicationBarIconButton();
            btnRandomCitation.IconUri = new Uri("/Images/RandomNewCitation_48.png", UriKind.Relative);
            btnRandomCitation.Text = AppResources.AppBarRandomCitation;
            btnRandomCitation.Click += new EventHandler(btnRandomCitation_click);
            newAppBar.Buttons.Add(btnRandomCitation);

            // Pozycja menu o programie
            ApplicationBarMenuItem mnuGuide = new ApplicationBarMenuItem();
            mnuGuide.Text = AppResources.AppBarGuide;
            mnuGuide.Click += new EventHandler(mnuGuide_click);
            newAppBar.MenuItems.Add(mnuGuide);

            // Pozycja menu o programie
            ApplicationBarMenuItem mnuSettings = new ApplicationBarMenuItem();
            mnuSettings.Text = AppResources.AppBarSettings;
            mnuSettings.Click += new EventHandler(mnuSettings_click);
            newAppBar.MenuItems.Add(mnuSettings);

            // Pozycja menu o programie
            ApplicationBarMenuItem mnuAbout = new ApplicationBarMenuItem();
            mnuAbout.Text = AppResources.AppBarAbout;
            mnuAbout.Click += new EventHandler(mnuAbout_click);
            newAppBar.MenuItems.Add(mnuAbout);

            // Zwróć AppBar
            return newAppBar;
        }

        
        //
        // Tworzy ApplicationBar dla strony Ulubione cytaty
        //
        private ApplicationBar CreateFavouritesPageAppBar()
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


            // Pozycja menu o programie
            ApplicationBarMenuItem mnuGuide = new ApplicationBarMenuItem();
            mnuGuide.Text = AppResources.AppBarGuide;
            mnuGuide.Click += new EventHandler(mnuGuide_click);
            newAppBar.MenuItems.Add(mnuGuide);

            // Pozycja menu o programie
            ApplicationBarMenuItem mnuSettings = new ApplicationBarMenuItem();
            mnuSettings.Text = AppResources.AppBarSettings;
            mnuSettings.Click += new EventHandler(mnuSettings_click);
            newAppBar.MenuItems.Add(mnuSettings);

            // Pozycja menu o programie
            ApplicationBarMenuItem mnuAbout = new ApplicationBarMenuItem();
            mnuAbout.Text = AppResources.AppBarAbout;
            mnuAbout.Click += new EventHandler(mnuAbout_click);
            newAppBar.MenuItems.Add(mnuAbout);

            // Zwróć AppBar
            return newAppBar;
        }


        //
        // Tworzy ApplicationBar dla strony Losowy cytat
        //
        private ApplicationBar CreateAllCitationPageAppBar()
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


            // Pozycja menu o programie
            ApplicationBarMenuItem mnuGuide = new ApplicationBarMenuItem();
            mnuGuide.Text = AppResources.AppBarGuide;
            mnuGuide.Click += new EventHandler(mnuGuide_click);
            newAppBar.MenuItems.Add(mnuGuide);

            // Pozycja menu o programie
            ApplicationBarMenuItem mnuSettings = new ApplicationBarMenuItem();
            mnuSettings.Text = AppResources.AppBarSettings;
            mnuSettings.Click += new EventHandler(mnuSettings_click);
            newAppBar.MenuItems.Add(mnuSettings);

            // Pozycja menu o programie
            ApplicationBarMenuItem mnuAbout = new ApplicationBarMenuItem();
            mnuAbout.Text = AppResources.AppBarAbout;
            mnuAbout.Click += new EventHandler(mnuAbout_click);
            newAppBar.MenuItems.Add(mnuAbout);

            // Zwróć AppBar
            return newAppBar;
        }

        private void mnuGuide_click(object sender, EventArgs e)
        {
            // Przełącz na nową stronę GuidePage
            NavigationService.Navigate(new Uri("/Pages/GuidePage.xaml", UriKind.Relative));
        }

        private void mnuSettings_click(object sender, EventArgs e)
        {
            // Przełącz na nową stronę SettingsPage
            NavigationService.Navigate(new Uri("/Pages/SettingsPage.xaml", UriKind.Relative));
        }

        private void mnuAbout_click(object sender, EventArgs e)
        {
            // Przełącz na nową stronę AboutPage
            NavigationService.Navigate(new Uri("/Pages/AboutPage.xaml", UriKind.Relative));
        }

        #endregion


        #region RandomPage

        //
        // Zdarzenie naciśnięcia przycisku Losuj cytat
        //
        private void btnRandomCitation_click(object sender, EventArgs e)
        {
            // Wylosuj cytat
            RandomNewCitation();
        }

        private void btnFavouriteCitation_click(object sender, EventArgs e)
        {
            // Ustaw cytat jako ulubiony lub usuń z ulubionych
            SetFavouriteCitation();
        }

        //
        // Losuje nowy cytat
        //
        private void RandomNewCitation()
        { 
            /*
             * CEL:
             * Losuje nowy cytat
             */

            // Wylosuj nowy cytat
            _citations.RandomCitation();

            // Ustaw przycisk ButtonFabourite
            SetButtonFabourite(_citations.SelectedCitation.IsFavorite);
        }

        //
        // Ustawia cytat jako ulubiony lub nie
        //
        private void SetFavouriteCitation()
        {
            // Sprawdz czy aktywna jest pierwsza stron - Losowy cytat
            if (panPanel.SelectedIndex == 0)
            {
                // Sprawdź czy cytat należy do ulubionych
                if (_citations.SelectedCitation.IsFavorite == false)
                {
                    // Jeśli cytat nie jest ulubiony to oznacz go jako lubiany
                    // Aktualizuj
                    _citations.UpdateFavoriteCitation(_citations.SelectedCitation.Id, true);
                    // Wiadomość
                    ToastMessage(AppResources.TextFavouriteCietation);
                }
                else
                {
                    // Jeśli cytat jest ulubiony to oznacz go jako nie lubiany
                    // Aktualizuj
                    _citations.UpdateFavoriteCitation(_citations.SelectedCitation.Id, false);
                    // Wiadomość
                    ToastMessage(AppResources.TextNotFavouriteCietation);
                }

                // Ustaw przycisk ButtonFabourite
                SetButtonFabourite(_citations.SelectedCitation.IsFavorite);
            }
        }

        //
        // Ustawia przycisk ButtonFavourite
        //
        private void SetButtonFabourite(bool isFavourite)
        {
            /*
             * CEL:
             * Ustawia przycisk ButtonFavourite
             * 
             * WARTOŚĆ WEJŚCIOWA:
             * isFavourite:bool - określa czy przycisk należy do ulubionych czy nie.
             */

            //// Pierwszy przycisk
            //ApplicationBarIconButton FavouriteAppBarButton = ApplicationBar.Buttons[0] as ApplicationBarIconButton;

            // Sprawdź czy jesteś na pierwszej stronie - Losowy cytat
            if (panPanel.SelectedIndex == 0)
            { 

                // Pierwszy przycisk
                ApplicationBarIconButton FavouriteAppBarButton = ApplicationBar.Buttons[0] as ApplicationBarIconButton;

                // Sprawdz czy wylosowany cytat należy do ulubionych
                if (isFavourite == true)
                {
                    // Jeśli należy do ulubionych
                    // Ustaw ikonę
                    FavouriteAppBarButton.IconUri = new Uri("/Images/NotFavoriteCitation_48.png", UriKind.Relative);
                    // Ustaw opis
                    FavouriteAppBarButton.Text = AppResources.AppBarNotFavouriteCitation;
                }
                else
                { 
                    // Jeśli nie należy do ulubionych
                    // Ustaw ikonę
                    FavouriteAppBarButton.IconUri = new Uri("/Images/FavoriteCitation_48.png", UriKind.Relative);
                    // Ustaw opis
                    FavouriteAppBarButton.Text = AppResources.AppBarFavouriteCitation;
                }
            }
        }

        #endregion

        //
        // Naciśnięcie cytatu
        //
		private void stpCitation_Tap(object sender, System.Windows.Input.GestureEventArgs e)
		{
			// Przełącz na nową stronę i przekaż parametr - wskazaną notatkę
			NavigationService.Navigate(new Uri("/Pages/ViewPage.xaml?selectedItem=" + (_citations.SelectedCitation as Citation).Id, UriKind.Relative));
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
        // Wyświetla tostowe wiadomości
        //
        private void ToastMessage(string message)
        {
            ToastPrompt toast = new ToastPrompt();
            toast.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 132, 233));
            toast.Title = AppResources.ApplicationTitle;
            //toast.Message = "       Teraz czas na przerwę";
            toast.Message = string.Format(" {0}", message);
            toast.FontSize = 23;
            toast.TextOrientation = System.Windows.Controls.Orientation.Vertical;
            toast.MillisecondsUntilHidden = 1500;
            toast.ImageSource = new BitmapImage(new Uri("/Images/motywujPlus_32.png", UriKind.RelativeOrAbsolute));

            toast.Show();
        }

	}
}