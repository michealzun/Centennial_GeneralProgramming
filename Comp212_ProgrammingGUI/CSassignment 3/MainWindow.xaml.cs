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

namespace CSassignment3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ComboBoxSemester.ItemsSource = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8" };
            ListBoxCourses.ItemsSource = new List<string>() { "COMP100", "COMP123", "COMP212", "MATH185", "COMM171", "COMP122", "COMP213", "COMP120" };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxSemester.SelectedIndex = 1;
            TextBoxName.Text = "Narendra Pershad";
            ListBoxCourses.UnselectAll();
            RadioButtonDomestic.IsChecked = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String userData = " name: "+TextBoxName.Text +"\n semester: " + ComboBoxSemester.Text + "\n resedency: ";
            userData += (RadioButtonDomestic.IsChecked ?? true) ? " (DOM)" : " (INT)";
            userData += "\n courses: ";
            foreach (var course in ListBoxCourses.SelectedItems) {
                userData += course.ToString() + ",";
            }
            
            MessageBox.Show(userData, "User data", MessageBoxButton.OK);
        }


    }
}
