using PR5WPF.ViewModels;
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
using System.Windows.Shapes;

namespace PR5WPF
{
    /// <summary>
    /// Логика взаимодействия для DinnerWindow.xaml
    /// </summary>
    public partial class DinnerWindow : Window
    {
        public DinnerWindow()
        {
            InitializeComponent();
            DataContext = new DinnerViewModel();
        }
    }
}
