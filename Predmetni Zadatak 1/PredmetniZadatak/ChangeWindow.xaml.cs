using Class;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using RichTextBox = System.Windows.Controls.RichTextBox;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
using System.IO;

namespace PredmetniZadatak
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class ChangeWindow : Window
    {
        int count = 0;
        public ChangeWindow()
        {
            InitializeComponent();
            cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            cmbFontSize.ItemsSource = Liste.velicina;
            cmbDan.ItemsSource = Liste.dani;
            cmbMesec.ItemsSource = Liste.meseci;
            cmbGodina.ItemsSource = Liste.godine;

            tbPesma.Text = MainWindow.hitovi[MainWindow.selIndex].Naziv;
            tbPesma.Foreground = Brushes.Black;
            tbPevac.Text = MainWindow.hitovi[MainWindow.selIndex].Izvodjac;
            tbPevac.Foreground = Brushes.Black;
            tbTrajanje.Text = MainWindow.hitovi[MainWindow.selIndex].Duzina.ToString();
            tbTrajanje.Foreground = Brushes.Black;

            DateTime temp = MainWindow.hitovi[MainWindow.selIndex].DatumObjavljivanja;            
            cmbDan.SelectedItem = temp.Day;
            cmbMesec.SelectedItem = temp.Month;
            cmbGodina.SelectedItem = temp.Year;

            slikaS.Source = new BitmapImage(new Uri(MainWindow.hitovi[MainWindow.selIndex].Slika));
                        
            FileStream fs;
            string path = MainWindow.hitovi[MainWindow.selIndex].OpisPath;
            TextRange opis = new TextRange(rtbOpis.Document.ContentStart, rtbOpis.Document.ContentEnd);
            using (fs = new FileStream(path, FileMode.Open))
            {
                opis.Load(fs, DataFormats.Rtf);
                fs.Close();
            }
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            Hitovi novi;

            if (validate())
            {
                File.Delete(MainWindow.hitovi[MainWindow.selIndex].OpisPath);

                FileStream fs;
                TextRange opis = new TextRange(rtbOpis.Document.ContentStart, rtbOpis.Document.ContentEnd);
                string path = @"C:\Users\Zdravko\Desktop\HCI Projekat\RTBFiles\" + tbPesma.Text + ".rtf";
                using (fs = new FileStream(path, FileMode.Create))
                {
                    opis.Save(fs, DataFormats.Rtf);
                    fs.Close();
                }
                
                DateTime vreme = new DateTime(Int32.Parse(cmbGodina.SelectedItem.ToString()), Int32.Parse(cmbMesec.SelectedItem.ToString()), Int32.Parse(cmbDan.SelectedItem.ToString()));
                novi = new Hitovi(slikaS.Source.ToString(), tbPesma.Text, tbPevac.Text, Double.Parse(tbTrajanje.Text), vreme.Date, path);
                MainWindow.hitovi[MainWindow.selIndex] = novi;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lose popunjeni podaci!", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnIzadji1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tbPesma_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbPesma.Text.Trim().Equals("unesite ime pesme"))
            {
                tbPesma.Text = "";
                tbPesma.Foreground = Brushes.Black;
            }
        }

        private void tbPesma_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbPesma.Text.Trim().Equals(String.Empty))
            {
                tbPesma.Text = "unesite ime pesme";
                tbPesma.Foreground = Brushes.LightSlateGray;
            }
        }

        private void tbPevac_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbPevac.Text.Trim().Equals("unesite ime izvodjaca"))
            {
                tbPevac.Text = "";
                tbPevac.Foreground = Brushes.Black;
            }
        }

        private void tbPevac_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbPevac.Text.Trim().Equals(String.Empty))
            {
                tbPevac.Text = "unesite ime izvodjaca";
                tbPevac.Foreground = Brushes.LightSlateGray;
            }
        }

        private void tbTrajanje_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbTrajanje.Text.Trim().Equals("unesite duzinu pesme"))
            {
                tbTrajanje.Text = "";
                tbTrajanje.Foreground = Brushes.Black;
            }
        }

        private void tbTrajanje_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbTrajanje.Text.Trim().Equals(String.Empty))
            {
                tbTrajanje.Text = "unesite duzinu pesme";
                tbTrajanje.Foreground = Brushes.LightSlateGray;
            }
        }

        private bool validate()
        {
            bool isValid = true;

            if (tbPesma.Text.Trim().Equals("") || tbPesma.Text.Trim().Equals("unesite ime pesme"))
            {
                isValid = false;
                tbPesma.BorderBrush = Brushes.Red;
                tbPesma.BorderThickness = new Thickness(3);
                labelPesmaGreska.Content = "Ne valja ime pesme!";
            }
            else
            {
                tbPesma.BorderBrush = Brushes.Green;
                labelPesmaGreska.Content = "";
            }

            if (tbPevac.Text.Trim().Equals("") || tbPevac.Text.Trim().Equals("unesite ime izvodjaca"))
            {
                isValid = false;
                tbPevac.BorderBrush = Brushes.Red;
                tbPevac.BorderThickness = new Thickness(3);
                labelPevacGreska.Content = "Ne valja izvodjac!";
            }
            else
            {
                tbPevac.BorderBrush = Brushes.Green;
                labelPevacGreska.Content = "";
            }

            if (tbTrajanje.Text.Trim().Equals("") || tbTrajanje.Text.Trim().Equals("unesite duzinu pesme"))
            {
                isValid = false;
                tbTrajanje.BorderBrush = Brushes.Red;
                tbTrajanje.BorderThickness = new Thickness(3);
                labelTrajanjeGreska.Content = "Unesite trajanje!";
            }
            else
            {
                tbTrajanje.BorderBrush = Brushes.Black;

                try
                {
                    double temp = Double.Parse(tbTrajanje.Text.Trim());
                    if (temp <= 0)
                    {
                        tbTrajanje.BorderBrush = Brushes.Red;
                        tbTrajanje.BorderThickness = new Thickness(3);
                        labelTrajanjeGreska.Content = "Unesite VALIDNO trajanje!";
                        isValid = false;
                    }
                    else
                    {
                        tbTrajanje.BorderBrush = Brushes.Green;
                        labelTrajanjeGreska.Content = "";
                    }

                }
                catch (Exception exc)
                {
                    tbTrajanje.BorderBrush = Brushes.Red;
                    tbTrajanje.BorderThickness = new Thickness(3);
                    labelTrajanjeGreska.Content = "Trajanje mora biti broj!";
                    Console.WriteLine(exc.Message);
                    isValid = false;
                }
            }

            if (IsRichTextBoxEmpty(rtbOpis))
            {
                isValid = false;
                labelOpisGreska.Content = "Unesite opis!";
            }
            else
            {
                labelOpisGreska.Content = "";
            }


            if (cmbDan.SelectedItem == null || cmbMesec.SelectedItem == null || cmbGodina.SelectedItem == null)
            {
                isValid = false;
                labelDatumGreska.Content = "Greska! Unesite pravilno datum!";
            }
            else
            {
                try
                {
                    new DateTime(Int32.Parse(cmbGodina.SelectedItem.ToString()), Int32.Parse(cmbMesec.SelectedItem.ToString()), Int32.Parse(cmbDan.SelectedItem.ToString()));
                    labelDatumGreska.Content = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("NEVALIDAN DATUM!", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);
                    labelDatumGreska.Content = "Greska! Unesite pravilno datum!";
                    isValid = false;
                }
            }

            return isValid;
        }

        private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFontFamily.SelectedItem != null && !rtbOpis.Selection.IsEmpty)
            {
                rtbOpis.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);
            }
        }

        private void cmbFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFontSize.SelectedItem != null && !rtbOpis.Selection.IsEmpty)
            {
                rtbOpis.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.SelectedItem);
            }
        }

        private void btnColor_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.ColorDialog cd = new System.Windows.Forms.ColorDialog();

            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!rtbOpis.Selection.IsEmpty)
                {
                    rtbOpis.Selection.ApplyPropertyValue(Inline.ForegroundProperty, new SolidColorBrush(Color.FromArgb(cd.Color.A, cd.Color.R, cd.Color.G, cd.Color.B)));
                }
            }
        }

        private void rtbOpis_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object temp = rtbOpis.Selection.GetPropertyValue(Inline.FontWeightProperty);
            btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));

            temp = rtbOpis.Selection.GetPropertyValue(Inline.FontStyleProperty);
            btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));

            temp = rtbOpis.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            btnUnderLine.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));

            temp = rtbOpis.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            cmbFontFamily.SelectedItem = temp;

            cmbFontSize.SelectedItem = rtbOpis.Selection.GetPropertyValue(Inline.FontSizeProperty);
        }

        public bool IsRichTextBoxEmpty(RichTextBox rtb)
        {
            if (count == 0) return true;
            if (rtbOpis.Document.Blocks.Count == 0) return true;
            TextPointer startPointer = rtbOpis.Document.ContentStart.GetNextInsertionPosition(LogicalDirection.Forward);
            TextPointer endPointer = rtbOpis.Document.ContentEnd.GetNextInsertionPosition(LogicalDirection.Backward);
            return startPointer.CompareTo(endPointer) == 0;
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                slikaS.Source = new BitmapImage(fileUri);
            }
        }

        private void rtbOpis_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextRange opis = new TextRange(rtbOpis.Document.ContentStart, rtbOpis.Document.ContentEnd);

            string text = opis.Text.Trim();

            count = 0;
            bool inWord = false;

            foreach (char slovo in text)
            {
                if (char.IsWhiteSpace(slovo))
                {
                    inWord = false;
                }
                else
                {
                    if (!inWord)
                    {
                        count++;
                    }
                    inWord = true;
                }
            }

            if (count == 0)
            {
                brojReci.Text = string.Empty;
            }
            else
            {
                brojReci.Text = count.ToString();
            }
        }
    }
}