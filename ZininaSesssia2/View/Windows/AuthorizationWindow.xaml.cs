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
using ZininaSesssia2.AppData;
using ZininaSesssia2.Model;

namespace ZininaSesssia2.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        private static ZininaSessia2Entities _context = App.GetContext();
        public AuthorizationWindow()
        {
            List<string> roles = new List<string> { "Сотрудник методического отдела", "Сисадмин" };
            InitializeComponent();
            RoleCmb.ItemsSource = roles;
        }

        private void EntryBtn_Click_1(object sender, RoutedEventArgs e)
        {
            if (AuthoriseHelper.Authorise(LoginTb.Text, PassTb.Password))
            {
                CAPTCHAWindow cAPTCHAWindow = new CAPTCHAWindow();
                if (cAPTCHAWindow.ShowDialog() == true)
                {
                    if (RoleCmb.SelectedIndex == 0)
                    {
                        UserrWindow userrWindow = new UserrWindow(AuthoriseHelper.selectedUser);
                        userrWindow.Show();
                        Close();
                    }
                }
            }
        }

        private void SignUpHl_Click_1(object sender, RoutedEventArgs e)
        {
            SignUpWindow signUpWindow = new SignUpWindow();
            signUpWindow.Show();
            Close();
        }

        private void EnterHl_Click(object sender, RoutedEventArgs e)
        {
            // ---.
        }
    }
}