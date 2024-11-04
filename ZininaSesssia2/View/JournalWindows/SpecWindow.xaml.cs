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

namespace ZininaSesssia2.View.JournalWindows
{
    /// <summary>
    /// Логика взаимодействия для SpecWindow.xaml
    /// </summary>
    public partial class SpecWindow : Window
    {
        User _selectedUser;
        string password = string.Empty;
        string newPassword = string.Empty;
        private static ZininaSessia2Entities _context = App.GetContext();
        public SpecWindow()
        {
            InitializeComponent();

        }

        private void ChangeNameCb_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeNameCb_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void IsVisibleCb_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void IsVisibleCb_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}