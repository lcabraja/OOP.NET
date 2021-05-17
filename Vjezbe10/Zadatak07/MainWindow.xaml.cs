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

namespace Zadatak07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int rowCount = Grid.RowDefinitions.Count;
            int colCount = Grid.ColumnDefinitions.Count;

            foreach (Button button in Grid.Children)
            {
                int row = (int)button.GetValue(Grid.RowProperty);
                int col = (int)button.GetValue(Grid.ColumnProperty);
                
                int newCol = ++col % 3;
                int newRow = col % 3 == 0 ? ++row % 2 : row;

                button.SetValue(Grid.ColumnProperty, newCol);
                button.SetValue(Grid.RowProperty, newRow);
            }

            Grid.Background = randomGradient();
        }

        private Brush randomGradient()
        {
            var gradient = new LinearGradientBrush();
            var gradstop1 = new GradientStop()
            {
                Color = randomColor(),
                Offset = 0
            };
            var gradstop2 = new GradientStop()
            {
                Color = randomColor(),
                Offset = 1
            };
            gradient.GradientStops.Add(gradstop1);
            gradient.GradientStops.Add(gradstop2);
            return gradient;
        }

        private Color randomColor()
        {
            return Color.FromRgb((byte)r.Next(255), (byte)r.Next(255), (byte)r.Next(255));
        }

    }
}
