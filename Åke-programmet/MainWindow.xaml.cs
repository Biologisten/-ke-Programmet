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

        private void CreateDynamicGridView()
        {
            // Lägga i bibliotek istället?
            GridView grid = new GridView();
            grid.AllowsColumnReorder = true;

            GridViewColumn Åkenum = new GridViewColumn();
            Åkenum.DisplayMemberBinding = new Binding("SATSNUM");
            Åkenum.Header = "Åke #";
            Åkenum.Width = 61;
            grid.Columns.Add(Åkenum);

            GridViewColumn Ver = new GridViewColumn();
            Ver.DisplayMemberBinding = new Binding("");
            Ver.Header = "SAP Order #";
            Ver.Width = 61;
            grid.Columns.Add(Ver);

            GridViewColumn Status = new GridViewColumn();
            Status.DisplayMemberBinding = new Binding("");
            Status.Header = "SAP Order #";
            Status.Width = 62;
            grid.Columns.Add(Status);

            Listview.View = grid;
            Listview.ItemsSource = database;
        }
    }
}
