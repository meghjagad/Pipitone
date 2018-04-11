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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2.Start_Screen_Assets
{
    /// <summary>
    /// Interaction logic for Idealist_level1.xaml
    /// </summary>
    public partial class Idealist_level1 : Page
    {
        public Idealist_level1()
        {
            InitializeComponent();
        }

        private void startover_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Start_Screen.xaml", UriKind.Relative));
        }
    }
}
