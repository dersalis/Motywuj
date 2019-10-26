using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using Motywator.Motywator;
using Motywator.Resources;
using System.Windows.Media;
using Coding4Fun.Toolkit.Controls;
using System.Windows.Media.Imaging;
using Atrx.WindowsPhone.Motywuj;

namespace Motywator.Pages
{
    public partial class ViewPage : PhoneApplicationPage
    {
        private CitationManagement _citations = CitationManagement.Instatnce;
        //private Visibility _componentVisibility;

        public ViewPage()
        {
            InitializeComponent();

            // Ustaw dataContext
            DataContext = _citations;

            // Ustaw AppBar
            ApplicationBar = CreateViewPageAppBar();
        }


        //
        // Polecenia wykonywanie przy starcie strony
        //
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            /*
             * CEL:
             *  Polecenia wykonywanie przy starcie strony
             */

             // Odczytaj przekazany parametr - id
            string selectedIndex = "";
            if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
            {
                int id = int.Parse(selectedIndex);
                // Wybierz cytat na odstawie id odczytanego z parametru
                _citations.SetViewCitation(id);
            }

            // Ustaw przycisk ButtonFabourite - pokaż / ukryj
            SetButtonFabourite(_citations.ViewCitation.IsFavorite);
        }


        //
        // Polecenia wykonane przy opuszczeniu strony
        //
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            // Wyczyść zmienna
            //_citations.ViewCitation = null;
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

            // Pierwszy przycisk
            ApplicationBarIconButton FavouriteAppBarButton = ApplicationBar.Buttons[0] as ApplicationBarIconButton;

            // Sprawdz czy wylosowany cytat należy do ulubionych
            if (isFavourite == true)
            {
                // Jeśli należy do ulubionych
                // Ustaw ikonę
                FavouriteAppBarButton.IconUri = new Uri("/Images/NotFavoriteCitation_48.png", UriKind.Relative);
                // Ustaw opis
                FavouriteAppBarButton.Text = AppResources.ButtonNotFavorite;
            }
            else
            {
                // Jeśli nie należy do ulubionych
                // Ustaw ikonę
                FavouriteAppBarButton.IconUri = new Uri("/Images/FavoriteCitation_48.png", UriKind.Relative);
                // Ustaw opis
                FavouriteAppBarButton.Text = AppResources.ButtonFavorite;
            }
        }


        #region APPLICATIONBAR

        //
        // Tworzy ApplicationBar dla strony Widok cytatu
        //
        private ApplicationBar CreateViewPageAppBar()
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


            // Przycisk dodawania do ulubionych
            ApplicationBarIconButton btnFavouriteCitation = new ApplicationBarIconButton();
            btnFavouriteCitation.IconUri = new Uri("/Images/FavoriteCitation_48.png", UriKind.Relative);
            btnFavouriteCitation.Text = AppResources.ButtonFavorite;
            btnFavouriteCitation.Click += new EventHandler(btnFavouriteCitation_click);
            newAppBar.Buttons.Add(btnFavouriteCitation);

            // Przycisk dzielenia się cytatem
            ApplicationBarIconButton btnShareCitation = new ApplicationBarIconButton();
            btnShareCitation.IconUri = new Uri("/Images/share_48.png", UriKind.Relative);
            btnShareCitation.Text = AppResources.ButtonShare;
            btnShareCitation.Click += new EventHandler(btnShareCitation_click);
            newAppBar.Buttons.Add(btnShareCitation);

            // Przycisk przypinania kafelka
            ApplicationBarIconButton btnAddTile = new ApplicationBarIconButton();
            btnAddTile.IconUri = new Uri("/Images/pin_48.png", UriKind.Relative);
            btnAddTile.Text = AppResources.ButtonPin;
            btnAddTile.Click += new EventHandler(btnAddTile_click);
            newAppBar.Buttons.Add(btnAddTile);

            // Zwróć AppBar
            return newAppBar;
        }


        //
        // Przycisk dodaj kafelek
        //
        private void btnAddTile_click(object sender, EventArgs e)
        {
            // Sprawdź czy kafelek istnieje
            if (TileManagement.CheckIfTileExist(_citations.ViewCitation.Id.ToString()))
            {
                // Wyświetl komunikat
                MessageBox.Show("Nie mogę go dodać ponownie", "Kafelek z wyranym cytatem już istnieje", MessageBoxButton.OK);

            }
            else
            {
                // Przejdź do strony dodawania kafelka
                NavigationService.Navigate(new Uri("/Pages/TilePage.xaml", UriKind.Relative));
            }
        }


        //
        // Przycisk ulubiony
        //
        private void btnFavouriteCitation_click(object sender, EventArgs e)
        {
            // Ustaw cytat jako ulubiony lub usuń z ulubionych
            SetFavouriteCitation();
        }


        //
        // Przycisk udostępnij
        //
        private void btnShareCitation_click(object sender, EventArgs e)
        {
            // Otwórz stronę udostępnienia
            NavigationService.Navigate(new Uri("/Pages/SharePage.xaml", UriKind.Relative));
        }

        #endregion


        //
        // Ustawia cytat jako ulubiony lub nie
        //
        private void SetFavouriteCitation()
        {
            // Sprawdź czy cytat należy do ulubionych
            if (_citations.ViewCitation.IsFavorite == false)
            {
                // Jeśli cytat nie jest ulubiony to oznacz go jako lubiany
                // Aktualizuj
                _citations.UpdateFavoriteCitation(_citations.ViewCitation.Id, true);
                _citations.ViewCitation.IsFavorite = true;
                // Wiadomość
                ToastMessage(AppResources.TextFavouriteCietation);
            }
            else
            {
                // Jeśli cytat jest ulubiony to oznacz go jako nie lubiany
                // Aktualizuj
                _citations.UpdateFavoriteCitation(_citations.ViewCitation.Id, false);
                _citations.ViewCitation.IsFavorite = false;
                // Wiadomość
                ToastMessage(AppResources.TextNotFavouriteCietation);
            }

            // Ustaw przycisk ButtonFabourite
            SetButtonFabourite(_citations.ViewCitation.IsFavorite);
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