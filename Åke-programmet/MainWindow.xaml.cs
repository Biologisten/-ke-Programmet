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

namespace Åke_programmet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Library.Databas test = new Library.Databas();

        public MainWindow()
        {
            InitializeComponent();
            test.PrintDept();
        }

        List<Library.Databas> database = new List<Library.Databas>();

        private void Set_values()
        {
            
        }
    }
}
