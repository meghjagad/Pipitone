using Microsoft.Kinect.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Drawing;
using WpfPageTransitions;
namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void ShowPage(UserControl newPage)
        {
            if (newPage != null)
                pageTransitionControl.ShowPage(newPage);
        }
        public MainWindow()
        {
            InitializeComponent();
            // Listen to Kinect pointer events
            KinectCoreWindow kinectCoreWindow = KinectCoreWindow.GetForCurrentThread();
            kinectCoreWindow.PointerMoved += kinectCoreWindow_PointerMoved;
        }

        void KinectPointerPointSample_Loaded(object sender, RoutedEventArgs e)
        {
            // Listen to Kinect pointer events
            KinectCoreWindow kinectCoreWindow = KinectCoreWindow.GetForCurrentThread();
            kinectCoreWindow.PointerMoved += kinectCoreWindow_PointerMoved;
        }

        private void kinectCoreWindow_PointerMoved(object sender, KinectPointerEventArgs args)
        {
            KinectPointerPoint kinectPointerPoint = args.CurrentPoint;

            bool isEngaged = kinectPointerPoint.Properties.IsEngaged;

            if (isEngaged)
            {

                System.Drawing.Point mousePt = new System.Drawing.Point((int)(kinectPointerPoint.Position.X * kinectRegion.ActualWidth+390), (int)(kinectPointerPoint.Position.Y * kinectRegion.ActualHeight));
                System.Windows.Forms.Cursor.Position = mousePt;
                     
            }
            this.Cursor = Cursors.None;   
        }
      
        //Start the application
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            startover.Visibility = Visibility.Collapsed;
            ((MainWindow)App.Current.MainWindow).ShowPage(new StartScreenUC());

         // _NavigationFrame.Navigate(new Start_Screen());
         
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void startover_MouseEnter(object sender, MouseEventArgs e)
        {

        }



    }
}
    
