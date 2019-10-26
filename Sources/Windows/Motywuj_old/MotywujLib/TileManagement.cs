using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO.IsolatedStorage;
using Microsoft.Phone.Shell;

namespace Atrx.WindowsPhone.Motywuj
{
    public class TileManagement
    {
        public static void GenerateTile(StackPanel background, string id)
        {
            // Parametry pliku graficznego
            var source = new BitmapImage(new Uri("isostore:/Shared/ShellContent/", UriKind.Absolute));
            var tileImage = "/Shared/ShellContent/" + id + ".jpg";
            var isoStoreTileImage = string.Format("isostore:{0}", tileImage);

            // Utwórz plik graficzny i zapisz w pamięci
            using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForApplication())
            {
                //Tile image's Height * Width are 173 * 173.
                var bitmap = new WriteableBitmap(173, 173);

                //Render a bitmap from StackPanel.
                bitmap.Render(background, new TranslateTransform());
                var stream = store.CreateFile(tileImage);
                bitmap.Invalidate();
                bitmap.SaveJpeg(stream, 173, 173, 0, 100);
                stream.Close();
            }

            //Create a live tile using the created bitmapImage.
            StandardTileData secondaryTile = new StandardTileData
            {
                BackgroundImage = new Uri(isoStoreTileImage, UriKind.Absolute),
                Title = "",
                Count = null,
            };
            //Live tile has own url.
            //You can go to your application page when you click a live tile.
            ShellTile.Create(new Uri("/Pages/ViewPage.xaml?selectedItem=" + id, UriKind.Relative), secondaryTile);
            
        }


        //
        // Sprawdza czy kafelek istnieje
        //
        public static bool CheckIfTileExist(string id)
        {
            /*
             * CEL:
             *  Sprawdza czy kafelek istnieje
             *  Jeśli kafelek istnieje zwracane jest true w przeciwnym wypadku false
             *  
             * PARAMETR:
             *  id:string - id cytatu
             *  
             * WARTOŚC ZWRACANA:
             *  bool - true gdy kafelek istnieje
             */

            // Określa czy kafelek istnieje
            bool tileExist = false;

            // Sprawdz czy kafelek o podanym id istnieje
            ShellTile shellTile = ShellTile.ActiveTiles.FirstOrDefault(tile => tile.NavigationUri.ToString().Contains(id));

            // Jeśli kafelek istnieje zwróć true
            if (shellTile != null) tileExist = true;

            return tileExist;
        }
    }
}
