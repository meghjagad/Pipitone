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
    /// Interaction logic for Idealist_level3UC.xaml
    /// </summary>
    public partial class Idealist_level3UC : UserControl
    {
        public Idealist_level3UC()
        {
            InitializeComponent();
        }

     //Booleans to check if the button is clicked or not for different states - mouse over, clicked
        public bool crowd_funding_Clicked = false;
        public bool innovation_competitions_Clicked = false;
        public bool federal_grant_Clicked = false;


       
        private void startover_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)App.Current.MainWindow).ShowPage(new StartScreenUC());
        }

        private void iamin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void crowd_funding_Click(object sender, RoutedEventArgs e)
        {

            crowd_funding_Clicked = true;
            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\crowdfunding_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;

            //Make text bold.
            line1.Text = "";
            Run bold = new Run();
            bold.Text = "Nice! ";
            bold.FontFamily = new FontFamily("Fonts/#Gotham-Bold");
            bold.FontWeight = FontWeights.Bold;
            line1.Inlines.Add(bold);
            


            //Make text italic
            Run italic = new Run();
            italic.Text = "But you might not raise enough \n capital that way.";
            italic.FontFamily = new FontFamily("Fonts/#Gotham-MediumItalic");
            italic.FontStyle = FontStyles.Italic;
            line1.Inlines.Add(italic);

            line1.Margin = new Thickness(1150, 190, 0, 0);
            line1.FontSize = 50;
            line1.Foreground = Brushes.White;

            rect.Margin = new Thickness(1054, 340, 0, 0);

            line2.Text = "Alternative funding methods can really pay off!";
            line2.Foreground = Brushes.White;

            line2.Margin = new Thickness(1050, 387, 0, 0);
            line2.FontSize = 39;
            line2.FontFamily = new FontFamily("Gotham Book");
            
        }
        private void innovation_competitions_Click(object sender, RoutedEventArgs e)
        {
            innovation_competitions_Clicked = true;
            ((MainWindow)App.Current.MainWindow).ShowPage(new Idealist_level4UC());
        }
        private void federal_grant_Click(object sender, RoutedEventArgs e)
        {
            federal_grant_Clicked = true;

            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\federal_grant_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;

            //Make text bold.
            line1.Text = "";
            Run bold = new Run();
            bold.Text = "Sweet! ";
            bold.FontFamily = new FontFamily("Fonts/#Gotham-Bold");
            bold.FontWeight = FontWeights.Bold;
            line1.Inlines.Add(bold);

            Run nobold = new Run();
            nobold.Text = "Innovation Works provided you with \n support for your grant writing!";
            line1.Inlines.Add(nobold);
            line1.Margin = new Thickness(1000, 190, 0, 0);
            line1.FontSize = 50;
            line1.FontFamily = new FontFamily("Gotham Book");
            line1.Foreground = Brushes.White;

            rect.Margin = new Thickness(1000, 340, 0, 0);

            line2.Text = "You earn a federal Small Business Innovation Research \n (SBIR) grant... but you still need more capital.";
            line2.Foreground = Brushes.White;

            line2.Margin = new Thickness(1010, 387.1, 0, 0);
            line2.FontSize = 40;
            line2.FontFamily = new FontFamily("Gotham Book");

        }

        private void crowd_funding_MouseEnter(object sender, MouseEventArgs e)
        {
            if (crowd_funding_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\crowdfunding_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void crowd_funding_MouseLeave(object sender, MouseEventArgs e)
        {
            if (crowd_funding_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\crowdfunding.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }

        private void innovation_competitions_MouseEnter(object sender, MouseEventArgs e)
        {
            if (innovation_competitions_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\innovation_competitions_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void innovation_competitions_MouseLeave(object sender, MouseEventArgs e)
        {
            if (innovation_competitions_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\innovation_competitions.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }

        private void federal_grant_MouseEnter(object sender, MouseEventArgs e)
        {
            if (federal_grant_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\federal_grant_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void federal_grant_MouseLeave(object sender, MouseEventArgs e)
        {
            if (federal_grant_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\federal_grant.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
    }
}
