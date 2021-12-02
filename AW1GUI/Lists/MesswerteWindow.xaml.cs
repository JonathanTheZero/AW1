using System;
using System.Windows;

namespace AW1GUI.Lists
{
    /// <summary>
    /// Interaction logic for Messwerte.xaml
    /// </summary>
    public partial class MesswerteWindow : Window
    {
        public MesswerteWindowViewmodel Viewmodel { get; set; } = new MesswerteWindowViewmodel();
        public MesswerteWindow()
        {
            InitializeComponent();
            DataContext = Viewmodel;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TbData.Text, out double result))
            {
                Viewmodel.Data.Add(result);
                TbData.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Falsche Eingabedaten", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnCount_Click(object sender, RoutedEventArgs e)
        {
            LbAM.Content = Viewmodel.ArithemtischesMittel;
            LbMax.Content = Viewmodel.Maximum;
            LbMin.Content = Viewmodel.Minimum;
            LbSum.Content = Viewmodel.Summe;
            LbMod.Content = Viewmodel.Modalwert;
            LbMed.Content = Viewmodel.Median;
            LbProd.Content = Viewmodel.Produkt;
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            Viewmodel.Data.Clear();
            LbAM.Content = string.Empty;
            LbMax.Content = string.Empty;
            LbMin.Content = string.Empty;
            LbSum.Content = string.Empty;
            LbMod.Content = string.Empty;
            LbMed.Content = string.Empty;
            LbProd.Content = string.Empty;
            UpdateView();
        }

        private void UpdateView()
        {
            DataContext = null;
            DataContext = Viewmodel;
        }
    }
}
