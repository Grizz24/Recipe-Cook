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

namespace menu
{
    /// <summary>
    /// Interaction logic for Adjust.xaml
    /// </summary>
    public partial class Adjust : Window
    {
        public List<Information> infoCopy = new List<Information>();
        public Adjust()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.infos.AddRange(infoCopy);
            this.Close();
        }

        private void btnAjust_Click(object sender, RoutedEventArgs e)
        {
            foreach (var info in infoCopy)
            {
                if (info.Name.Equals(txtSearch.Text))
                {
                    if (radHalf.IsChecked == true)
                    {
                        info.Quantity *= 0.5;
                        info.Calories *= 0.5;
                    }

                    else if (rad2.IsChecked == true)
                    {
                        info.Quantity *= 2;
                        info.Calories *= 2;
                    }
                    else
                    {
                        info.Quantity *= 3;
                        info.Calories *= 3;
                    }
                }
            }
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            //var theStudent = from student in studentsCopy select student;
            foreach (var info in infoCopy)
            {
                lstShow.Items.Add(info.Name + Environment.NewLine 
                    + "Quantity " + info.Quantity + Environment.NewLine
                    + "Calories " + info.Calories + Environment.NewLine
                    );
            }
        }
    }
}
