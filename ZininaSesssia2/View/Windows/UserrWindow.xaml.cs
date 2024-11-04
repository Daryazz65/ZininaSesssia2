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
using ZininaSesssia2.Model;

namespace ZininaSesssia2.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для UserrWindow.xaml
    /// </summary>
    public partial class UserrWindow : Window
    {
        private static ZininaSessia2Entities _context = App.GetContext();
        private User _selectedUser;
        public UserrWindow(Model.User selectedUser)
        {
            InitializeComponent();
            _selectedUser = selectedUser;
        }

        private void OneHl_Click(object sender, RoutedEventArgs e)
        {
            JournalWindow journalWindow = new JournalWindow();
            journalWindow.Show();
            Close();
        }

        private void TwoHl_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow(_selectedUser);
            profileWindow.Show();
            Close();
        }
    }
}