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
    /// Interaction logic for ClusterManage.xaml
    /// </summary>
    public partial class ClusterManage : Window
    {
        
        public ClusterManage()
        {
            InitializeComponent();
        }

        private void ClusterList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cluster cluster = new Cluster();
            int id = (ClusterList.SelectedItem as Cluster).ClusterID;


        }

        private void ClusterList_Loaded(object sender, RoutedEventArgs e)
        {
            ClusterController clusterController = new ClusterController();

            ClusterList.ItemsSource = clusterController.ListAll();
        }

    }
}
