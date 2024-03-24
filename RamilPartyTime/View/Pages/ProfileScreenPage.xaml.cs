using RamilPartyTime.Model;
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
    /// Логика взаимодействия для ProfileScreenPage.xaml
    /// </summary>
    public partial class ProfileScreenPage : Page
    {
        public ProfileScreenPage(UserApp user)
        {
            InitializeComponent();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(user.PhotoProfile);
            bitmap.EndInit();

            ProfileImg.Source = bitmap;
            NameTb.Text = user.FullName;
            NumberPhoneTb.Text = user.PhoneNum;
            CityTb.Text = user.City.NameCity;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainScreenWindow = new MainWindow();
            mainScreenWindow.Show();

            Window mainWindow = Window.GetWindow(this);
            mainWindow.Close();
        }

        private void NumberPhoneTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NumberPhoneTb.Text == "")
            {
                NumberPhoneTb.Text = "Номер";
            }
        }

        private void NumberPhoneTb_GotFocus(object sender, RoutedEventArgs e)
        {
            NumberPhoneTb.Text = string.Empty;
        }

        private void NameTb_GotFocus(object sender, RoutedEventArgs e)
        {
            NameTb.Text = string.Empty;
        }

        private void NameTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NameTb.Text == string.Empty)
            {
                NameTb.Text = "Имя";
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

    }
}
