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
    /// Interaction logic for PantherLav_level3.xaml
    /// </summary> 
    public partial class PantherLav_level3 : Page
    {
        public bool get_Selfie_Clicked = false;
        public bool build_Relationship_Clicked = false;
        public bool sell_your_Product_Clicked = false;



        public PantherLav_level3()
        {
            InitializeComponent();
        }


        //Get selfie click, change the image and text
        private void get_selfie_Click(object sender, RoutedEventArgs e)
        {
            get_Selfie_Clicked = true;

            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\get_selfie_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;

            // To change the text, location and color
            line1.Text = "Nice! You got ";

            //Make text bold.
            Run bold = new Run();
            bold.Text = "42 Likes ";
            bold.FontFamily = new FontFamily("Fonts/#Gotham-Bold");
            bold.FontWeight = FontWeights.Bold;
            line1.Inlines.Add(bold);

            Run nobold = new Run();
            nobold.Text = "on Instagram!";
            line1.Inlines.Add(nobold);

            line1.Foreground = Brushes.White; 
            line1.Margin = new Thickness(800, 178.2, 0, 0);
            line1.FontSize = 55;
            line1.FontFamily = new FontFamily("Gotham Book");
            line1.Foreground = Brushes.White;

            rect.Margin = new Thickness(1025,285,0,0);
            rect.Width = 1030;

            line2.Text = "Unfortunately, Likes don't fund startups.";
            line2.Margin = new Thickness(850, 343.1, 0, 0);
            line2.FontSize = 42;
            line2.FontFamily = new FontFamily("Gotham Book");
            line2.Foreground = Brushes.White;
        }
        //Open level 4
        private void build_a_relationship_Click(object sender, RoutedEventArgs e)
        {
            build_Relationship_Clicked = true;
            this.NavigationService.Navigate(new Uri("PantherLab_level4.xaml", UriKind.Relative));
        }
        //Sell your product click, change the image and text
        private void sell_your_product_Click(object sender, RoutedEventArgs e)
        {
            sell_your_Product_Clicked = true;

            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\sell_your_product_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;


            // To change the text, location and color
            line1.Text = "Not so fast.";
            line1.Foreground = Brushes.White;
            line1.Margin = new Thickness(800, 147.2, 0, 0);
            line1.FontSize = 55;
            line1.FontFamily = new FontFamily("Gotham Bold");
            line1.Foreground = Brushes.White;

            rect.Margin = new Thickness(1025,237, 0, 0);
            rect.Width = 1030;

            line2.Text = "While you might gain a customer and earn short-term revenue, you \n could leverage this contact in more valuable ways if you're patient. \n\n He knows mentors and investors who would love your swing tracker.";
            line2.Foreground = Brushes.White;
            line2.Margin = new Thickness(850, 289.1, 0, 0);
            line2.FontSize = 34;
            line2.FontFamily = new FontFamily("Gotham Book");
            line2.Foreground = Brushes.White;
        }
        private void startover_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Start_Screen.xaml", UriKind.Relative));
        }



        //GET SELFIE
        private void get_selfie_MouseEnter(object sender, MouseEventArgs e)
        {
            if (get_Selfie_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\get_selfie_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void get_selfie_MouseLeave(object sender, MouseEventArgs e)
        {
            if (get_Selfie_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\get_selfie.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }

        //BUILD A RELATIONSHIP
        private void build_a_relationship_MouseEnter(object sender, MouseEventArgs e)
        {
            if (build_Relationship_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\build_a_relationsip_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void build_a_relationship_MouseLeave(object sender, MouseEventArgs e)
        {
            if (build_Relationship_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\build_a_relationsip.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }

        //SELL YOUR PRODUCT
        private void sell_your_product_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sell_your_Product_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\sell_your_product_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void sell_your_product_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sell_your_Product_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\sell_your_product.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
    }
}
