using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using ZininaSesssia2.View.Windows;

namespace ZininaSesssia2.View.JournalWindows
{
    /// <summary>
    /// Логика взаимодействия для DiscipWindow.xaml
    /// </summary>
    public partial class DiscipWindow : Window
    {
        private static ZininaSessia2Entities _context = App.GetContext();
        public DiscipWindow()
        {
            InitializeComponent();

            //listviewDis.ItemsSource = App._context.Departments.ToList();
            //CountOfPagesTbl.DataContext = App._context.book.ToList();
            //BookDetailsGrid.DataContext = App._context.book.ToList();




            //DiscipGr.DataContext = selectedDiscip;
            //App.context.Discipline.Where(ba => ba.Id == selectedDiscip.Id).ToList();

        }
    //static DataTable ExecuteSql(string sql)
    //{
    //    DataTable dt = new DataTable();
    //    SqlConnection conn = new SqlConnection(
    //        "Data Source=.\\SQLEXPRESS;Integrated Security=True;Initial Catalog=base"
    //        );

    //    using (conn)
    //    {
    //        conn.Open();

    //        SqlCommand cmd = new SqlCommand(sql, conn);
    //        SqlDataReader read = cmd.ExecuteReader();

    //        using (read)
    //        {
    //            dt.Load(read);
    //        }
    //    }

    //    return dt;
    //}

    private void Button_Click(object sender, RoutedEventArgs e)
        {
            //DataTable dt = ExecuteSql("SELECT * FROM Users");
            //listviewDis.ItemsSource = dt.DefaultView;
        }

        private void listviewDis_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void NazadBtn_Click(object sender, RoutedEventArgs e)
        {
            JournalWindow journalWindow = new JournalWindow();
            journalWindow.Show();
            Close();
        }
    }
}