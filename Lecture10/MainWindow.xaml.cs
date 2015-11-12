using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Data.SqlClient;
using System.Data;

namespace Lecture10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlDataAdapter da;
        private DataSet ds;
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            SqlConnection con = new SqlConnection(connStr);

            string qry = "SELECT * FROM Users";
            da = new SqlDataAdapter(qry, con);
            
            da.InsertCommand = new SqlCommand("INSERT INTO Users(Email, FirstName, LastName, IsHuman) Values(@Email, @FirstName, @LastName, @IsHuman);", con);
            da.InsertCommand.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Email", DataRowVersion.Current, null));
            da.InsertCommand.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", DataRowVersion.Current, null));
            da.InsertCommand.Parameters.Add(new SqlParameter("@LastName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", DataRowVersion.Current, null));
            da.InsertCommand.Parameters.Add(new SqlParameter("@IsHuman", SqlDbType.Bit, 1, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IsHuman", DataRowVersion.Current, null));

            ds = new DataSet();
            //Fill the DataSet
            da.Fill(ds, "Users");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Update a row in DataSet Table
            DataTable dt = ds.Tables["Users"];
            DataRow row = dt.NewRow();
            row["Email"] = txtEmail.Text;
            row["FirstName"] = txtFirstName.Text;
            row["LastName"] = txtLastName.Text;
            row["IsHuman"] = cbIsHuman.IsChecked;
            
            dt.Rows.Add(row);

            da.Update(ds, "Users");
            ds.AcceptChanges();
        }
    }
}
