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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for PantherLab_Level4.xaml
    /// </summary>
    public partial class PantherLab_Level4 : Page
    {
        public PantherLab_Level4()
        {
            InitializeComponent();
        }

        private void startover_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("PantherLab_level1.xaml", UriKind.Relative));
        }
    }
}
