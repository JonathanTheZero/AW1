using System;
using System.Collections.Generic;
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

namespace AW1GUI.Lists
{
    /// <summary>
    /// Interaction logic for ImmobilienWindow.xaml
    /// </summary>
    public partial class ImmobilienWindow : Window
    {
        private ImmobilienWindowViewmodel Viewmodel { get; } = new ImmobilienWindowViewmodel();
        public ImmobilienWindow()
        {
            InitializeComponent();
            DataContext = Viewmodel;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Viewmodel.AddEntry();
        }
    }
}
