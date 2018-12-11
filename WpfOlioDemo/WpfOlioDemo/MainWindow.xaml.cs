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
         
        }
    }
}
