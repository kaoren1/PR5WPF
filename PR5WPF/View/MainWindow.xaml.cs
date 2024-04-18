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

namespace PR5WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            BreakfastWindow b = new BreakfastWindow();
            b.Show();
        }

        private void L_Click(object sender, RoutedEventArgs e)
        {
            LunchWindow l = new LunchWindow();
            l.Show();
        }

        private void D_Click(object sender, RoutedEventArgs e)
        {
            DinnerWindow d = new DinnerWindow();
            d.Show();
        }
    }
}
