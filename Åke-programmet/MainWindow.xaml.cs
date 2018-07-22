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
        Library.Database test = new Library.Database();

        public MainWindow()
        {
            InitializeComponent();
            test.PrintDept();
        }

        private void Set_values(string id)
        {
            if (test.Get_info(id) != null)
            {
                Library.Data Sample = test.Get_info(id);

                PRODUKTNAMN.Text = Sample.PRODUKTNAMN;
                PRODUKTNUMMER.Text = Sample.PRODNUM;
                KULÖR.Text = Sample.KULÖR;
                SAPNUM.Text = Sample.SAPNUM;
                SAPSATNUMMER.Text = Sample.SAPSATNUM;
                J1_a.Text = "1";
                J1_b.Text = "1";
                J2_a.Text = "1";
                J2_b.Text = "1";
                J3_a.Text = "1";
                J3_b.Text = "1";
                J4_a.Text = "1";
                J4_b.Text = "1";
                N1_a.Text = "1";
                N1_b.Text = "1";
                N2_a.Text = "1";
                N2_b.Text = "1";
                N3_a.Text = "1";
                N3_b.Text = "1";
                N4_a.Text = "1";
                N4_b.Text = "1";
                DENSITET.Text = "1";
                UTG_DENS.Text = "1";
                CoP_DIN.Text = "1";
                UT_CoP.Text = "1";
                RIVN.Text = "1";
                GL85.Text = "1";
                UGL85.Text = "1";
                PH.Text = "1";
                UT_PH.Text = "1";

            }
        }

        private void Listsource()
        {
            Listview.ItemsSource = test.DBlist;
        }

        private void Listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Set_values(sender.ToString());
        }

        private void SATSNUM_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
            {
                return;
            }
            else
            {
                Set_values(SATSNUM.Text);
            }
        }
    }
}
