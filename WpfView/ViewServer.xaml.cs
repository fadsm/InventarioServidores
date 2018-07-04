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

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EditDelete edidel = new EditDelete();
            edidel.ShowDialog();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)

        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            MachineController machineContoller = new MachineController();

            ServerList.ItemsSource = machineContoller.ListAll();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            MachineController machineContoller = new MachineController();

            ServerList.ItemsSource = machineContoller.ListByName(SearchBox.Text);
        }
    }
}
