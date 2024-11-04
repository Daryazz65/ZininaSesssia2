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
using ZininaSesssia2.View.JournalWindows;

namespace ZininaSesssia2.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для JournalWindow.xaml
    /// </summary>
    public partial class JournalWindow : Window
    {
        public JournalWindow()
        {
            InitializeComponent();
        }

        private void OneHl_Click(object sender, RoutedEventArgs e)
        {
            SpecWindow specWindow = new SpecWindow();
            specWindow.Show();
            Close();
        }

        private void TwoHl_Click(object sender, RoutedEventArgs e)
        {
            KafedWindow kafedWindow = new KafedWindow();
            kafedWindow.Show();
            Close();
        }

        private void ThreeHl_Click(object sender, RoutedEventArgs e)
        {
            DiscipWindow discipWindow = new DiscipWindow();
            discipWindow.Show();
            Close();
        }
    }
}