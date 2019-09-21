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

namespace aaaaaa
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

        private void ButtonHandler(object sender, RoutedEventArgs e)
        {
            Button button = e.Source as Button;
            switch (button.Name)
            {
                case "btnCanvas":
                    frame.Content = new pgCanvas();
                    break;
                case "btnStackPanel":
                    frame.Content = new pgStackPanel();
                    break;
                case "btnDockPanel":
                    frame.Content = new pgDockPanel();
                    break;
                case "btnWrapPanel":
                    frame.Content = new pgWrapPanel();
                    break;
                case "btnGrid":
                    frame.Content = new pgGrid();
                    break;
                case "btnUniformGrid":
                    frame.Content = new pgUniformGrid();
                    break;
                case "btnTextControls":
                    frame.Content = new pgTextControls();
                    break;
                case "btnImperative":
                    frame.Content = new pgImperative();
                    break;
            }
        }
    }
}
