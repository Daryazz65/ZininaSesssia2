using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ZininaSesssia2.Model;

namespace ZininaSesssia2
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static ZininaSessia2Entities _context;
        public static ZininaSessia2Entities GetContext()
        {
            if (_context == null)
            {
                _context = new ZininaSessia2Entities();
            }
            return _context;
        }
    }
}