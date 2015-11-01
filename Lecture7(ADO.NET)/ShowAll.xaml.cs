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

            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Users";

            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            dtAllUsers.AutoGenerateColumns = true;
            dtAllUsers.ItemsSource = dt.DefaultView;
        }
    }
}
