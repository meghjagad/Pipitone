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
    /// Interaction logic for Idealist_level2UC.xaml
    /// </summary>
    public partial class Idealist_level2UC : UserControl
    {
        public Idealist_level2UC()
        {
            InitializeComponent();
        }
 //Booleans to check if the button is clicked or not for different states - mouse over, clicked
        public bool home_office_Clicked = false;
        public bool project_olympus_Clicked = false;
        public bool private_office_space_Clicked = false;

        private void startover_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)App.Current.MainWindow).ShowPage(new StartScreenUC());
        }

        private void iamin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void home_office_Click(object sender, RoutedEventArgs e)
        {
            home_office_Clicked = true;

            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\home_office_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;

            //Make text bold.
            line1.Text = "";
            Run bold = new Run();
            bold.Text = "Really?";
            bold.FontFamily = new FontFamily("Fonts/#Gotham-Bold");
            bold.FontWeight = FontWeights.Bold;
            line1.Inlines.Add(bold);
            line1.Margin = new Thickness(1550, 178, 0, 0);
            line1.FontSize = 50;
            line1.Foreground = Brushes.White;

            rect.Margin = new Thickness(1054,271,0,0);

            line2.Text = "Your university's incubator can give you free office \n space and other resources, like access to other \n innovators and experts-plus, it's right on campus.";
            line2.Foreground = Brushes.White;
            line2.Margin = new Thickness(1010, 319, 0, 0);
            line2.FontSize = 40;
            line2.FontFamily = new FontFamily("Gotham Book");
            
        }
        private void project_olympus_Click(object sender, RoutedEventArgs e)
        {
            project_olympus_Clicked = true;

            ((MainWindow)App.Current.MainWindow).ShowPage(new Idealist_level3UC());
        }
        private void private_office_space_Click(object sender, RoutedEventArgs e)
        {

            private_office_space_Clicked = true;
            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\private_office_space_pressed.png", UriKind.Absolute);
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
            line1.Margin = new Thickness(1455, 178, 0, 0);
            line1.FontSize = 50;
            line1.Foreground = Brushes.White;

            rect.Margin = new Thickness(1054, 271, 0, 0);

            line2.Text = "Money is tight and your university's on-campus incubator \n can give you more than just free office space.";
            line2.Foreground = Brushes.White;
            line2.Margin = new Thickness(1010, 319, 0, 0);
            line2.FontSize = 40;
            line2.FontFamily = new FontFamily("Gotham Book");
        }


        private void home_office_MouseEnter(object sender, MouseEventArgs e)
        {
            if (home_office_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\home_office_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void home_office_MouseLeave(object sender, MouseEventArgs e)
        {
            if (home_office_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\home_office.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }

        private void project_olympus_MouseEnter(object sender, MouseEventArgs e)
        {
            if (project_olympus_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\project_olympus_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void project_olympus_MouseLeave(object sender, MouseEventArgs e)
        {
            if (project_olympus_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\project_olympus.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }

        private void private_office_space_MouseEnter(object sender, MouseEventArgs e)
        {
            if (private_office_space_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\private_office_space_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void private_office_space_MouseLeave(object sender, MouseEventArgs e)
        {
            if (private_office_space_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\private_office_space.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
    }
}
