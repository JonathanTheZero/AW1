using AW1GUI.Lists;
using System.Windows;

namespace AW1GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewmodel Viewmodel { get; } = new MainWindowViewmodel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = Viewmodel;
        }

        private void BtnLists_Click(object sender, RoutedEventArgs e)
        {
            Window messwerte = new MesswerteWindow();
            messwerte.Show();
        }

        private void BtnHelloWorld_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Clicked", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
