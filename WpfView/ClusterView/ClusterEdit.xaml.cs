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

namespace WpfView.ClusterView
{
    /// <summary>
    /// Interaction logic for ClusterEdit.xaml
    /// </summary>
    public partial class ClusterEdit : Window
    {

        private int? _clusterid;

        public ClusterEdit(int id)
        {
            _clusterid = id;
            InitializeComponent();

            Cluster cluster = new Cluster();
            ClusterController clusterController = new ClusterController();

            cluster = clusterController.SearchForId(id);

            ClusterName.Text = cluster.Name;
            ClusterManufacturer.Text = cluster.Manufacturer;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Cluster cluster = new Cluster();
            ClusterController clusterController = new ClusterController();

            cluster.Name = ClusterName.Text;
            cluster.Manufacturer = ClusterManufacturer.Text;

            clusterController.Edit(cluster);
            

            MessageBox.Show("Cluster editado com sucesso!");
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            ClusterController clusterController = new ClusterController();
            if (_clusterid.HasValue )
            {
                clusterController.Delete(_clusterid.Value);
            }
            else
            {
                MessageBox.Show("O valor do ID do cluster está inválido para deletar.");
            }
            
        }
    }
}
