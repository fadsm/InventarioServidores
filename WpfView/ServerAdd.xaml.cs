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
using Model;
using Controllers;


namespace WpfView
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ServerAdd : Window
    {
        public ServerAdd()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MachineController machineController = new MachineController();

                ClusterController clusterController = new ClusterController();

                DatacenterController datacenterController = new DatacenterController();

                if (string.IsNullOrEmpty(ServerName.Text))
                {
                    throw new NullReferenceException("O campo nome do servidor está vazio");
                }

                if (string.IsNullOrEmpty(IpAddress1.Text))
                {
                    throw new NullReferenceException("O campo nome do servidor está vazio");
                }

                Datacenter datacenter = new Datacenter();

                datacenter.Name = Datacenter.Text;
                datacenter.Location = City.Text;

                datacenterController.Add(datacenter);

                Cluster cluster = new Cluster();

                cluster.Name = Cluster.Text;

                cluster.DatacenterIDFK = datacenter.DatacenterID;

                clusterController.Add(cluster);

                Machine machine = new Machine();

                machine.Name = ServerName.Text;
                machine.Ip = IpAddress1.Text;
                machine.OperatingSystem = OperatingSystem.Text;
                machine.Manufacturer = Manufacturer.Text;

                machine.ClusterIDFK = cluster.ClusterID;

                machineController.Add(machine);

                MessageBox.Show("Máquina criada com sucesso!");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao salvar" + ex.Message);
            }
        }
    }
}
