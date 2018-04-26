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

namespace WpfApplication2.Start_Screen_Assets
{
    /// <summary>
    /// Interaction logic for Idealist_level1.xaml
    /// </summary>
    public partial class Idealist_level1 : Page
    {
        //Booleans to check if the button is clicked or not for different states - mouse over, clicked
        public bool be_low_cost_Clicked = false;
        public bool work_on_everyone_Clicked = false;
        public bool do_both_Clicked = false;

        public Idealist_level1()
        {
            InitializeComponent();
        }

        private void startover_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Start_Screen.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void be_low_cost_Click(object sender, RoutedEventArgs e)
        {
            be_low_cost_Clicked = true;

            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();


            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\be_low_cost)_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;

            //Make text bold.
            line1.Text = "";
            Run bold = new Run();
            bold.Text = "Awesome! ";
            bold.FontFamily = new FontFamily("Fonts/#Gotham-Bold");
            bold.FontWeight = FontWeights.Bold;
            line1.Inlines.Add(bold);


            Run nobold = new Run();
            nobold.Text = "But you can make your technology \n even more perfect.";
            line1.Inlines.Add(nobold);
            line1.Margin = new Thickness(984, 178, 0, 0);
            line1.FontSize = 50;
            line1.FontFamily = new FontFamily("Gotham Book");
            line1.Foreground = Brushes.White;

            rect.Margin = new Thickness(984.5,327,0,0);

            line2.Text = "Bedsores are difficult to detection people with dark skin tones, independent of their race.";
            line2.Foreground = Brushes.White;
            line2.Margin = new Thickness(1028, 367, 0, 0);
            line2.FontSize = 34;
            line2.FontFamily = new FontFamily("Gotham Book");


            line3.Text = "";
        }
        private void work_on_everyone_Click(object sender, RoutedEventArgs e)
        {


            work_on_everyone_Clicked = true;
            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\work_on_everyone_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;

            //Make text bold.
            line1.Text = "";
            Run bold = new Run();
            bold.Text = "Great! ";
            bold.FontFamily = new FontFamily("Fonts/#Gotham-Bold");
            bold.FontWeight = FontWeights.Bold;
            line1.Inlines.Add(bold);


            Run nobold = new Run();
            nobold.Text = "But you can make your technology \n even more perfect.";
            line1.Inlines.Add(nobold);
            line1.Margin = new Thickness(984, 178, 0, 0);
            line1.FontSize = 50;
            line1.FontFamily = new FontFamily("Gotham Book");
            line1.Foreground = Brushes.White;

            rect.Margin = new Thickness(984.5, 327, 0, 0);

            line2.Text = "Many hospitals and nursing homes are very cost sensitive. They heavily \n consider the impact of cost when adopting new technology.";
            line2.Foreground = Brushes.White;
            line2.Margin = new Thickness(963, 367, 0, 0);
            line2.FontSize = 34;
            line2.FontFamily = new FontFamily("Gotham Book");
            line3.Text = "";
        }
        private void do_both_Click(object sender, RoutedEventArgs e)
        {
            do_both_Clicked = true;
            this.NavigationService.Navigate(new Uri("Idealist_level2.xaml", UriKind.Relative));
        }


        private void be_low_cost_MouseEnter(object sender, MouseEventArgs e)
        {
            if (be_low_cost_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\be_low_cost_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void be_low_cost_MouseLeave(object sender, MouseEventArgs e)
        {
            if (be_low_cost_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\be_low_cost.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }

        }

        private void work_on_everyone_MouseEnter(object sender, MouseEventArgs e)
        {
            if (work_on_everyone_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\work_on_everyone_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void work_on_everyone_MouseLeave(object sender, MouseEventArgs e)
        {
            if (work_on_everyone_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\work_on_everyone2.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }

        private void do_both_MouseEnter(object sender, MouseEventArgs e)
        {
            if (do_both_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\do_both_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void do_both_MouseLeave(object sender, MouseEventArgs e)
        {
            if (do_both_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Idealist_Assets\do_both.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
    }
}
