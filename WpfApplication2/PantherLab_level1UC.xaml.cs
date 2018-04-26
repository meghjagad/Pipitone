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
    /// Interaction logic for PantherLab_level1UC.xaml
    /// </summary>
    public partial class PantherLab_level1UC : UserControl
    {
        public PantherLab_level1UC()
        {
            InitializeComponent();
        }
   //Booleans to check if the button is clicked or not for different states - mouse over, clicked
        public bool noway_Clicked = false;
        public bool tellmemore_Clicked = false;
        public bool iamin_Clicked = false;

        /*
          BUTTON CLICKS
         */

        //No way button, change the image on the button, and show the text
        private void Button_Click(object sender, RoutedEventArgs e)
        {
        
            //To indicate that the button is pressed
            noway_Clicked = true;

            //Changes image on button when you press it.
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\noway_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;


            // To change the text, location and color
            line1.Text = "Are you sure?";
            line1.Margin = new Thickness(1320, 115, 0, 0);
            line1.FontSize = 72;
            line1.FontFamily = new FontFamily("Gotham Bold");
            line1.Foreground = Brushes.White;


            //Change position of the line
            rect.Margin = new Thickness(977,226,0,0);


            line2.Text = "Pittsburgh has lots of resources to support innovative \n risk-takers, such as entrepreneurial executives who can \n coach you, strategic investors who can fund you and  \n advisors who can introduce you to partners and customers.";
            line2.Foreground = Brushes.White;
            line2.Margin = new Thickness(973, 264, 0, 0);
            line2.FontSize = 34;
            line2.FontFamily = new FontFamily("Gotham Book");

            line3.Text = "";
        }
        private void iamin_Click(object sender, RoutedEventArgs e)
        {
            iamin_Clicked = true;
            noway.Visibility = Visibility.Collapsed;
            iamin.Visibility = Visibility.Collapsed;
            tellmemore.Visibility = Visibility.Collapsed;
            line1.Visibility = Visibility.Collapsed;
            line2.Visibility = Visibility.Collapsed;
            line3.Visibility = Visibility.Collapsed;
            startover.Visibility = Visibility.Collapsed;
            man.Visibility = Visibility.Collapsed;
            
            //Load Pantherlab level 2 page
            ((MainWindow)App.Current.MainWindow).ShowPage(new PantherLab_level2UC());
          
        }
        //Tell me more click, change the text
        private void tellmemore_Click(object sender, RoutedEventArgs e)
        {
            tellmemore_Clicked = true;
            Button button = sender as Button;
            ImageBrush brush = new ImageBrush();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\tellmemore_pressed.png", UriKind.Absolute);
            bitmap.EndInit();
            brush.ImageSource = bitmap;
            button.Background = brush;
           
            //Change text
            line1.Text = "You and the researcher have a common passion \n -and idea for product market fit: sports";
            line1.Foreground = Brushes.White;
            line1.Margin = new Thickness(973, 146, 0, 0);
            line1.FontSize = 48;
            line1.FontFamily = new FontFamily("Gotham Bold");

            rect.Margin = new Thickness(1019,319,0,0);
            line2.Text = "Sometimes passion is the best asset. ";

            //Make text italic
            Run italic = new Run();
            italic.Text = "You in?";
            italic.FontFamily = new FontFamily("Fonts/#Gotham-MediumItalic");
            italic.FontStyle = FontStyles.Italic;
            line2.Inlines.Add(italic);

            line2.Foreground = Brushes.White;
            line2.Margin = new Thickness(983, 379, 0, 0);
            line2.FontSize = 48;
            line2.FontFamily = new FontFamily("Gotham Book");


            line3.Text = "";
        }
        private void startover_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)App.Current.MainWindow).ShowPage(new StartScreenUC());
        }



        /*
          Code for changing the image for mouse enter and exit events
         */

        //NO WAY
        private void noway_MouseEnter(object sender, MouseEventArgs e)
        {

            if (noway_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\noway_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void noway_MouseLeave(object sender, MouseEventArgs e)
        {
            if (noway_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\noway.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
       
        }

        //TELL ME MORE
        private void tellmemore_MouseEnter(object sender, MouseEventArgs e)
        {
            if (tellmemore_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\tellmemore_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void tellmemore_MouseLeave(object sender, MouseEventArgs e)
        {
            if (tellmemore_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\tellmemore.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }

        //I AM IN
        private void iamin_MouseEnter(object sender, MouseEventArgs e)
        {
            if (iamin_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\iamin_scaled.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }
        private void iamin_MouseLeave(object sender, MouseEventArgs e)
        {
            if (iamin_Clicked == false)
            {
                Button button = sender as Button;
                ImageBrush brush = new ImageBrush();
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"C:\Users\PC\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\Assets\iamin.png", UriKind.Absolute);
                bitmap.EndInit();
                brush.ImageSource = bitmap;
                button.Background = brush;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
