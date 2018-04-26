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
    /// Interaction logic for Technologist_level2UC.xaml
    /// </summary>
    public partial class Technologist_level2UC : UserControl
    {
        public Technologist_level2UC()
        {
            InitializeComponent();
        }

         //Booleans to check if the button is clicked or not for different states - mouse over, clicked
        public bool rock_a_bye_baby_Clicked = false;
        public bool monitoring_infants_Clicked = false;
        public bool babysitting_is_expensive_Clicked = false;


        private void startover_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)App.Current.MainWindow).ShowPage(new StartScreenUC());
        }

        private void rock_a_bye_baby_Click(object sender, RoutedEventArgs e)
        {
            rock_a_bye_baby_Clicked = true;
            ((MainWindow)App.Current.MainWindow).ShowPage(new Technologist_level3UC());
        }
        private void monitoring_infants_Click(object sender, RoutedEventArgs e)
        {
            monitoring_infants_Clicked = true;

            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\monitoring_infants_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;

            line1.Text = "Baby monitors have been around since the 1930s.";
            line1.Foreground = Brushes.White;
            line1.Margin = new Thickness(950, 195.4, 0, 0);
            line1.FontSize = 46;
            line1.FontFamily = new FontFamily("Gotham Bold");

            rect.Margin = new Thickness(950,300,0,0);

            line2.Text = "Try something innovative that uses your robotics background.";
            line2.Foreground = Brushes.White;
            line2.Margin = new Thickness(920, 342.4, 0, 0);
            line2.FontSize = 38;
            line2.FontFamily = new FontFamily("Gotham Book");

            line3.Text = "";
        }
        private void babysitting_is_expensive_Click(object sender, RoutedEventArgs e)
        {

            babysitting_is_expensive_Clicked = true;
            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\babysitting_is_expensive_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;

            line1.Text = "A cyborg sitter?";
            line1.Foreground = Brushes.White;
            line1.Margin = new Thickness(1275, 118.2, 0, 0);
            line1.FontSize = 65;
            line1.FontFamily = new FontFamily("Gotham Bold");

            rect.Margin = new Thickness(950, 228.4, 0, 0);

            line2.Text = "Be practical. Innovation requires more than just ";
            Run bold = new Run();
            bold.Text = "baby steps...";
            bold.FontFamily = new FontFamily("Fonts/#Gotham-Bold");
            bold.FontWeight = FontWeights.Bold;
            line2.Inlines.Add(bold);
            line2.Foreground = Brushes.White;
            line2.Margin = new Thickness(900, 280.4, 0, 0);
            line2.FontSize = 38;
            line2.FontFamily = new FontFamily("Gotham Book");

            line3.Text = "Plus, babies need warmth and comfort- \n even when electronics are involved.";
            line3.Foreground = Brushes.White;
            line3.Margin = new Thickness(1175, 350, 0, 0);
            line3.FontSize = 36;
            line3.FontFamily = new FontFamily("Gotham Book");
        }

        private void rock_a_bye_baby_MouseEnter(object sender, MouseEventArgs e)
        {
            if (rock_a_bye_baby_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\rock_a_bye_baby_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void rock_a_bye_baby_MouseLeave(object sender, MouseEventArgs e)
        {
            if (rock_a_bye_baby_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\rock_a_bye_baby.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }

        private void monitoring_infants_MouseEnter(object sender, MouseEventArgs e)
        {
            if (monitoring_infants_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\monitoring_infants_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void monitoring_infants_MouseLeave(object sender, MouseEventArgs e)
        {
            if (monitoring_infants_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\monitoring_infants.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }

        private void babysitting_is_expensive_MouseEnter(object sender, MouseEventArgs e)
        {
            if (babysitting_is_expensive_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\babysitting_is_expensive_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void babysitting_is_expensive_MouseLeave(object sender, MouseEventArgs e)
        {
            if (babysitting_is_expensive_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\babysitting_is_expensive.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
    }
}
