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
    /// Interaction logic for Start_Screen.xaml
    /// </summary>
    public partial class Start_Screen : Page
    {
        public bool controls_Clicked = false;

        public Start_Screen()
        {
            InitializeComponent();
        }

        
        private void noway_Click(object sender, RoutedEventArgs e)
        {
            controls_Clicked = true;

            //Load Pantherlab level 2 page
            this.NavigationService.Navigate(new Uri("PantherLab_level1.xaml", UriKind.Relative));
           
        }

        private void noway_MouseEnter(object sender, MouseEventArgs e)
        {
            if (controls_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Start_Screen_Assets\Controls 2.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }

        private void noway_MouseLeave(object sender, MouseEventArgs e)
        {
            if (controls_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Start_Screen_Assets\Controls 1.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
    }
}
