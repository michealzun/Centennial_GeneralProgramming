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

namespace CSassignment5
{
    /// <summary>
    /// Interaction logic for Imperative.xaml
    /// </summary>
    public partial class Imperative : Window
    {
        public Imperative()
        {
            InitializeComponent();
        }

        private void textboxSource_TextChanged(object sender, TextChangedEventArgs e)
        {
            double value;
            if (double.TryParse(textboxSource.Text,out value)){
                slideSource.Value = Convert.ToDouble(textboxSource.Text);
            }
        }

        private void slideSource_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (slideSource.Value != Convert.ToDouble(textboxSource.Text)){ 
            textboxSource.Text = slideSource.Value.ToString();
            }
        }
    }
}
