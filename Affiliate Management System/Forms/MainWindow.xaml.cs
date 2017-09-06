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
using AMSEF;
using Affiliate_Management_System.Forms;

namespace Affiliate_Management_System
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

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            UserTable obj = new UserTable();
            obj.Address = txtAddress.Text.Trim();
            obj.Email = txtEmail.Text.Trim();
            obj.Name = txtName.Text.Trim();
            obj.Referral_ID = int.Parse(txtReferralID.Text.Trim());
            obj.Comm_Level = int.Parse(txtComm.Text.Trim());
            obj.Phone = txtPhone.Text.Trim();
            AMSDAFactory Fobj = new AMSDAFactory();
            if(Fobj.insert(obj))
            {
                MessageBox.Show("Record Added Successfully ", "Data Saved");
            }
            else
                MessageBox.Show("Data Is not Added", "Error");
            txtReferralID.Text = "Enter Data ";

        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SearchForm Sobj = new SearchForm();
            Sobj.ShowDialog();

        }
    }
}
