﻿using System;
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
using System.Windows.Media.Imaging;
using Coding4Fun.Toolkit.Controls;

namespace Motywator.Pages
{
    public partial class ViewPage : PhoneApplicationPage
    {
        // Instancja
        private CitationManagement _citations = CitationManagement.Instatnce;
        

        //
        // Konstruktor
        //
        public ViewPage()
        {
            InitializeComponent();

            DataContext = _citations;

            // Ustaw AppBar
            ApplicationBar = CreateViewPageAppBar();
            // Ustaw przycisk ButtonFabourite
            SetButtonFabourite(_citations.SelectedCitation.IsFavorite);
        }


        //
        // Polecenia wykonywanie przy starcie strony
        //
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Ustaw wybrany cytat
            string selectedIndex = "";
            if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
            {
                int id = int.Parse(selectedIndex);

                _citations.SetViewCitation(id);
            }
        }


        //
        // Polecenia wykonywane przy zamykaniu strony
        //
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            
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
            btnFavouriteCitation.Text = AppResources.AppBarFavouriteCitation;
            btnFavouriteCitation.Click += new EventHandler(btnFavouriteCitation_click);
            newAppBar.Buttons.Add(btnFavouriteCitation);

            // Przycisk dzielenia się cytatem
            ApplicationBarIconButton btnShareCitation = new ApplicationBarIconButton();
            btnShareCitation.IconUri = new Uri("/Images/share_48.png", UriKind.Relative);
            btnShareCitation.Text = AppResources.AppBarShare;
            btnShareCitation.Click += new EventHandler(btnShareCitation_click);
            newAppBar.Buttons.Add(btnShareCitation);

            // Zwróć AppBar
            return newAppBar;
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

        
        //
        // Ustawia cytat jako ulubiony lub nie
        //
        private void SetFavouriteCitation()
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