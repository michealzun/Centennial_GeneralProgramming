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

namespace CSassignment5
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

        private void UniformGrid_Click(object sender, MouseButtonEventArgs e)
        {
            Button btn = e.Source as Button;
            switch (btn.Name)
            {
                case "btnCoding":
                    new Imperative().ShowDialog();
                    break;
                case "btnTwoWay":
                    new TwoWay().ShowDialog();
                    break;
                case "btnToTarget":
                    new OneWay().ShowDialog();
                    break;
                case "btnToSource":
                    new OneWayB().ShowDialog();
                    break;
            }
        }
    }
}
