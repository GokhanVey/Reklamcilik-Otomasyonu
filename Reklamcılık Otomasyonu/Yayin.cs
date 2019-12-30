using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reklamcılık_Otomasyonu
{
    class Yayin
    {
        private string yayinkodu;
        private string yayinadi;
        private string yayinaraligi;
        private string yayinturu;
        public void setYayKod(string kod)
        {
            yayinkodu = kod;
        }
        public string getYayKod()
        {
            return yayinkodu;
        }
        public void setYayAdi(string ad)
        {
            yayinadi = ad;
        }
        public string getYayAdi()
        {
            return yayinadi;
        }
        public void setYayAra(string ara)
        {
            yayinaraligi = ara;
        }
        public string getYayAra()
        {
            return yayinaraligi;
        }
        public void setYayTur(string tur)
        {
            yayinturu = tur;
        }
        public string getYayTur()
        {
            return yayinturu;
        }
    }
}
