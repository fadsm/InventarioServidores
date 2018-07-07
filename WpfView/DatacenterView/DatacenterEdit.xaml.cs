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
    /// Interaction logic for DatacenterEdit.xaml
    /// </summary>
    public partial class DatacenterEdit : Window
    {
        private int? _datacenterid;
        public DatacenterEdit(int id)
        {
            _datacenterid = id;

            InitializeComponent();

            Datacenter datacenter = new Datacenter();
            DatacenterController datacenterController = new DatacenterController();

            datacenter = datacenterController.SearchForId(id);

            DatacenterName.Text = datacenter.Name;
            DatacenterLocation.Text = datacenter.Location;
        
            
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {

            Datacenter datacenter = new Datacenter();
            DatacenterController datacenterController = new DatacenterController();

            datacenter.Name = DatacenterName.Text;
            datacenter.Location = DatacenterLocation.Text;

            datacenterController.Edit(datacenter);
            

            MessageBox.Show("Datacenter editado com sucesso!");
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            DatacenterController datacenterController = new DatacenterController();
            if (_datacenterid.HasValue)
            {
                datacenterController.Delete(_datacenterid.Value);
            }
            else
            {
                MessageBox.Show("O valor do ID do datacenter está inválido para deletar.");
            }
        }
    }
}
