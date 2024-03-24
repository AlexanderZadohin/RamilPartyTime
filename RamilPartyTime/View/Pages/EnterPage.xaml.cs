﻿using RamilPartyTime.Model;
using RamilPartyTime.View.Windows;
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

namespace RamilPartyTime.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для EnterPage.xaml
    /// </summary>
    public partial class EnterPage : Page
    {
        public EnterPage()
        {
            InitializeComponent();
        }

        private void EmailTb_GotFocus(object sender, RoutedEventArgs e)
        {
            EmailTb.Text = string.Empty;
        }

        private void EmailTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (EmailTb.Text == string.Empty)
            {
                EmailTb.Text = "Имя";
            }
        }

        private void PasswordPb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordPb.Password == string.Empty)
            {
                PasswordPb.Password = "Город";
            }
        }

        private void PasswordPb_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordPb.Password = string.Empty;
        }

        private void GoBtn_Click(object sender, RoutedEventArgs e)
        {
            UserApp userApp = App.context.UserApp.FirstOrDefault(u =>
                u.Password == PasswordPb.Password && u.Email == EmailTb.Text);
            if (userApp != null)
            {
                MainScreenWindowApp mainScreenWindow = new MainScreenWindowApp(userApp);
                mainScreenWindow.Show();

                Window mainWindow = Window.GetWindow(this);
                mainWindow.Close();
            }
            else
            {
                MessageBox.Show("Данные введены неверно");
            }
        }
    }
}
