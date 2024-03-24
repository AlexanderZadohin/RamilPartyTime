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
using System.Windows.Shapes;

namespace RamilPartyTime.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void EmailTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PhoneNumTb.Text == "")
            {
                PhoneNumTb.Text = "Твой номер";
            }
        }

        private void EmailTb_GotFocus(object sender, RoutedEventArgs e)
        {
            PhoneNumTb.Text = string.Empty;
        }

        private void NameTb_GotFocus(object sender, RoutedEventArgs e)
        {
            NameTb.Text = string.Empty;
        }

        private void NameTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NameTb.Text == string.Empty)
            {
                NameTb.Text = "Твоё имя";
            }
        }

        private void CityTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (CityTb.Text == string.Empty)
            {
                CityTb.Text = "Город";
            }
        }

        private void CityTb_GotFocus(object sender, RoutedEventArgs e)
        {
            CityTb.Text = string.Empty;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            MainScreenWindowApp mainScreenWindow = new MainScreenWindowApp();
            mainScreenWindow.Show();

            Window mainWindow = Window.GetWindow(this);
            mainWindow.Close();
        }
    }
}
