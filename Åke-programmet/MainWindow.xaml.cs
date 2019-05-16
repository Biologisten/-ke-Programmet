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
            test.Refresh();
            Listsource();     //Sets source for RecipeList
        }

        private void Set_values(string id)  //Sets values from DB to boxes in UI
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

        private void Save_Recipe(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(SATSNUM.Text, out _) || SATSNUM.Text == "")
            {
                Library.Data recipe = new Library.Data(SATSNUM.Text, PRODUKTNAMN.Text, PRODUKTNUMMER.Text, KULÖR.Text, SAPNUM.Text, SAPSATNUMMER.Text, J1_a.Text, J1_b.Text, J2_a.Text, J2_b.Text, J3_a.Text, J3_b.Text, J4_a.Text, J4_b.Text, N1_a.Text, N1_b.Text, N2_a.Text, N2_b.Text, N3_a.Text, N3_b.Text, N4_a.Text, N4_b.Text, DENSITET.Text, UTG_DENS.Text, CoP_DIN.Text, UT_CoP.Text, RIVN.Text, GL85.Text, UGL85.Text, PH.Text, UT_PH.Text, ROT.Text, UTG_ROT.Text, GL60.Text, UGL60.Text, DE.Text, DL.Text, DA.Text, DB.Text, FST.Text, UFST.Text, BORT.Text, UTSKRDAT.Text, STARTDAT.Text, GODKDAT.Text, TAPPDAT.Text, REC_VIKT.Text, SATS_VIKT.Text, SATS_VOL.Text, TAPP_VIKT.Text, TAPP_VOL.Text, UTBYTE.Text, TANK.Text, CM.Text, UPM_VOL.Text, STATUS.Text, VER.Text, JUST.Text, NYANS.Text, TILLVTID.Text, KONTRTID.Text, ANMÄRKNING.Text, KOD_BOK.Text);
                test.DBlist.Add(recipe);
                test.Add_Recipe(PRODUKTNAMN.Text, PRODUKTNUMMER.Text, KULÖR.Text, SAPNUM.Text, SAPSATNUMMER.Text, J1_a.Text, J1_b.Text, J2_a.Text, J2_b.Text, J3_a.Text, J3_b.Text, J4_a.Text, J4_b.Text, N1_a.Text, N1_b.Text, N2_a.Text, N2_b.Text, N3_a.Text, N3_b.Text, N4_a.Text, N4_b.Text, DENSITET.Text, UTG_DENS.Text, CoP_DIN.Text, UT_CoP.Text, RIVN.Text, GL85.Text, UGL85.Text, PH.Text, UT_PH.Text, ROT.Text, UTG_ROT.Text, GL60.Text, UGL60.Text, DE.Text, DL.Text, DA.Text, DB.Text, FST.Text, UFST.Text, BORT.Text, UTSKRDAT.Text, STARTDAT.Text, GODKDAT.Text, TAPPDAT.Text, REC_VIKT.Text, SATS_VIKT.Text, SATS_VOL.Text, TAPP_VIKT.Text, TAPP_VOL.Text, UTBYTE.Text, TANK.Text, CM.Text, UPM_VOL.Text, STATUS.Text, VER.Text, JUST.Text, NYANS.Text, TILLVTID.Text, KONTRTID.Text, ANMÄRKNING.Text, KOD_BOK.Text);
                test.Refresh();
            }
            else
            {
                MessageBox.Show(this, "Satsnummert kan endast bestå av siffror!", "", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Search_recipe(object sender, RoutedEventArgs e)
        {
            if (test.Get_info(ID_Search.Text) != null)
            {
                Set_values(ID_Search.Text);
            }
            else
            {
                MessageBox.Show(this, "Satsnummert finns inte", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            SATSNUM.Text = "";
            PRODUKTNAMN.Text = "";
            PRODUKTNUMMER.Text = "";
            KULÖR.Text = "";
            SAPNUM.Text = "";
            SAPSATNUMMER.Text = "";
            J1_a.Text = "";
            J1_b.Text = "";
            J2_a.Text = "";
            J2_b.Text = "";
            J3_a.Text = "";
            J3_b.Text = "";
            J4_a.Text = "";
            J4_b.Text = "";
            N1_a.Text = "";
            N1_b.Text = "";
            N2_a.Text = "";
            N2_b.Text = "";
            N3_a.Text = "";
            N3_b.Text = "";
            N4_a.Text = "";
            N4_b.Text = "";
            DENSITET.Text = "";
            UTG_DENS.Text = "";
            CoP_DIN.Text = "";
            UT_CoP.Text = "";
            RIVN.Text = "";
            GL85.Text = "";
            UGL85.Text = "";
            PH.Text = "";
            UT_PH.Text = "";
            ROT.Text = "";
            UTG_ROT.Text = "";
            GL60.Text = "";
            UGL60.Text = "";
            DE.Text = "";
            DL.Text = "";
            DA.Text = "";
            DB.Text = "";
            FST.Text = "";
            UFST.Text = "";
            BORT.Text = "";
            UTSKRDAT.Text = "";
            STARTDAT.Text = "";
            GODKDAT.Text = "";
            TAPPDAT.Text = "";
            REC_VIKT.Text = "";
            SATS_VIKT.Text = "";
            SATS_VOL.Text = "";
            TAPP_VIKT.Text = "";
            TAPP_VOL.Text = "";
            UTBYTE.Text = "";
            TANK.Text = "";
            CM.Text = "";
            UPM_VOL.Text = "";
            STATUS.Text = "";
            VER.Text = "";
            JUST.Text = "";
            NYANS.Text = "";
            TILLVTID.Text = "";
            KONTRTID.Text = "";
            ANMÄRKNING.Text = "";
            KOD_BOK.Text = "";
        }

        private void Quit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
