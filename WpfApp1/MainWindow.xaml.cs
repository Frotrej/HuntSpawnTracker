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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Infrastructure;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly HuntContext _dbContext;

        public MainWindow(HuntContext dbContext)
        {
            _dbContext = dbContext;
            InitializeComponent();
            GetMaps();
        }
        private void GetMaps()
        {
            var maps = _dbContext.Maps.ToList();
        }
    }
}
