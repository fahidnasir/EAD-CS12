﻿using System;
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
        }
    }
}