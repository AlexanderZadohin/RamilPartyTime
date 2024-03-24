using RamilPartyTime.Class;
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
    /// Логика взаимодействия для HiFriendScreen.xaml
    /// </summary>
    public partial class HiFriendScreen : Page
    {
        public HiFriendScreen()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new View.Pages.EnterPage());
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new View.Pages.RegistrationPage());
        }
    }
}
