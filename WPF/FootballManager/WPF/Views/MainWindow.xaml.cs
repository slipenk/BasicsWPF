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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*DoubleAnimation btnAnination = new DoubleAnimation();
            btnAnination.From = 0;
            btnAnination.To = 200;
            btnAnination.Duration = TimeSpan.FromSeconds(20);
            Clubs.BeginAnimation(Button.WidthProperty, btnAnination);
            Footballers.BeginAnimation(Button.WidthProperty, btnAnination);
            Music.BeginAnimation(Button.WidthProperty, btnAnination);*/
        }
    }
}
