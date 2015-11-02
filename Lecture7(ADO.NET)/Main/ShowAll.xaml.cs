using System;
using System.Collections.Generic;
using System.Configuration;
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
using Lecture7.Data;

namespace Lecture7
{
    /// <summary>
    /// Interaction logic for ShowAll.xaml
    /// </summary>
    public partial class ShowAll : Window
    {
        public ShowAll()
        {
            InitializeComponent();
            this.Loaded += ShowAll_Loaded;
        }

        void ShowAll_Loaded(object sender, RoutedEventArgs e)
        {
            DataTable dt = DatabaseHelper.ExecuteReader("SELECT * FROM Users", null);

            dtAllUsers.AutoGenerateColumns = true;
            dtAllUsers.ItemsSource = dt.DefaultView;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                //Sql Injection Testing Query parameter   ' OR 1=1;--

                SqlCommand command = con.CreateCommand();
                command.CommandText = "SELECT * FROM Users Where Email = '" + txtEmail.Text + "'";
                SqlDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dtAllUsers.AutoGenerateColumns = true;
                dtAllUsers.ItemsSource = dt.DefaultView;
            }
        }
    }
}
