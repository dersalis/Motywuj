using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Motywuj
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Ustaw pasek boczny na 0
            CitationList.Width = 0;

            
        }

        private void ChangeLeftPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //var uriLeft = new Uri("pack://application:,,,/AssemblyName;Images/arrowRight48.png");
            //var bitmapLeft = new BitmapImage(uriLeft);

            if (CitationList.Width == 0)
            {
                CitationList.Width = 400;

            }
            else
            {
                CitationList.Width = 0;
            }
        }
    }
}
