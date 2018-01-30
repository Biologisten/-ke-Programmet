using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Åke_programmet.Library
{
    public class Data
    {
        public List<Data> artikel;
        private string satnum;
        private string produktnamn;
        private string prodnum;
        private string kulör;
        private string sapnum;
        private string sapsatnum;
        private string justering1_a;
        private string justering1_b;
        private string justering2_a;
        private string justering2_b;
        private string justering3_a;
        private string justering3_b;
        private string justering4_a;
        private string justering4_b;
        private string nyansering1_a;
        private string nyansering1_b;
        private string nyansering2_a;
        private string nyansering2_b;
        private string nyansering3_a;
        private string nyansering3_b;
        private string nyansering4_a;
        private string nyansering4_b;
        private string densitet;
        private string utgdensitet;
        private string copdin;
        private string utcop;
        private string rivn;
        private string gl85;
        private string ugl85;
        private string ph;
        private string utph;
        private string rot;
        private string utgrot;
        private string gl60;
        private string utggl60;
        private string de;
        private string dl;
        private string da;
        private string db;
        private string fst;
        private string ufst;
        private string bort;
        private string utskrdat;
        private string startdat;
        private string godkdat;
        private string tappdat;
        private string recvikt;
        private string satsvikt;
        private string satsvol;
        private string tappvikt;
        private string tappvol;
        private string utbyte;
        private string tank;
        private string cm;
        private string upmvol;
        private string status;
        private string ver;
        private string just;
        private string nyans;
        private string tillvtid;
        private string kontrtid;
        private string anmärkning;
        private string kod_bok;



        public Data(string satnum, string produktnamn, string prodnum, string kulör, string sapnum, string sapsatnum, string justering1_a, string justering1_b, string justering2_a, string justering2_b, string justering3_a, string justering3_b, string justering4_a, string justering4_b, string nyansering1_a, string nyansering1_b, string nyansering2_a, string nyansering2_b, string nyansering3_a, string nyansering3_b, string nyansering4_a, string nyansering4_b, string densitet, string utgdensitet, string copdin, string utcop, string rivn, string gl85, string ugl85, string ph, string utph, string rot, string utgrot, string gl60, string utggl60, string de, string dl, string da, string db, string fst, string ufst, string bort, string utskrdat, string startdat, string godkdat, string tappdat, string recvikt, string satsvikt, string satsvol, string tappvikt, string tappvol, string utbyte, string tank, string cm, string upmvol, string status, string ver, string just, string nyans, string tillvtid, string kontrtid, string anmärkning, string kod_bok)
        {
            this.satnum = satnum;
            this.produktnamn = produktnamn;
            this.prodnum = prodnum;
            this.kulör = kulör;
            this.sapnum = sapnum;
            this.sapsatnum = sapsatnum;
            this.justering1_a = justering1_a;
            this.justering1_b = justering1_b;
            this.justering2_a = justering2_a;
            this.justering2_b = justering2_b;
            this.justering3_a = justering3_a;
            this.justering3_b = justering3_b;
            this.justering4_a = justering4_a;
            this.justering4_b = justering4_b;
            this.nyansering1_a = nyansering1_a;
            this.nyansering1_b = nyansering1_b;
            this.nyansering2_a = nyansering2_a;
            this.nyansering2_b = nyansering2_b;
            this.nyansering3_a = nyansering3_a;
            this.nyansering3_b = nyansering3_b;
            this.nyansering4_a = nyansering4_a;
            this.nyansering4_b = nyansering4_b;
            this.densitet = densitet;
            this.utgdensitet = utgdensitet;
            this.copdin = copdin;
            this.utcop = utcop;
            this.rivn = rivn;
            this.gl85 = gl85;
            this.ugl85 = ugl85;
            this.ph = ph;
            this.utph = utph;
            this.rot = rot;
            this.utgrot = utgrot;
            this.gl60 = gl60;
            this.utggl60 = utggl60;
            this.de = de;
            this.dl = dl;
            this.da = da;
            this.db = db;
            this.fst = fst;
            this.ufst = ufst;
            this.bort = bort;
            this.utskrdat = utskrdat;
            this.startdat = startdat;
            this.godkdat = godkdat;
            this.tappdat = tappdat;
            this.recvikt = recvikt;
            this.satsvikt = satsvikt;
            this.satsvol = satsvol;
            this.tappvikt = tappvikt;
            this.tappvol = tappvol;
            this.utbyte = utbyte;
            this.tank = tank;
            this.cm = cm;
            this.upmvol = upmvol;
            this.status = status;
            this.ver = ver;
            this.just = just;
            this.nyans = nyans;
            this.tillvtid = tillvtid;
            this.kontrtid = kontrtid;
            this.anmärkning = anmärkning;
            this.kod_bok = kod_bok;
    }

        public string SATNUM
        {
            get
            {
                return this.satnum;
            }
            set
            {
                this.satnum = value;
            }
        }

        public string PRODUKTNAMN
        {
            get
            {
                return this.produktnamn;
            }
            set
            {
                this.produktnamn = value;
            }
        }

        public string PRODNUM
        {
            get
            {
                return this.prodnum;
            }
            set
            {
                this.prodnum = value;
            }
        }

        public string KULÖR
        {
            get
            {
                return this.kulör;
            }
            set
            {
                this.kulör = value;
            }
        }

        public string SAPNUM
        {
            get
            {
                return this.sapnum;
            }
            set
            {
                this.sapnum = value;
            }
        }

        public string SAPSATNUM
        {
            get
            {
                return this.sapsatnum;
            }
            set
            {
                this.sapsatnum = value;
            }
        }

        public string JUSTERING1_A
        {
            get
            {
                return this.justering1_a;
            }
            set
            {
                this.justering1_a = value;
            }
        }

        public string JUSTERING1_B
        {
            get
            {
                return this.justering1_b;
            }
            set
            {
                this.justering1_b = value;
            }
        }

        public string JUSTERING2_A
        {
            get
            {
                return this.justering2_a;
            }
            set
            {
                this.justering2_a = value;
            }
        }

        public string JUSTERING2_B
        {
            get
            {
                return this.justering2_b;
            }
            set
            {
                this.justering2_b = value;
            }
        }

        public string JUSTERING3_A
        {
            get
            {
                return this.justering3_a;
            }
            set
            {
                this.justering3_a = value;
            }
        }

        public string JUSTERING3_B
        {
            get
            {
                return this.justering3_b;
            }
            set
            {
                this.justering3_b = value;
            }
        }

        public string JUSTERING4_A
        {
            get
            {
                return this.justering4_a;
            }
            set
            {
                this.justering4_a = value;
            }
        }

        public string JUSTERING4_B
        {
            get
            {
                return this.justering4_b;
            }
            set
            {
                this.justering4_b = value;
            }
        }

        public string NYANSERING1_A
        {
            get
            {
                return this.nyansering1_a;
            }
            set
            {
                this.nyansering1_a = value;
            }
        }

        public string NYANSERING1_B
        {
            get
            {
                return this.nyansering1_b;
            }
            set
            {
                this.nyansering1_b = value;
            }
        }

        public string NYANSERING2_A
        {
            get
            {
                return this.nyansering2_a;
            }
            set
            {
                this.nyansering2_a = value;
            }
        }

        public string NYANSERING2_B
        {
            get
            {
                return this.nyansering2_b;
            }
            set
            {
                this.nyansering2_b = value;
            }
        }

        public string NYANSERING3_A
        {
            get
            {
                return this.nyansering3_a;
            }
            set
            {
                this.nyansering3_a = value;
            }
        }

        public string NYANSERING3_B
        {
            get
            {
                return this.nyansering3_b;
            }
            set
            {
                this.nyansering3_b = value;
            }
        }

        public string NYANSERING4_A
        {
            get
            {
                return this.nyansering4_a;
            }
            set
            {
                this.nyansering4_a = value;
            }
        }

        public string NYANSERING4_B
        {
            get
            {
                return this.nyansering4_b;
            }
            set
            {
                this.nyansering4_b = value;
            }
        }

        public string GL85
        {
            get
            {
                return this.gl85;
            }
            set
            {
                this.gl85 = value;
            }
        }

        public string UGL85
        {
            get
            {
                return this.ugl85;
            }
            set
            {
                this.ugl85 = value;
            }
        }

        public string PH
        {
            get
            {
                return this.ph;
            }
            set
            {
                this.ph = value;
            }
        }

        public string ROT
        {
            get
            {
                return this.rot;
            }
            set
            {
                this.rot = value;
            }
        }

        public string UTGROT
        {
            get
            {
                return this.utgrot;
            }
            set
            {
                this.utgrot = value;
            }
        }

        public string GL60
        {
            get
            {
                return this.gl60;
            }
            set
            {
                this.gl60 = value;
            }
        }

        public string UTGGL60
        {
            get
            {
                return this.utggl60;
            }
            set
            {
                this.utggl60 = value;
            }
        }
        
        public string DE
        {
            get
            {
                return this.de;
            }
            set
            {
                this.de = value;
            }
        }

        public string DL
        {
            get
            {
                return this.dl;
            }
            set
            {
                this.dl = value;
            }
        }

        public string DA
        {
            get
            {
                return this.da;
            }
            set
            {
                this.da = value;
            }
        }

        public string FST
        {
            get
            {
                return this.fst;
            }
            set
            {
                this.fst = value;
            }
        }

        public string UFST
        {
            get
            {
                return this.ufst;
            }
            set
            {
                this.ufst = value;
            }
        }

        public string BORT
        {
            get
            {
                return this.bort;
            }
            set
            {
                this.bort = value;
            }
        }

        public string UTSKRDAT
        {
            get
            {
                return this.utskrdat;
            }
            set
            {
                this.utskrdat = value;
            }
        }

        public string STARTDAT
        {
            get
            {
                return this.startdat;
            }
            set
            {
                this.startdat = value;
            }
        }

        public string GODKDAT
        {
            get
            {
                return this.godkdat;
            }
            set
            {
                this.godkdat = value;
            }
        }

        public string TAPPDAT
        {
            get
            {
                return this.tappdat;
            }
            set
            {
                this.tappdat = value;
            }
        }

        public string RECVIKT
        {
            get
            {
                return this.recvikt;
            }
            set
            {
                this.recvikt = value;
            }
        }

        public string SATSVIKT
        {
            get
            {
                return this.satsvikt;
            }
            set
            {
                this.satsvikt = value;
            }
        }

        public string SATSVOL
        {
            get
            {
                return this.satsvol;
            }
            set
            {
                this.satsvol = value;
            }
        }

        public string TAPPVIKT
        {
            get
            {
                return this.tappvikt;
            }
            set
            {
                this.tappvikt = value;
            }
        }

        public string TAPPVOL
        {
            get
            {
                return this.tappvol;
            }
            set
            {
                this.tappvol = value;
            }
        }

        public string UTBYTE
        {
            get
            {
                return this.utbyte;
            }
            set
            {
                this.utbyte = value;
            }
        }

        public string TANK
        {
            get
            {
                return this.tank;
            }
            set
            {
                this.tank = value;
            }
        }

        public string CM
        {
            get
            {
                return this.CM;
            }
            set
            {
                this.CM = value;
            }
        }

        public string UPMVOL
        {
            get
            {
                return this.upmvol;
            }
            set
            {
                this.upmvol = value;
            }
        }

        public string STATUS
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }

        public string VER
        {
            get
            {
                return this.ver;
            }
            set
            {
                this.ver = value;
            }
        }

        public string JUST
        {
            get
            {
                return this.just;
            }
            set
            {
                this.just = value;
            }
        }

        public string NYANS
        {
            get
            {
                return this.nyans;
            }
            set
            {
                this.nyans = value;
            }
        }

        public string TILLVTID
        {
            get
            {
                return this.tillvtid;
            }
            set
            {
                this.tillvtid = value;
            }
        }

        public string KONTRTID
        {
            get
            {
                return this.kontrtid;
            }
            set
            {
                this.kontrtid = value;
            }
        }

        public string ANMÄRKNING
        {
            get
            {
                return this.anmärkning;
            }
            set
            {
                this.anmärkning = value;
            }
        }

        public string KOD_BOK
        {
            get
            {
                return this.kod_bok;
            }
            set
            {
                this.kod_bok = value;
            }
        }
    }
}
