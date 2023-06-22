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
using Bitlush;

namespace Widget
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Line line;
            TextBlock textBlockNum;
            TextBlock textBlockDate = new TextBlock
            {
                Text = "Jun 8 h. Fri",
                Margin = new Thickness(14, 2, 0, 0),
                HorizontalAlignment = HorizontalAlignment.Left,
                FontSize = 10,
                FontWeight = FontWeights.Bold
            };
            straightedge.Children.Add(textBlockDate);
            for (double i = 10, num = 0; i <= 800; i += 56)
            {
                if (i == 10 || i == 794)
                {
                    line = new Line
                    {
                        X1 = i,
                        Y1 = 0,
                        X2 = i,
                        Y2 = 49,
                        Stroke = Brushes.Black
                    };
                }
                else
                {
                    line = new Line
                    {
                        X1 = i,
                        Y1 = 25,
                        X2 = i,
                        Y2 = 49,
                        Stroke = Brushes.Black
                    };
                }


                textBlockNum = new TextBlock
                {
                    Text = num.ToString(),
                    Margin = new Thickness(i + 4, 21, 0, 0),
                    HorizontalAlignment = HorizontalAlignment.Left,
                    FontSize = 10
                };
                num += 5;

                straightedge.Children.Add(line);
                if (i != 794)
                    straightedge.Children.Add(textBlockNum);

                for (double j = 21.2; j <= 784; j += 11.2)
                {
                    Line lineSmall = new Line
                    {
                        X1 = j,
                        Y1 = 40,
                        X2 = j,
                        Y2 = 49,
                        Stroke = Brushes.Black,
                        StrokeThickness = 0.1
                    };
                    if (j != i)
                        straightedge.Children.Add(lineSmall);
                }
            }
            //this.Title = NumberOfElements().ToString();
            //AvlTree<int, string> tree = new AvlTree<int, string>();
            //tree.Insert(10, "Значение 1");
            //tree.Insert(20, "Значение 2");
        }
        private double NumberOfElements()
        {
            Random random = new Random();
            double randomNumber = random.Next(5600, 56000);
            return randomNumber;
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scrollviewer = sender as ScrollViewer;
            if (e.Delta > 0)
                scrollviewer.LineLeft();
            else
                scrollviewer.LineRight();
            e.Handled = true;
        }
    }
}

