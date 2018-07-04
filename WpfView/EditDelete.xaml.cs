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

namespace WpfView
{
    /// <summary>
    /// Interaction logic for EditDelete.xaml
    /// </summary>
    public partial class EditDelete : Window
    {
        MachineController machineController = new MachineController();
        Machine machine;
        ClusterController clusterController = new ClusterController();
        Cluster cluster;
        DatacenterController datacenterController = new DatacenterController();
        Datacenter datacenter;

        public EditDelete(Machine machine, Cluster cluster, Datacenter datacenter)
        {
            InitializeComponent();

            this.machine = machine;
            this.cluster = cluster;
            this.datacenter = datacenter;

            ServerNameEdit.Text = machine.Name;
            IpAddressEdit.Text = machine.Ip;
            OperatingSystemEdit.Text = machine.OperatingSystem;
            ManufacturerEdit.Text = machine.Manufacturer;
            CityEdit.Text = datacenter.Location;
            DatacenterEdit.Text = datacenter.Name;
            ClusterEdit.Text = cluster.Name;
            

        }

        private void Editar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
