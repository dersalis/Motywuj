using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using Microsoft.Phone.Tasks;
using Motywator.Resources;
using System.Windows.Media;
using Motywator.Motywator;

namespace Motywator.Pages
{
    public partial class AboutPage : PhoneApplicationPage
    {
        // Instancja motywuj
        private CitationManagement _citations = CitationManagement.Instatnce;

        public AboutPage()
        {
            InitializeComponent();

            // Ustaw appBar
            ApplicationBar = CreateAboutPageAppBar();
        }

        //
        // Wyślij email - pole textowe
        //
        private void txtSendEmail_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // Wyślij email
            SendEmail();
        }


        //
        // Tworzy i wysyła wiadomość email
        //
        private void SendEmail()
        {
            /*
             * CEL:
             * Tworzy i wysyła wiadomość email
             */
            // Utwórz zadanie
            EmailComposeTask emailComposeTask = new EmailComposeTask();
            // Ustaw temat
            emailComposeTask.Subject = AppResources.TextEmailSubiect;
            //emailComposeTask.Body = "message body";
            // Dodaj adres
            emailComposeTask.To = "mobileapps@aturex.pl";
            //emailComposeTask.Cc = "cc@example.com";
            //emailComposeTask.Bcc = "bcc@example.com";

            // Utwórz okno redagowania wiadomości
            emailComposeTask.Show();
        }


        #region AppBar

        //
        // Tworzy ApplicationBar dla strony O programie
        //
        private ApplicationBar CreateAboutPageAppBar()
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


            // Przycisk przewodnik
            ApplicationBarIconButton btnGuide = new ApplicationBarIconButton();
            btnGuide.IconUri = new Uri("/Images/guide_48.png", UriKind.Relative);
            btnGuide.Text = AppResources.TextGuide;
            btnGuide.Click += new EventHandler(btnGuide_click);
            newAppBar.Buttons.Add(btnGuide);

            // Przycisk oceń
            ApplicationBarIconButton btnReview = new ApplicationBarIconButton();
            btnReview.IconUri = new Uri("/Images/review_48.png", UriKind.Relative);
            btnReview.Text = AppResources.TextReview;
            btnReview.Click += new EventHandler(btnReview_click);
            newAppBar.Buttons.Add(btnReview);

            // Przycisk sklep
            ApplicationBarIconButton btnStore = new ApplicationBarIconButton();
            btnStore.IconUri = new Uri("/Images/store_48.png", UriKind.Relative);
            btnStore.Text = AppResources.TextStore;
            btnStore.Click += new EventHandler(btnStore_click);
            newAppBar.Buttons.Add(btnStore);

            // Przycisk email
            ApplicationBarIconButton btnEmail = new ApplicationBarIconButton();
            btnEmail.IconUri = new Uri("/Images/mail_48.png", UriKind.Relative);
            btnEmail.Text = AppResources.TextEmail;
            btnEmail.Click += new EventHandler(btnEmail_click);
            newAppBar.Buttons.Add(btnEmail);

            // Pozycja menu usuń reklamę - tylko dla wersji trial
            if(_citations.IsTrial){
                ApplicationBarMenuItem mnuRemoveAdd = new ApplicationBarMenuItem();
                mnuRemoveAdd.Text = AppResources.TextRemoveAdd;
                mnuRemoveAdd.Click += new EventHandler(mnuRemoveAdd_click);
                newAppBar.MenuItems.Add(mnuRemoveAdd);
            }

            // Zwróć AppBar
            return newAppBar;
        }

        //
        //  Wyślij email
        //
        private void btnEmail_click(object sender, EventArgs e)
        {
            // Wyślij email
            SendEmail();
        }


        //
        // Przejdź do sklepu i wyszukaj aplikacje
        //
        private void btnStore_click(object sender, EventArgs e)
        {
            // Przejdź do sklepu i wyszukaj moje aplikacje
            MarketplaceSearchTask marketplaceSearchTask = new MarketplaceSearchTask();
            marketplaceSearchTask.SearchTerms = "Damian Ruta";
            marketplaceSearchTask.Show();
        }


        //
        // Przejdź do strony oceń
        //
        private void btnReview_click(object sender, EventArgs e)
        {
            // Oceń
            MarketplaceReviewTask marketplaceReviewTask = new MarketplaceReviewTask();
            marketplaceReviewTask.Show();
        }


        //
        // Przejdź aby usunąć reklamę
        //
        private void mnuRemoveAdd_click(object sender, EventArgs e)
        {
            // Wyświetl komunikat
            MessageBoxResult result = MessageBox.Show("Idź do sklepu", "Czy chcesz usunąć reklamę?", MessageBoxButton.OKCancel);
            // Jeśli wybrano Ok to przejdź do sklepu
            if (result == MessageBoxResult.OK)
            {
                MarketplaceDetailTask mdt = new MarketplaceDetailTask();
                mdt.Show();
            }
        }


        //
        // Przejdź do strony przewodnik
        //
        private void btnGuide_click(object sender, EventArgs e)
        {
            // Przejdz na stronę
            NavigationService.Navigate(new Uri("/Pages/GuidePage.xaml", UriKind.Relative));
        }

        #endregion
    }
}