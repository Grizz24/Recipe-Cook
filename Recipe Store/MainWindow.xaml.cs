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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Information> infos = new List<Information>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            infos.Add(new Information()
            {
                Name = txtName.Text,
                Ingredients = txtIngredient.Text,
                Steps = txtSteps.Text,
                Group = txtGroup.Text,
                Quantity = int.Parse(txtQuantity.Text),
                Calories = double.Parse(txtCalories.Text)
            });
            txtName.Text = " ";
            txtIngredient.Text = " ";
            txtSteps.Text = " ";
            txtGroup.Text = " ";
            txtQuantity.Text = " ";
            txtCalories.Text = " ";
            txtName.Focus();
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            lstDisplay.Items.Clear();
            foreach (Information info in infos)
            {
                lstDisplay.Items.Add(info.Name);
            }
        }

        private void btnAdjust_Click(object sender, RoutedEventArgs e)
        {
            Adjust adjustWindow = new Adjust();
            adjustWindow.infoCopy.AddRange(infos);
            adjustWindow.Show();
        }

        private void lstDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var info in infos)
            {
                if (lstDisplay.SelectedItem.ToString().Equals(info.Name))
                {
                    lstDisplayAll.Items.Add(info.Name + Environment.NewLine
                        + "============"
                        + Environment.NewLine

                        + info.Ingredients + Environment.NewLine
                        + "============"
                        + Environment.NewLine

                        + info.Calories + Environment.NewLine
                        + "============"
                        + Environment.NewLine

                        + info.Quantity + Environment.NewLine
                        + "============"
                        + Environment.NewLine

                        + info.Group + Environment.NewLine
                        + "============"
                        + Environment.NewLine);

                    lstDisplaySteps.Items.Add(info.Steps);
                    //MessageBox.Show(student.Name + " - " + student.Surname + " - " + student.Age + " - " + student.Score);
                }
            }
        }
    }
}
