using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lecture7.Data;
using Lecture7.Models;

namespace Lecture7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtEmail.Text = txtPassword.Password = txtConfirmPassword.Password = string.Empty;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            SignupViewModel vm = (SignupViewModel)this.DataContext;

            if (vm.Password == vm.ConfirmPassword)
            {
                SqlParameter[] paramsList = new SqlParameter[2];
                SqlParameter emailParam = new SqlParameter("email", System.Data.SqlDbType.VarChar, 50);
                emailParam.Value = vm.Email;
                paramsList[0] = emailParam;

                SqlParameter passParam = new SqlParameter("password", System.Data.SqlDbType.VarChar, 50);
                passParam.Value = vm.Password;
                paramsList[1] = passParam;

                int rowsEffected = DatabaseHelper.ExecuteNonQuery("INSERT INTO Users VALUES(@email, @password)", paramsList);
            }
            else
            {
                txtPassword.Focus();
            }
        }

        private void btnShowAll_Click(object sender, RoutedEventArgs e)
        {
            ShowAll window = new ShowAll();
            window.Show();

            this.Close();
        }
    }
}
