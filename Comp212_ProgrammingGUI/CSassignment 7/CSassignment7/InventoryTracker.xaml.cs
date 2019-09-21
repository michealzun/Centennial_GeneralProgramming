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

namespace CSassignment7
{
    /// <summary>
    /// Interaction logic for InventoryTracker.xaml
    /// </summary>
    public partial class InventoryTracker : UserControl
    {
        public InventoryTracker()
        {
            InitializeComponent();


        }
        public string CarName
        {
            get
            {
                return Name.Content.ToString();
            }

            set
            {
                Name.Content = value;
            }
        }

       
       public string StartValue
        {
            get
            {
                return sValue.Content.ToString();
            }

            set
            {
                sValue.Content = value;
            }
        }

        public string CurrentValue
        {
            get
            {
                return cValue.Content.ToString();
            }

            set
            {
                cValue.Content = value;
            }
        }


    }
}
