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

namespace Zadatak06
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addPanel_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < 100; i++) 
                daddy.Children.Add(randomPanel());
        }

        private StackPanel randomPanel()
        {
            StackPanel sp = new StackPanel
            {
                Width = 20,
                Height = 20,
                Margin = new Thickness(3),
                Background = randomColor(),
                LayoutTransform = randomRotation()
            };
            return sp;
        }

        private Transform randomRotation()
        {
            return new RotateTransform(r.Next(360));
        }

        private Brush randomColor()
        {
            var c = Color.FromRgb((byte)r.Next(255), (byte)r.Next(255), (byte)r.Next(255));
            return new SolidColorBrush(c);
        }

        private void removePanel_Click(object sender, RoutedEventArgs e)
        {
            daddy.Children.Clear();
        }
    }
}
