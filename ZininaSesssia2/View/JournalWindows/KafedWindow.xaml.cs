﻿using System;
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
using ZininaSesssia2.View.Windows;

namespace ZininaSesssia2.View.JournalWindows
{
    /// <summary>
    /// Логика взаимодействия для KafedWindow.xaml
    /// </summary>
    public partial class KafedWindow : Window
    {
        public KafedWindow()
        {
            InitializeComponent();
        }

        private void NazadBtn_Click(object sender, RoutedEventArgs e)
        {
            JournalWindow journalWindow = new JournalWindow();
            journalWindow.Show();
            Close();
        }
    }
}
