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
                string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand command = con.CreateCommand();
                command.CommandText = "INSERT INTO Users VALUES(@email, @password)";

                SqlParameter emailParam = new SqlParameter("email", System.Data.SqlDbType.VarChar, 50);
                emailParam.Value = vm.Email;
                command.Parameters.Add(emailParam);

                SqlParameter passParam = new SqlParameter("password", System.Data.SqlDbType.VarChar, 50);
                passParam.Value = vm.Password;
                command.Parameters.Add(passParam);
                
                int rowsEffected = command.ExecuteNonQuery();
            }
            else
            {
                txtPassword.Focus();
            }
        }
    }
}
