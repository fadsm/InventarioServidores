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
    /// Interaction logic for ViewServer.xaml
    /// </summary>
    public partial class ViewServer : Window
    {

        public ViewServer()
        {
            InitializeComponent();
        }

    
        private void Window_Loaded(object sender, RoutedEventArgs e)

        {
            CarregarGrid();           
        }

        private void CarregarGrid()
        {
            MachineController machineController = new MachineController();

            IList<Machine> machines = machineController.ListAll();

            ServerList.ItemsSource = machines;

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            MachineController machineContoller = new MachineController();

            ServerList.ItemsSource = machineContoller.ListByName(SearchBox.Text);
        }

        private void ServerList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ClusterController clusterController = new ClusterController();
            DatacenterController datacenterController = new DatacenterController();

            Machine machine = (Machine)ServerList.SelectedItem;
            Cluster cluster = clusterController.SearchForId(machine.ClusterIDFK);
            Datacenter datacenter = datacenterController.SearchForId(cluster.DatacenterIDFK);

            EditDelete edit = new EditDelete(machine, cluster, datacenter);

            edit.ShowDialog();

            this.Close();
        }

        private void Deletar_Click(object sender, RoutedEventArgs e)
        {
            MachineController machineController = new MachineController();

            Machine machine = (Machine)ServerList.SelectedItem;

            machineController.Delete(machine.MachineID);

            MessageBox.Show("Máquina deletada com sucesso!");
        }
    }
}
