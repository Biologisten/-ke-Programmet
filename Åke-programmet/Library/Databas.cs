using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Devart.Data.MySql;
using System.Windows;

namespace Åke_programmet.Library
{
    public class Databas
    {
        private List<Data> DBlist = new List<Data>();

        MySqlConnection Connection = new MySqlConnection()
        {
            Host = "localhost",
            Port = 3306,
            UserId = "root",
            Password = "",
            Database = "åkedb"
        };

        public List<Data> DBdump()
        {
            return DBlist;
        }

        public void PrintDept()
        {
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
                    string justering_a = myReader.GetString(6);
                    string justering_b = myReader.GetString(7);
                    string justering1_a = myReader.GetString(8);
                    string justering1_b = myReader.GetString(9);
                    string justering2_a = myReader.GetString(10);
                    string justering2_b = myReader.GetString(11);
                    string justering3_a = myReader.GetString(12);
                    string justering3_b = myReader.GetString(13);
                    string justering4_a = myReader.GetString(14);
                    string justering4_b = myReader.GetString(15);
                    string nyansering_a = myReader.GetString(16);
                    string nyansering_b = myReader.GetString(17);
                    string nyansering2_a = myReader.GetString(18);
                    string nyansering2_b = myReader.GetString(19);
                    string nyansering3_a = myReader.GetString(20);
                    string nyansering3_b = myReader.GetString(21);
                    string nyansering4_a = myReader.GetString(22);
                    string nyansering4_b = myReader.GetString(23);
                    string densitet = myReader.GetString(24);
                    string utgdensitet = myReader.GetString(25);
                    string copdin = myReader.GetString(26);
                    string utcop = myReader.GetString(27);
                    string rivn = myReader.GetString(28);
                    string gl85 = myReader.GetString(29);
                    string ugl85 = myReader.GetString(30);
                    string ph = myReader.GetString(31);
                    string utph = myReader.GetString(32);
                    string rot = myReader.GetString(33);
                    string utgrot = myReader.GetString(34);
                    string gl60 = myReader.GetString(35);
                    string utggl60 = myReader.GetString(36);
                    string de = myReader.GetString(37);
                    string dl = myReader.GetString(38);
                    string da = myReader.GetString(39);
                    string db = myReader.GetString(40);
                    string fst = myReader.GetString(41);
                    string ufst = myReader.GetString(42);

                    Data Artikel = new Data(satnum, produktnamn, prodnum, kulör, sapnum, sapsatnum, justering_a, justering_b, justering1_a, justering1_b, justering2_a, justering2_b, justering3_a, justering3_b, justering4_a, justering4_b, nyansering_a, nyansering_b, nyansering2_a, nyansering2_b, nyansering3_a, nyansering3_b, nyansering4_a, nyansering4_b, densitet, utgdensitet, copdin, utcop, rivn, gl85, ugl85, ph, utph, rot, utgrot, gl60, utggl60, de, dl, da, db, fst, ufst);
                    DBlist.Add(Artikel);
                    test lmao = new test();
                    lmao.Nibba(Artikel.SATNUM.ToString());
                    lmao.ShowDialog();
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
    }
}
