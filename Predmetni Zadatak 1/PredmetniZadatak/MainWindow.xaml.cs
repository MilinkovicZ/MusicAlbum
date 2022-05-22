using Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PredmetniZadatak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int selIndex;
        
        public static BindingList<Hitovi> hitovi { get; set; }

        public MainWindow()
        {
            hitovi = new BindingList<Hitovi>();

            DataContext = this;

            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnIzadji_Click(object sender, RoutedEventArgs e)
        {
            foreach(Hitovi item in hitovi)
            {
                File.Delete(item.OpisPath);
            }
            this.Close();
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.ShowDialog();
        }

        private void btnProcitaj_Click(object sender, RoutedEventArgs e)
        {
            selIndex = gridName.SelectedIndex;
            ReadWindow rw = new ReadWindow();
            rw.ShowDialog();
        }

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            selIndex = gridName.SelectedIndex;
            ChangeWindow cw = new ChangeWindow();
            cw.ShowDialog();
        }

        private void btnObrisi_Click(object sender, RoutedEventArgs e)
        {
            int i = gridName.SelectedIndex;
            string path = hitovi[i].OpisPath;
            hitovi.RemoveAt(gridName.SelectedIndex);
            File.Delete(path);
        }
    }
}