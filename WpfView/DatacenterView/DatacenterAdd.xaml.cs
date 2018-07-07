using Controllers;
using Model;
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

namespace WpfView.DatacenterView
{
    /// <summary>
    /// Interaction logic for DatacenterAdd.xaml
    /// </summary>
    public partial class DatacenterAdd : Window
    {
        public DatacenterAdd()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            Datacenter datacenter = new Datacenter();
            DatacenterController datacenterController= new DatacenterController();

            datacenter.Name = DatacenterName.Text;
            datacenter.Location = DatacenterLocation.Text;

            datacenterController.Add(datacenter);

            MessageBox.Show("Datacenter criado com sucesso!");
        }
    }
}
