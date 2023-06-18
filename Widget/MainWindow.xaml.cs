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
            for (int i = 10, num = 0; i <= 100; i += 30)
            {
                Line line = new Line
                {
                    X1 = i,
                    Y1 = 25,
                    X2 = i,
                    Y2 = 50,
                    Stroke = Brushes.Black
                };

                TextBlock textBlock = new TextBlock
                {
                    Text = num.ToString(),
                    Margin = new Thickness(i, 20, 0, 0),
                    HorizontalAlignment = HorizontalAlignment.Left
                    
                };
                num += 5;

                lineCanvas.Children.Add(line);
                lineCanvas.Children.Add(textBlock);
            }
        }

    }
}
