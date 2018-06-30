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
                /*
                if (string.IsNullOrEmpty(ServerName.Text))
                {
                    throw new NullReferenceException("O campo nome do servidor está vazio");
                }
                if (string.IsNullOrEmpty(IpAddress1.Text))
                {
                    throw new NullReferenceException("O campo endereço de IP está vazio");
                }
                if (string.IsNullOrEmpty(OperatingSystem.Text))
                {
                    throw new NullReferenceException("O campo sistema operacional está vazio");
                }
                if (string.IsNullOrEmpty(City.SelectedValue.ToString()))
                {
                    throw new NullReferenceException("O campo cidade está vazio");
                }
                if (string.IsNullOrEmpty(Datacenter.SelectedValue.ToString()))
                {
                    throw new NullReferenceException("O campo datacenter está vazio");
                }
                if (string.IsNullOrEmpty(Cluster.SelectedValue.ToString()))
                {
                    throw new NullReferenceException("O campo cluster está vazio");
                }
                */
                Machine machine = new Machine();

                machine.Name = ServerName.Text;
                machine.Ip = IpAddress1.Text;
                machine.OperatingSystem = OperatingSystem.Text;
                machine.Manufacturer = Manufacturer.Text;
                //machine._Cluster._Datacenter.Location = City.SelectedValue.ToString();
                //machine._Cluster._Datacenter.Name = Datacenter.SelectedValue.ToString();
                //machine._Cluster.Name = Cluster.SelectedValue.ToString();

                machineController.Add(machine);

                MessageBox.Show("Máquina criada com sucesso!");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao salvar" + ex.Message);
            }
        }

        private void City_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (City.SelectedValue.ToString().Equals("Curitiba"))
            {
                List<String> str = new List<string>();
                str.Add("Xaxim");
                str.Add("Kennedy");
                Datacenter.ItemsSource = str;
            }
            else //if (City.SelectedValue.ToString().Equals("São Paulo"))
            {
                List<String> str = new List<string>();
                str.Add("Cidade de Deus");
                str.Add("Alphaville");
                Datacenter.ItemsSource = str;
            }
           

            
        }
    }
}
