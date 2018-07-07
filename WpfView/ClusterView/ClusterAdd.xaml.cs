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
    /// Interaction logic for ClusterAdd.xaml
    /// </summary>
    public partial class ClusterAdd : Window
    {
        public ClusterAdd()
        {
            InitializeComponent();

            ClusterController clusterController = new ClusterController();

            ComboBoxDatacenter.ItemsSource = clusterController.ListAll();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cluster cluster = new Cluster();
            ClusterController clusterController = new ClusterController();

            cluster.Name = ClusterName.Text;
            cluster.Manufacturer = ClusterManufacturer.Text;



            clusterController.Add(cluster);

        }
    }
}
