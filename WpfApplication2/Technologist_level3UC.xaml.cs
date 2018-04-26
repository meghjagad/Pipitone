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
    /// Interaction logic for Technologist_level3UC.xaml
    /// </summary>
    public partial class Technologist_level3UC : UserControl
    {
        public Technologist_level3UC()
        {
            InitializeComponent();
        }

          //Booleans to check if the button is clicked or not for different states - mouse over, clicked
        public bool consider_moving_Clicked = false;
        public bool anchor_in_pittsburgh_Clicked = false;
        public bool robot_babysitter_Clicked = false;

     
        private void startover_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)App.Current.MainWindow).ShowPage(new StartScreenUC());
        }

        private void consider_moving_Click(object sender, RoutedEventArgs e)
        {
            consider_moving_Clicked = true;
            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\consider_moving_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;

            line1.Text = "Are you sure?";
            line1.Foreground = Brushes.White;
            line1.Margin = new Thickness(870, 113.2, 0, 0);
            line1.FontSize = 72;
            line1.FontFamily = new FontFamily("Gotham Bold");

            rect.Margin = new Thickness(950, 214, 0, 0);

            line2.Text = "BlueTree Allied Angels and Innovation Works are offering \n funding-and they're right here.";
            line2.Foreground = Brushes.White;
            line2.Margin = new Thickness(980, 254.4, 0, 0);
            line2.FontSize = 38;
            line2.FontFamily = new FontFamily("Gotham Book");

            line3.Text = "In fact, hundreds of technology startups raise money every year \n through these institutions and others.";
            line3.Foreground = Brushes.White;
            line3.Margin = new Thickness(900, 377.6, 0, 0);
            line3.FontSize = 36;
            line3.FontFamily = new FontFamily("Gotham Book");
           
        }
        private void anchor_in_pittsburgh_Click(object sender, RoutedEventArgs e)
        {
            anchor_in_pittsburgh_Clicked = true;
            ((MainWindow)App.Current.MainWindow).ShowPage(new Technologist_level4UC());
        }
        private void robot_babysitter_Click(object sender, RoutedEventArgs e)
        {
            robot_babysitter_Clicked = true;
            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\robot_babysitter_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;

            line1.Text = "Stop trying to make cyborg sitters happen.";
            line1.Foreground = Brushes.White;
            line1.Margin = new Thickness(850, 110.4, 0, 0);
            line1.FontSize = 55;
            line1.FontFamily = new FontFamily("Gotham Bold");

            rect.Margin = new Thickness(930, 198, 0, 0);

            line2.Text = "You'd be arriving pretty early to that market, anyway. Plus, parents \n won't buy technology that doesn't meet their specific needs.";
            line2.Foreground = Brushes.White;
            line2.Margin = new Thickness(950, 238.4, 0, 0);
            line2.FontSize = 34;
            line2.FontFamily = new FontFamily("Gotham Book");


            line3.Text = "Pittsburgh has world-class technology talent associated with its research \n universities and other anchor institutions-and access to the top technology.";
            line3.Foreground = Brushes.White;
            line3.Margin = new Thickness(870, 355.6, 0, 0);
            line3.FontSize = 32;
            line3.FontFamily = new FontFamily("Gotham Book");
        }
        
        private void consider_moving_MouseEnter(object sender, MouseEventArgs e)
        {
            if (consider_moving_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\consider_moving_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void consider_moving_MouseLeave(object sender, MouseEventArgs e)
        {
            if (consider_moving_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\consider_moving.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }

        private void anchor_in_pittsburgh_MouseEnter(object sender, MouseEventArgs e)
        {
            if (anchor_in_pittsburgh_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\anchor_in_pittsburgh_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void anchor_in_pittsburgh_MouseLeave(object sender, MouseEventArgs e)
        {
            if (anchor_in_pittsburgh_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\anchor_in_pittsburgh.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }

        private void robot_babysitter_MouseEnter(object sender, MouseEventArgs e)
        {
            if (robot_babysitter_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\robot_babysitter_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void robot_babysitter_MouseLeave(object sender, MouseEventArgs e)
        {
            if (robot_babysitter_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Technologist_Assets\robot_babysitter.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
    }
}
