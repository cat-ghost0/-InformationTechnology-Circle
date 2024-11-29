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

namespace __InformationTechnology__Circle.Authorization
{
    /// <summary>
    /// Логика взаимодействия для AuthorizatonWindow.xaml
    /// </summary>
    public partial class AuthorizatonWindow : Window
    {
        private string _login;
        private string _password;
        public AuthorizatonWindow()
        {
            InitializeComponent();
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_login) && (string.IsNullOrEmpty(_password)))
            {
                _login = TxbLogin.Text;
                _password = TxbPassword.Password;
            }
            else
            {
                MessageBox.Show("Ошибка", $"Поля логин или пароль не могут быть пустыми", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            var user = Connecting.conn.User.FirstOrDefault(x => x.Login == _login && x.Password == _password);
            switch (user.RoleId)
            {
                case 3:
                    Navigating.nav.Navigate(new AdminMainPage());
                    break;
                case 2:
                    Navigating.nav.Navigate(new UserMainPage());
                    break;

                default:
                    MessageBox.Show("Извините, ваша раоль не определена", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
            }
            MessageBox.Show($"Здравствуйте {user.Surname} {user.Name} {user.Patronomic}, вы вошли как {user.Role.Name}", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

        }


    }
}
