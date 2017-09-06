using AMSEF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Affiliate_Management_System.Forms
{
    /// <summary>
    /// Interaction logic for SearchForm.xaml
    /// </summary>
    public partial class SearchForm : Window
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            int id = 0;
            try
            {
                id = int.Parse(txtReferral.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            AMSDAFactory fobj = new AMSDAFactory();
            dgShow.ItemsSource = fobj.search(id);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AMSDAFactory fobj = new AMSDAFactory();
            dgShow.ItemsSource = fobj.GetAll();
        }
    }
}
