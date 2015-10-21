using Windows.UI.Xaml.Controls;
using bid4IT.Connections.Databases;

namespace bid4IT.Views {
    public sealed partial class LoginPage {
        public LoginPage() {
            InitializeComponent();

            using (var db = new DatabaseProvider()) {
                
            }
        }
    }
}
