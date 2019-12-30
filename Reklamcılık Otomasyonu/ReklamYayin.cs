using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reklamcılık_Otomasyonu
{
    class ReklamYayin
    {
        private string reklamkodu;
        private string yayinkodu;
        private int sayinumarasi;
        private int reklamsayisi;
        private string reklamkonumu;
        private int reklamucreti;
        private bool odeme;
        public void setRekKod(string kod)
        {
            reklamkodu = kod;
        }
        public string getRekKod()
        {
            return reklamkodu;
        }
        public void setYayKod(string kod)
        {
            yayinkodu = kod;
        }
        public string getYayKod()
        {
            return yayinkodu;
        }
        public void setSayNum(int num)
        {
            sayinumarasi = num;
        }
        public int getSayNum()
        {
            return sayinumarasi;
        }
        public void setRekSay(int say)
        {
            reklamsayisi = say;
        }
        public int getRekSay()
        {
            return reklamsayisi;
        }
        public void setRekKon(string kon)
        {
            reklamkonumu = kon;
        }
        public string getRekKon()
        {
            return reklamkonumu;
        }
        public void setRekUcr(int ucr)
        {
            reklamucreti = ucr;
        }
        public int getRekUcr()
        {
            return reklamucreti;
        }

        public void setOdeme(bool ode)
        {
            odeme = ode;
        }

        public bool getOdeme()
        {
            return odeme;
        }
    }
}
