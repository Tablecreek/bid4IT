using Windows.UI.Xaml.Controls;


namespace bid4IT.Views {
    public sealed partial class LoginPage {
        public LoginPage() {
            InitializeComponent();
            
        }

        private void LoginButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (BusinessLayer.LoginDataService.Login(UsernameTextBox.Text, PasswordBox.Password))
            {
                Frame.Navigate(typeof(ApplicantsPage));
            }
            else
            {
                ShowLoginError(true);
            }
        }

        private void ShowLoginError(bool error)
        {
            if (error)
            {
                LoginErrorTextBox.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            else
            {
                LoginErrorTextBox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
             

        }

        private void UsernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ShowLoginError(false);
        }

        private void PasswordBox_PasswordChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ShowLoginError(false);
        }
    }
}
