using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Devart.Data.MySql;
using System.Windows;
using System.Configuration;

namespace Åke_programmet.Library
{
    public class Database
    {
        public List<Data> DBlist = new List<Data>();
        private readonly List<int> DBids = new List<int>();

        private readonly MySqlConnection Connection = new MySqlConnection() //Sets connection settings
        {
            Host = "localhost",
            Port = 3306,
            UserId = "",
            Password = "",
            Database = "åkedb"
        };

        public List<int> DBid() //Checks for RecipeID and returns it.
        {
            int i = DBlist.Count - 1;
            foreach (Data item in DBlist)
            {
                int.TryParse(DBlist[i].SATSNUM, out int ID);
                DBids.Add(ID);
                i--;
                if (i <= -1)
                {
                    break;
                }
            }
            return DBids;
        }

        public void PrintDept() //Prints all values from db in test window
        {
            var appSettings = ConfigurationManager.AppSettings;
            Connection.UserId = appSettings["userID"].ToString();
            Connection.Password = appSettings["pass"].ToString();
            MySqlCommand command = Connection.CreateCommand();
            command.CommandText = "SELECT * FROM åkedb";
            Connection.Open();
            MySqlDataReader myReader = command.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    string satnum = myReader.GetString(0);
                    string produktnamn = myReader.GetString(1);
                    string prodnum = myReader.GetString(2);
                    string kulör = myReader.GetString(3);
                    string sapnum = myReader.GetString(4);
                    string sapsatnum = myReader.GetString(5);
                    string justering1_a = myReader.GetString(6);
                    string justering1_b = myReader.GetString(7);
                    string justering2_a = myReader.GetString(8);
                    string justering2_b = myReader.GetString(9);
                    string justering3_a = myReader.GetString(10);
                    string justering3_b = myReader.GetString(11);
                    string justering4_a = myReader.GetString(12);
                    string justering4_b = myReader.GetString(13);
                    string nyansering1_a = myReader.GetString(14);
                    string nyansering1_b = myReader.GetString(15);
                    string nyansering2_a = myReader.GetString(16);
                    string nyansering2_b = myReader.GetString(17);
                    string nyansering3_a = myReader.GetString(18);
                    string nyansering3_b = myReader.GetString(19);
                    string nyansering4_a = myReader.GetString(20);
                    string nyansering4_b = myReader.GetString(21);
                    string densitet = myReader.GetString(22);
                    string utgdensitet = myReader.GetString(23);
                    string copdin = myReader.GetString(24);
                    string utcop = myReader.GetString(25);
                    string rivn = myReader.GetString(26);
                    string gl85 = myReader.GetString(27);
                    string ugl85 = myReader.GetString(28);
                    string ph = myReader.GetString(29);
                    string utph = myReader.GetString(30);
                    string rot = myReader.GetString(31);
                    string utgrot = myReader.GetString(32);
                    string gl60 = myReader.GetString(33);
                    string utggl60 = myReader.GetString(34);
                    string de = myReader.GetString(35);
                    string dl = myReader.GetString(36);
                    string da = myReader.GetString(37);
                    string db = myReader.GetString(38);
                    string fst = myReader.GetString(39);
                    string ufst = myReader.GetString(40);
                    string bort = myReader.GetString(41);
                    string utskrdat = myReader.GetString(42);
                    string startdat = myReader.GetString(43);
                    string godkdat = myReader.GetString(44);
                    string tappdat = myReader.GetString(45);
                    string recvikt = myReader.GetString(46);
                    string satsvikt = myReader.GetString(47);
                    string satsvol = myReader.GetString(48);
                    string tappvikt = myReader.GetString(49);
                    string tappvol = myReader.GetString(50);
                    string utbyte = myReader.GetString(51);
                    string tank = myReader.GetString(52);
                    string cm = myReader.GetString(53);
                    string upmvol = myReader.GetString(54);
                    string status = myReader.GetString(55);
                    string ver = myReader.GetString(56);
                    string just = myReader.GetString(57);
                    string nyans = myReader.GetString(58);
                    string tillvtid = myReader.GetString(59);
                    string kontrtid = myReader.GetString(60);
                    string anmärkning = myReader.GetString(61);
                    string kod_bok = myReader.GetString(62);

                    Data Artikel = new Data(satnum, produktnamn, prodnum, kulör, sapnum, sapsatnum, justering1_a, justering1_b, justering2_a, justering2_b, justering3_a, justering3_b, justering4_a, justering4_b, nyansering1_a, nyansering1_b, nyansering2_a, nyansering2_b, nyansering3_a, nyansering3_b, nyansering4_a, nyansering4_b, densitet, utgdensitet, copdin, utcop, rivn, gl85, ugl85, ph, utph, rot, utgrot, gl60, utggl60, de, dl, da, db, fst, ufst, bort, utskrdat, startdat, godkdat, tappdat, recvikt, satsvikt, satsvol, tappvikt, tappvol, utbyte, tank, cm, upmvol, status, ver, just, nyans, tillvtid, kontrtid, anmärkning, kod_bok);
                    DBlist.Add(Artikel);
                    test debug_test = new test();
                    foreach (Data item in DBlist)
                    {
                        int i = 0;
                        
                        while (i <= 62)
                        {
                            debug_test.get_str(myReader.GetString(i));
                            i++;
                        }
                    }
                    debug_test.get_str(Artikel.SATSNUM.ToString());
                    debug_test.ShowDialog();
                }
            }
            finally
            {
                // always call Close when done reading.
                myReader.Close();
                // always call Close when done reading.
                Connection.Close();
            }
        }

        public Data Get_info(string id) //Gets info on a recipe
        {
            int index = Exists(id);
            if (index >= 0)
            {
                return DBlist[index];
            }
            else
            {
                return null;
            }
        }

        private int Exists(string id) //check if recipe exists
        {
            int index = 0;
            foreach (Data Artikel in DBlist)
            {
                if (id == Artikel.SATSNUM)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
    }
}
