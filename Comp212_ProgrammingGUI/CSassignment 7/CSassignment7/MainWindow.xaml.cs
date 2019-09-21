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
using System.Windows.Threading;


namespace CSassignment7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {
            InitializeComponent();
            /////
            test();
            //  Update UI setup
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(UpdateGui);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        public void test()
        {
            string[] models = new string[] { "Toyota", "Honda", "Ford", "Nissan" };
            Db.Init(models);
            foreach (string model in models)
            {
                //creates a user control
                InventoryTracker car = new InventoryTracker()
                {
                    //sets the model for this user control
                    CarName = model,
                    //sets the start value for this control
                    StartValue = Db.GetInventory(model).ToString()
                };

                WpnlInventory.Children.Add(car);

                
            }

        }

        private void UpdateGui(object sender, EventArgs e)
        {
            foreach (FrameworkElement fe in WpnlInventory.Children)
            {
                if (fe is InventoryTracker)
                {
                    InventoryTracker car = (InventoryTracker)fe;
                    car.CurrentValue = Db.GetInventory(car.CarName).ToString();
                }
            }
        }

        
    }
}
