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
            LbCount.Content = Viewmodel.Data.Count;
        }
    }
}
