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
using WpfView.ClusterView;
using WpfView.DatacenterView;

namespace WpfView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddDatacenter_Click(object sender, RoutedEventArgs e)
        {
            DatacenterAdd datadd = new DatacenterAdd();

            datadd.ShowDialog();
        }

        private void AddCluster_Click(object sender, RoutedEventArgs e)
        {
            ClusterAdd cluadd = new ClusterAdd();

            cluadd.ShowDialog();
        }

        private void ManageDatacenter_Click(object sender, RoutedEventArgs e)
        {
            DatacenterManage mngdat = new DatacenterManage();

            mngdat.ShowDialog();
        }

        private void ManageCluster_Click(object sender, RoutedEventArgs e)
        {
            ClusterManage mngclu = new ClusterManage();

            mngclu.ShowDialog();
        }
    }
}
