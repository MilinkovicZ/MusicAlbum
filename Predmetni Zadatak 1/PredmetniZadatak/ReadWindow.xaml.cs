using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PredmetniZadatak
{
    /// <summary>
    /// Interaction logic for ReadWindow.xaml
    /// </summary>
    public partial class ReadWindow : Window
    {
        string path = MainWindow.hitovi[MainWindow.selIndex].OpisPath;
        public ReadWindow()
        {
            InitializeComponent();

            string pesma = MainWindow.hitovi[MainWindow.selIndex].Naziv;
            string pevac = MainWindow.hitovi[MainWindow.selIndex].Izvodjac;
            lNaslov.Content = pevac + " - " + pesma;            

            lTrajanje.Content = MainWindow.hitovi[MainWindow.selIndex].Duzina.ToString() + " minuta";          

            DateTime temp = MainWindow.hitovi[MainWindow.selIndex].DatumObjavljivanja;
            lDan.Content = temp.Day+".";
            lMesec.Content = temp.Month + ".";
            lGodina.Content = temp.Year + ".";

            slikaS.Source = new BitmapImage(new Uri(MainWindow.hitovi[MainWindow.selIndex].Slika));
                        
            FileStream filestream;
            TextRange opis = new TextRange(rtbOpis.Document.ContentStart, rtbOpis.Document.ContentEnd);
            using (filestream = new FileStream(path, FileMode.Open))
            {
                opis.Load(filestream, DataFormats.Rtf);
                filestream.Close();
            }
        }

        private void btnIzadji_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
