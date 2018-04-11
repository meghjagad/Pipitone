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
    /// Interaction logic for CompanyFounderProfiles.xaml
    /// </summary>
    public partial class CompanyFounderProfiles : Page
    {
        public CompanyFounderProfiles()
        {
            InitializeComponent();
        }

        private void RiskTaker_Click(object sender, RoutedEventArgs e)
        {
            //Load Pantherlab level 2 page
            this.NavigationService.Navigate(new Uri("PantherLab_level1.xaml", UriKind.Relative));
        }

        private void Idealist_Click(object sender, RoutedEventArgs e)
        {
            //Load Pantherlab level 2 page
            this.NavigationService.Navigate(new Uri("PantherLab_level1.xaml", UriKind.Relative));
        }

        private void Technologist_Click(object sender, RoutedEventArgs e)
        {
            //Load Pantherlab level 2 page
            this.NavigationService.Navigate(new Uri("PantherLab_level1.xaml", UriKind.Relative));
        }
    }
}
