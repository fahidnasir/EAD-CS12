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

namespace LinqExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<User> users;
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        //This function calls only when Screen is completed loaded but not showed to user.
        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            users = new List<User>();
            #region Populate Data
            users.Add(new User()
                {
                    ID = 1,
                    Name = "First",
                    Email = "first@b.com",
                    Address = "lahore",
                    Birthday = new DateTime(1990, 1, 1),
                    Age = 22
                });
            users.Add(new User()
            {
                ID = 2,
                Name = "Second",
                Email = "second@b.com",
                Address = "karachi",
                Birthday = new DateTime(1991, 1, 1),
                Age = 23
            });
            users.Add(new User()
            {
                ID = 3,
                Name = "Third",
                Email = "third@b.com",
                Address = "lahore",
                Birthday = new DateTime(1992, 1, 1),
                Age = 24
            });
            users.Add(new User()
            {
                ID = 4,
                Name = "Forth",
                Email = "forth@b.com",
                Address = "multan",
                Birthday = new DateTime(1993, 1, 1),
                Age = 23
            });
            users.Add(new User()
            {
                ID = 5,
                Name = "Fifth",
                Email = "fifth@b.com",
                Address = "karachi",
                Birthday = new DateTime(1990, 1, 1),
                Age = 25
            });

            #endregion
            dgUsers.ItemsSource = users;
        }

        private void txtFilter_KeyUp(object sender, KeyEventArgs e)
        {
            FilterValueWithLinq(txtFilter.Text, (string)cmbFilterType.SelectionBoxItem);
            //FilterValueWithLambda(txtFilter.Text, (string)cmbFilterType.SelectionBoxItem);

        }

        private void FilterValueWithLinq(string value, string filterType)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                dgUsers.ItemsSource = users;
                return;
            }
            switch (filterType)
            {
                case "ID":
                    int id;
                    Int32.TryParse(txtFilter.Text, out id);
                    dgUsers.ItemsSource = from s in users
                                          where s.ID == id
                                          select s;
                    break;
                case "Name":
                    dgUsers.ItemsSource = from s in users
                                          where s.Name.Contains(value)
                                          select s;
                    break;
                case "Email":
                    dgUsers.ItemsSource = from s in users
                                          where s.Email.Contains(value)
                                          select s;
                    break;
                case "Address":
                    dgUsers.ItemsSource = from s in users
                                          where s.Address.Equals(value)
                                          select s;
                    break;
                case "DOB":
                    DateTime dob;
                    if (DateTime.TryParse(value, out dob))
                        dgUsers.ItemsSource = from s in users
                                              where s.Birthday.Equals(dob)
                                              select s;
                    break;
                case "Age":
                    int age = Int32.Parse(txtFilter.Text);
                    dgUsers.ItemsSource = from s in users
                                          where s.Age == age
                                          select s;
                    break;
                default:
                    break;
            }
        }

        private void FilterValueWithLambda(string value, string filterType)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                dgUsers.ItemsSource = users;
                return;
            }
            switch (filterType)
            {
                case "ID":
                    int id;
                    Int32.TryParse(txtFilter.Text, out id);
                    dgUsers.ItemsSource = users.Where<User>(p => p.ID == id);
                    break;
                case "Name":
                    dgUsers.ItemsSource = users.Where<User>(p => p.Name.Contains(value));
                    break;
                case "Email":
                    dgUsers.ItemsSource = users.Where<User>(p => p.Email.Contains(value));
                    break;
                case "Address":
                    dgUsers.ItemsSource = users.Where<User>(p => p.Address.Equals(value));
                    break;
                case "DOB":
                    dgUsers.ItemsSource = users.Where<User>(p => p.Birthday.Equals(value));
                    break;
                case "Age":
                    int age = Int32.Parse(txtFilter.Text);
                    dgUsers.ItemsSource = users.Where<User>(p => p.ID == age);
                    break;
                default:
                    break;
            }
        }
    }
}
