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
    /// Interaction logic for CompanyFoundersProfilesUC.xaml
    /// </summary>
    public partial class CompanyFoundersProfilesUC : UserControl
    {
        public CompanyFoundersProfilesUC()
        {
            InitializeComponent();
        }

        private void RiskTaker_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)App.Current.MainWindow).ShowPage(new PantherLab_level1UC());
        }

        private void Idealist_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)App.Current.MainWindow).ShowPage(new Idealist_level1UC());
        }

        private void Technologist_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)App.Current.MainWindow).ShowPage(new Technologist_level1UC());
        }
    }
}
