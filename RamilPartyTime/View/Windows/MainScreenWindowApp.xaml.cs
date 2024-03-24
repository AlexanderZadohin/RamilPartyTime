using RamilPartyTime.Class;
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
using System.Windows.Shapes;

namespace RamilPartyTime.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainScreenWindowApp.xaml
    /// </summary>
    public partial class MainScreenWindowApp : Window
    {
        public UserApp currentUser;
        public MainScreenWindowApp()
        {
            InitializeComponent();


            ClassFrame.FrameBody = BodyFrmApp;

            BodyFrmApp.Navigate(new View.Pages.MainPageApp());
        }

        public MainScreenWindowApp(UserApp user)
        {
            InitializeComponent();

            currentUser = user;
            ClassFrame.FrameBody = BodyFrmApp;

            BodyFrmApp.Navigate(new View.Pages.MainPageApp());
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            BodyFrmApp.Navigate(new View.Pages.ProfileScreenPage(currentUser));

            HomeImg.Source = new BitmapImage(new Uri("/Resources/Images/Hoem.png", UriKind.Relative));
            MessageImg.Source = new BitmapImage(new Uri("/Resources/Images/Message.png", UriKind.Relative));
            ProfileImg.Source = new BitmapImage(new Uri("/Resources/Images/ActiveProfile.png", UriKind.Relative));
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            BodyFrmApp.Navigate(new View.Pages.MainPageApp());

            HomeImg.Source = new BitmapImage(new Uri("/Resources/Images/ActiveHome.png", UriKind.Relative));
            MessageImg.Source = new BitmapImage(new Uri("/Resources/Images/Message.png", UriKind.Relative));
            ProfileImg.Source = new BitmapImage(new Uri("/Resources/Images/Profile.png", UriKind.Relative));
        }

        private void ChatBtn_Click(object sender, RoutedEventArgs e)
        {
            BodyFrmApp.Navigate(new View.Pages.ChatPage());

            HomeImg.Source = new BitmapImage(new Uri("/Resources/Images/Hoem.png", UriKind.Relative));
            MessageImg.Source = new BitmapImage(new Uri("/Resources/Images/ActiveMessage.png", UriKind.Relative));
            ProfileImg.Source = new BitmapImage(new Uri("/Resources/Images/Profile.png", UriKind.Relative));
        }
    }
}
