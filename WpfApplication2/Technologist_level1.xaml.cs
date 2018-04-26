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

namespace WpfApplication2.Technologist_Assets
{
    /// <summary>
    /// Interaction logic for Technologist_level1.xaml
    /// </summary>
    public partial class Technologist_level1 : Page
    {
        //Booleans to check if the button is clicked or not for different states - mouse over, clicked
        public bool no_thanks_Clicked = false;
        public bool thats_not_my_area_Clicked = false;
        public bool lets_give_it_a_shot_Clicked = false;

        public Technologist_level1()
        {
            InitializeComponent();
        }

        private void startover_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Start_Screen.xaml", UriKind.Relative));
        }

        private void no_thanks_Click(object sender, RoutedEventArgs e)
        {
            no_thanks_Clicked = true;

            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\no_thanks_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;

            //Make text bold.
            line1.Text = "";
            Run bold = new Run();
            bold.Text = "Are you sure?";
            bold.FontFamily = new FontFamily("Fonts/#Gotham-Bold");
            bold.FontWeight = FontWeights.Bold;
            line1.Inlines.Add(bold);
            line1.Margin = new Thickness(1365, 113, 0, 0);
            line1.FontSize = 72;
            line1.Foreground = Brushes.White;

           
            rect.Margin = new Thickness(1011, 216, 0, 0);

            line2.Text = "Other attendees say your current prototype is flawed.";
            line2.Foreground = Brushes.White;
            line2.Margin = new Thickness(925, 276.3, 0, 0);
            line2.FontSize = 38;
            line2.FontFamily = new FontFamily("Gotham Book");


            line3.Foreground = Brushes.White;
            line3.Margin = new Thickness(1000, 363.4, 0, 0);
            line3.FontSize = 38;
            line3.FontFamily = new FontFamily("Gotham Book");
            line3.Text = "The juvenile product space hasn't seen much innovation lately-they could really use you...";
           
        }
        private void thats_not_my_area_Click(object sender, RoutedEventArgs e)
        {

            thats_not_my_area_Clicked = true;
            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\thats_not_my_area_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;

            line1.Text = "That's OK!";
            line1.Foreground = Brushes.White;
            line1.Margin = new Thickness(1350, 113.2, 0, 0);
            line1.FontSize = 72;
            line1.FontFamily = new FontFamily("Gotham Bold");

            rect.Margin = new Thickness(1030, 216, 0, 0);

            line2.Text = "Pittsburgh has lots of resources, advisors, investors and institutions to help you navigate.";
            line2.Foreground = Brushes.White;
            line2.Margin = new Thickness(963, 280.4, 0, 0);
            line2.FontSize = 38;
            line2.FontFamily = new FontFamily("Gotham Book");


            line3.Text = "";
            Run italic = new Run();
            italic.Text = "You in?";
            italic.FontFamily = new FontFamily("Fonts/#Gotham-MediumItalic");
            italic.FontStyle = FontStyles.Italic;
            line3.Inlines.Add(italic);
            line3.Foreground = Brushes.White;
            line3.Margin = new Thickness(950,409.3,0,0);
           
           
        }
        private void lets_give_it_a_shot_Click(object sender, RoutedEventArgs e)
        {
            lets_give_it_a_shot_Clicked = true;
            this.NavigationService.Navigate(new Uri("Technologist_level2.xaml", UriKind.Relative));
        }

        private void no_thanks_MouseEnter(object sender, MouseEventArgs e)
        {
            if (no_thanks_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\no_thanks_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void no_thanks_MouseLeave(object sender, MouseEventArgs e)
        {
            if (no_thanks_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\no_thanks.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }

        private void thats_not_my_area_MouseEnter(object sender, MouseEventArgs e)
        {
            if (thats_not_my_area_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\thats_not_my_area_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void thats_not_my_area_MouseLeave(object sender, MouseEventArgs e)
        {
            if (thats_not_my_area_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\thats_not_my_area.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }

        private void lets_give_it_a_shot_MouseEnter(object sender, MouseEventArgs e)
        {
            if (lets_give_it_a_shot_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\lets_give_it_a_shot_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void lets_give_it_a_shot_MouseLeave(object sender, MouseEventArgs e)
        {
            if (lets_give_it_a_shot_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\lets_give_it_a_shot.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
    }
}
