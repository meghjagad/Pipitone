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
    /// Interaction logic for PantherLab_level2UC.xaml
    /// </summary>
    public partial class PantherLab_level2UC : UserControl
    {
        public PantherLab_level2UC()
        {
            InitializeComponent();
        }

  //Booleans to check if the button is clicked or not for different states - mouse over, clicked
        public bool accelerometer_Clicked = false;
        public bool analyze_Baseball_Clicked = false;
        public bool fitness_Tracker_Clicked = false;



        //Accelerometer click, change button image and change text
        private void accelerometer_Click(object sender, RoutedEventArgs e)
        {
            accelerometer_Clicked = true;

            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\accelerometer_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;


            // To change the text, location and color
            line1.Text = "An ";
            //Make text bold.
            Run bold = new Run();
            bold.Text = "accelerometer ";
            bold.FontFamily = new FontFamily("Fonts/#Gotham-Bold");
            bold.FontWeight = FontWeights.Bold;
            line1.Inlines.Add(bold);

            Run nobold = new Run();
            nobold.Text = "measures how quickly something \n speeds up (or slows down), as well as its positioning.";
            line1.Inlines.Add(nobold);
            line1.Margin = new Thickness(925.8, 146.2, 0, 0);
            line1.FontSize = 48;
            line1.FontFamily = new FontFamily("Gotham Book");
            line1.Foreground = Brushes.White;

            rect.Margin = new Thickness(940, 304, 0, 0);
            rect.Width = 1225;

            line2.Text = "How will you use it?";
            line2.Margin = new Thickness(975, 373.7, 0, 0);
            line2.FontSize = 48;
            line2.FontFamily = new FontFamily("Gotham Book");
            line2.Foreground = Brushes.White;

        }
        //analyze baseball click, open level 3 page
        private void analyze_baseball_Click(object sender, RoutedEventArgs e)
        {
            analyze_Baseball_Clicked = true;

            analyze_baseball.Visibility = Visibility.Collapsed;
            line1.Visibility = Visibility.Collapsed;
            line2.Visibility = Visibility.Collapsed;
            accelerometer.Visibility = Visibility.Collapsed;
            fitness_tracker.Visibility = Visibility.Collapsed;
            man.Visibility = Visibility.Collapsed;
            startover.Visibility = Visibility.Collapsed;
            kinectRegion.Visibility = Visibility.Collapsed;
            ((MainWindow)App.Current.MainWindow).ShowPage(new PantherLab_level3UC());

        }
        //Fitness tracker button click, change image to pressed and change text
        private void fitness_tracker_Click(object sender, RoutedEventArgs e)
        {
            fitness_Tracker_Clicked = true;

            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\fitness_tracker_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;


            // To change the text, location and color
            line1.Text = "You'd be competing in a field that's \n already very crowded.";
            line1.Foreground = Brushes.White;
            line1.Margin = new Thickness(1032.1, 147.4, 0, 0);
            line1.FontSize = 57.92;
            line1.FontFamily = new FontFamily("Gotham Bold");

            rect.Margin = new Thickness(987, 322, 0, 0);
            rect.Width = 1135;

            line2.Text = "There are many products already on the market with broad, established \n customer bases-find a market that's not so overcrowded.";
            line2.Foreground = Brushes.White;
            line2.Margin = new Thickness(981.5, 375.7, 0, 0);
            line2.FontSize = 32;
            line2.FontFamily = new FontFamily("Gotham Book");
        }
        private void startover_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)App.Current.MainWindow).ShowPage(new StartScreenUC());
        }



        //ACCELEROMETER
        private void accelerometer_MouseEnter(object sender, MouseEventArgs e)
        {
            if (accelerometer_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\accelerometer_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void accelerometer_MouseLeave(object sender, MouseEventArgs e)
        {
            if (accelerometer_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\accelerometer.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
       
        }

        //ANALYZE BASEBALL
        private void analyze_baseball_MouseEnter(object sender, MouseEventArgs e)
        {
            if (analyze_Baseball_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\analyze_baseball_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void analyze_baseball_MouseLeave(object sender, MouseEventArgs e)
        {
            if (analyze_Baseball_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\analyze_baseball.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
       
        }

        //FITNESS TRACKER
        private void fitness_tracker_MouseEnter(object sender, MouseEventArgs e)
        {
            if (fitness_Tracker_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\fitness_tracker_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void fitness_tracker_MouseLeave(object sender, MouseEventArgs e)
        {
            if (fitness_Tracker_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\fitness_tracker.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
       
        }
    }
}
