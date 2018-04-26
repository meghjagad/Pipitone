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
    /// Interaction logic for Technologist_level4.xaml
    /// </summary>
    public partial class Technologist_level4 : Page
    {
        //Booleans to check if the button is clicked or not for different states - mouse over, clicked
        public bool stay_independent_Clicked = false;
        public bool leverage_corporate_partner_Clicked = false;
        public bool door_to_door_Clicked = false;

        public Technologist_level4()
        {
            InitializeComponent();
        }

        private void startover_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Start_Screen.xaml", UriKind.Relative));
        }
        private void tellmemore_Click(object sender, RoutedEventArgs e)
        {

        }



        private void stay_independent_Click(object sender, RoutedEventArgs e)
        {
            stay_independent_Clicked = true;
            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\stay_independent_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;

            line1.Text = "Are you sure? Although you'll retain more stock ownership \n independently, you'd need to get into stores yourself.";
            line1.Foreground = Brushes.White;
            line1.Margin = new Thickness(870, 118.2, 0, 0);
            line1.FontSize = 44;
            line1.FontFamily = new FontFamily("Gotham Bold");

            rect.Margin = new Thickness(940,262,0,0);

            line2.Text = "While a large corporate partner might take a substantial \n part of the company, in return, they'll help get your \n product onto shelves at large, national retainers.";
            line2.Foreground = Brushes.White;
            line2.Margin = new Thickness(950, 305, 0, 0);
            line2.FontSize = 40;
            line2.FontFamily = new FontFamily("Gotham Book");
        }
        private void leverage_corporate_partner_Click(object sender, RoutedEventArgs e)
        {
            leverage_corporate_partner_Clicked = true;
            this.NavigationService.Navigate(new Uri("Technologist_level5.xaml", UriKind.Relative));
        }
        private void door_to_door_Click(object sender, RoutedEventArgs e)
        {

            door_to_door_Clicked = true;
            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\door_to_door_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;

            line1.Text = "Knock-knock: That sounds pretty time consuming.";
            line1.Foreground = Brushes.White;
            line1.Margin = new Thickness(830, 167.2, 0, 0);
            line1.FontSize = 46;
            line1.FontFamily = new FontFamily("Gotham Bold");

            rect.Margin = new Thickness(940, 262, 0, 0);

            line2.Text = "A nationwide footprint would help grow your business exponentially-a large corporate partner can help get you into some of the nation's largest retail chains.";
            line2.Foreground = Brushes.White;
            line2.Margin = new Thickness(950, 307.4, 0, 0);
            line2.FontSize = 40;
            line2.FontFamily = new FontFamily("Gotham Book");
        }
        
        private void stay_independent_MouseEnter(object sender, MouseEventArgs e)
        {
            if (stay_independent_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\stay_independent_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void stay_independent_MouseLeave(object sender, MouseEventArgs e)
        {
            if (stay_independent_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\stay_independent.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }

        private void leverage_corporate_partner_MouseEnter(object sender, MouseEventArgs e)
        {
            if (leverage_corporate_partner_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\leverage_corporate_partner_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void leverage_corporate_partner_MouseLeave(object sender, MouseEventArgs e)
        {
            if (leverage_corporate_partner_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\leverage_corporate_partner.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }

        private void door_to_door_MouseEnter(object sender, MouseEventArgs e)
        {
            if (door_to_door_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\door_to_door_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void door_to_door_MouseLeave(object sender, MouseEventArgs e)
        {
            if (door_to_door_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\door_to_door.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
    }
}
