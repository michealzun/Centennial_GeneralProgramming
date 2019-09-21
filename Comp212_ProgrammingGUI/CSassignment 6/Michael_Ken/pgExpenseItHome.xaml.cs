﻿using System;
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

namespace Michael_Ken
{
    /// <summary>
    /// Interaction logic for pgExpenseItHome.xaml
    /// </summary>
    public partial class pgExpenseItHome : Page
    {
        public pgExpenseItHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            NavigationService.Navigate(new pgExpenseReportPage(peopleListBox.SelectedItem));

        }
    }
}
