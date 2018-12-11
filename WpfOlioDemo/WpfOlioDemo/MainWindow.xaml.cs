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

namespace WpfOlioDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataGrid();
        }

        private void DataGrid()
        {
            DataGridTextColumn textColumn1 = new DataGridTextColumn();
            textColumn1.Binding = new Binding("CustomerNum");
            DataGridTextColumn textColumn2 = new DataGridTextColumn();
            textColumn2.Binding = new Binding("FirstName");
            DataGridTextColumn textColumn3 = new DataGridTextColumn();
            textColumn3.Binding = new Binding("LastName");
            DataGridTextColumn textColumn4 = new DataGridTextColumn();
            textColumn4.Binding = new Binding("Address");
            DataGridTextColumn textColumn5 = new DataGridTextColumn();
            textColumn5.Binding = new Binding("Phone");

            textColumn1.Header = "Asiakasnumero";
            dgCustomer.Columns.Add(textColumn1);
            textColumn2.Header = "Etunimi";
            dgCustomer.Columns.Add(textColumn2);
            textColumn3.Header = "Sukunimi";
            dgCustomer.Columns.Add(textColumn3);
            textColumn4.Header = "Osoite";
            dgCustomer.Columns.Add(textColumn4);
            textColumn5.Header = "Puhelin";
            dgCustomer.Columns.Add(textColumn5);
        }

        List<Customer> customers = new List<Customer>();
        private void BtnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerNum = int.Parse(txtBoxCstmrNu.Text);
            customer.FirstName = txtBoxFName.Text;
            customer.LastName = txtBoxLName.Text;
            customer.Address = txtBoxAddress.Text;
            customer.Phone = txtBoxPhone.Text;
        
            customers.Add(customer);

            foreach (Customer oneCustomer in customers)
            {
                dgCustomer.Items.Add(oneCustomer);
            }
            customers.Clear();
        }
    }
}
