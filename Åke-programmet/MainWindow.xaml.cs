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
            Listsource();
        }

        private void Set_values(string id)
        {
            if (test.Get_info(id) != null)
            {
                Library.Data Values = test.Get_info(id);

                SATSNUM.Text = Values.SATSNUM;
                PRODUKTNAMN.Text = Values.PRODUKTNAMN;
                PRODUKTNUMMER.Text = Values.PRODNUM;
                KULÖR.Text = Values.KULÖR;
                SAPNUM.Text = Values.SAPNUM;
                SAPSATNUMMER.Text = Values.SAPSATNUM;
                J1_a.Text = Values.JUSTERING1_A;
                J1_b.Text = Values.JUSTERING1_B;
                J2_a.Text = Values.JUSTERING2_A;
                J2_b.Text = Values.JUSTERING2_B;
                J3_a.Text = Values.JUSTERING3_A;
                J3_b.Text = Values.JUSTERING3_B;
                J4_a.Text = Values.JUSTERING4_A;
                J4_b.Text = Values.JUSTERING4_B;
                N1_a.Text = Values.NYANSERING1_A;
                N1_b.Text = Values.NYANSERING1_B;
                N2_a.Text = Values.NYANSERING2_A;
                N2_b.Text = Values.NYANSERING2_B;
                N3_a.Text = Values.NYANSERING3_A;
                N3_b.Text = Values.NYANSERING3_B;
                N4_a.Text = Values.NYANSERING4_A;
                N4_b.Text = Values.NYANSERING4_B;
                DENSITET.Text = Values.DENSITET;
                UTG_DENS.Text = Values.UTGDENSITET;
                CoP_DIN.Text = Values.COPDIN;
                UT_CoP.Text = Values.UTCOP;
                RIVN.Text = Values.RIVN;
                GL85.Text = Values.GL85;
                UGL85.Text = Values.UGL85;
                PH.Text = Values.PH;
                UT_PH.Text = Values.UTPH;
                ROT.Text = Values.ROT;
                UTG_ROT.Text = Values.UTGROT;
                GL60.Text = Values.GL60;
                UGL60.Text = Values.UGL60;
                DE.Text = Values.DE;
                DL.Text = Values.DL;
                DA.Text = Values.DA;
                DB.Text = Values.DB;
                FST.Text = Values.FST;
                UFST.Text = Values.UFST;
                BORT.Text = Values.BORT;
                UTSKRDAT.Text = Values.UTSKRDAT;
                STARTDAT.Text = Values.STARTDAT;
                GODKDAT.Text = Values.GODKDAT;
                TAPPDAT.Text = Values.TAPPDAT;
                REC_VIKT.Text = Values.RECVIKT;
                SATS_VIKT.Text = Values.SATSVIKT;
                SATS_VOL.Text = Values.SATSVOL;
                TAPP_VIKT.Text = Values.TAPPVIKT;
                TAPP_VOL.Text = Values.TAPPVOL;
                UTBYTE.Text = Values.UTBYTE;
                TANK.Text = Values.TANK;
                CM.Text = Values.CM;
                UPM_VOL.Text = Values.UPMVOL;
                STATUS.Text = Values.STATUS;
                VER.Text = Values.VER;
                JUST.Text = Values.JUST;
                NYANS.Text = Values.NYANS;
                TILLVTID.Text = Values.TILLVTID;
                KONTRTID.Text = Values.KONTRTID;
                ANMÄRKNING.Text = Values.ANMÄRKNING;
                KOD_BOK.Text = Values.KOD_BOK;
            }
        }

        private void Listsource()
        {
            Listview.ItemsSource = test.DBid();
        }

        private void Listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Set_values(sender.ToString());
            Set_values(Listview.SelectedValue.ToString());
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
