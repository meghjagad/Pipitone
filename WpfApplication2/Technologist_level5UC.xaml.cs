﻿using System;
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
    /// Interaction logic for Technologist_level5UC.xaml
    /// </summary>
    public partial class Technologist_level5UC : UserControl
    {
        public Technologist_level5UC()
        {
            InitializeComponent();
        }

        private void startover_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)App.Current.MainWindow).ShowPage(new StartScreenUC());
        }
    }
}
