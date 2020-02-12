using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Configuration;

namespace Åke_programmet.Library
{
    public class Database
    {
        public List<Data> DBlist = new List<Data>();
        private readonly List<User> DBids = new List<User>();
        private MySqlConnectionStringBuilder Builder = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            UserID = "root",
            Password = "",
            Database = "åkedb"
        };

        public List<User> DBinfo() //Checks for Recipe info and returns it.
        {
            int i = DBlist.Count - 1;
            foreach (Data item in DBlist)
            {
                DBids.Add(new User() { Satnum = item.SATSNUM, Ver = item.VER, Status = item.STATUS });
                i--;

                if (i <= -1)
                {
                    break;
                }
            }
            return DBids;
        }

        public void Add_Recipe(string Produktnamn, string Prodnum, string Kulör, string Sapnum, string Sapsatnum, string Justering1_a, string Justering1_b, string Justering2_a, string Justering2_b, string Justering3_a, string Justering3_b, string Justering4_a, string Justering4_b, string Nyansering1_a, string Nyansering1_b, string Nyansering2_a, string Nyansering2_b, string Nyansering3_a, string Nyansering3_b, string Nyansering4_a, string Nyansering4_b, string Densitet, string Utgdensitet, string Copdin, string Utcop, string Rivn, string Gl85, string Ugl85, string Ph, string Utph, string Rot, string Utgrot, string Gl60, string Utggl60, string De, string Dl, string Da, string Db, string Fst, string Ufst, string Bort, string Utskrdat, string Startdat, string Godkdat, string Tappdat, string Recvikt, string Satsvikt, string Satsvol, string Tappvikt, string Tappvol, string Utbyte, string Tank, string Cm, string Upmvol, string Status, string Ver, string Just, string Nyans, string Tillvtid, string Kontrtid, string Anmärkning, string Kod_bok)
        {
            MySqlConnection Connection = new MySqlConnection(Builder.ConnectionString);
            MySqlCommand command = Connection.CreateCommand();
            command.CommandText = "INSERT INTO `åkedb`.`åkedb` (`PRODUKTNAMN`, `PRODNUM`, `KULÖR`, `SAPNUM`, `SAPSATNUM`, `JUSTERING1_a`, `JUSTERING1_b`, `Kolumn 9`, `Kolumn 10`, `Kolumn 11`, `Kolumn 12`, `Kolumn 13`, `Kolumn 14`, `Kolumn 15`, `Kolumn 16`, `Kolumn 17`, `Kolumn 18`, `Kolumn 19`, `Kolumn 20`, `Kolumn 21`, `Kolumn 22`, `Kolumn 23`, `Kolumn 24`, `Kolumn 25`, `Kolumn 26`, `Kolumn 27`, `Kolumn 28`, `Kolumn 29`, `Kolumn 30`, `Kolumn 31`, `Kolumn 32`, `Kolumn 33`, `Kolumn 34`, `Kolumn 35`, `Kolumn 36`, `Kolumn 37`, `Kolumn 38`, `Kolumn 39`, `Kolumn 40`, `Kolumn 41`, `Kolumn 42`, `Kolumn 43`, `Kolumn 44`, `Kolumn 45`, `Kolumn 46`, `Kolumn 47`, `Kolumn 48`, `Kolumn 49`, `Kolumn 50`, `Kolumn 51`, `Kolumn 52`, `Kolumn 53`, `Kolumn 54`, `Kolumn 55`, `Kolumn 56`, `Kolumn 57`, `Kolumn 58`, `Kolumn 59`, `Kolumn 60`, `Kolumn 61`, `Kolumn 62`, `Kolumn 63`) VALUES ('" + Produktnamn + "', '" + Prodnum + "', '" + Kulör + "', '" + Sapnum + "', '" + Sapsatnum + "', '" + Justering1_a + "', '" + Justering1_b + "', '" + Justering2_a + "', '" + Justering2_b + "', '" + Justering3_a + "', '" + Justering3_b + "', '" + Justering4_a + "', '" + Justering4_b + "', '" + Nyansering1_a + "', '" + Nyansering1_b + "', '" + Nyansering2_a + "', '" + Nyansering2_b + "', '" + Nyansering3_a + "', '" + Nyansering3_b + "', '" + Nyansering4_a + "', '" + Nyansering4_b + "', '" + Densitet + "', '" + Utgdensitet + "', '" + Copdin + "', '" + Utcop + "', '" + Rivn + "', '" + Gl85 + "', '" + Ugl85 + "', '" + Ph + "', '" + Utph + "', '" + Rot + "', '" + Utgrot + "', '" + Gl60 + "', '" + Utggl60 + "', '" + De + "', '" + Dl + "', '" + Da + "', '" + Db + "', '" + Fst + "', '" + Ufst + "', '" + Bort + "', '" + Utskrdat + "', '" + Startdat + "', '" + Godkdat + "', '" + Tappdat + "', '" + Recvikt + "', '" + Satsvikt + "', '" + Satsvol + "', '" + Tappvikt + "', '" + Tappvol + "', '" + Utbyte + "', '" + Tank + "', '" + Cm + "', '" + Upmvol + "', '" + Status + "', '" + Ver + "', '" + Just + "', '" + Nyans + "', '" + Tillvtid + "', '" + Kontrtid + "', '" + Anmärkning + "', '" + Kod_bok + "');";
            Connection.Open();
            MySqlDataReader myReader = command.ExecuteReader();
            try
            {
                while (myReader.Read())
                {

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

        public void Refresh() //Gets latest data from DB
        {
            DBlist.Clear();
            DBids.Clear();
            MySqlConnection Connection = new MySqlConnection(Builder.ConnectionString);
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

        public class User
        {
            public string Satnum { get; set; }

            public string Ver { get; set; }

            public string Status { get; set; }
        }
    }
}