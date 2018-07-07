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
    /// Interaction logic for DatacenterManage.xaml
    /// </summary>
    public partial class DatacenterManage : Window
    {
        public DatacenterManage()
        {
            InitializeComponent();
        }

        private void DatacenterList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int id = (DatacenterList.SelectedItem as Datacenter).DatacenterID;

            DatacenterEdit datacenteredit = new DatacenterEdit(id);

            datacenteredit.ShowDialog();

        }

        private void DatacenterList_Loaded(object sender, RoutedEventArgs e)
        {
            DatacenterController datacenterController = new DatacenterController();

            DatacenterList.ItemsSource = datacenterController.ListAll();


        }
    }
}
