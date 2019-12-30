using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reklamcılık_Otomasyonu
{
    class Musteri
    {
        private string musterikodu;
        private string musteriadi;
        private string musteritelefonu;
        private string musteriadresi;
        private string musteritipi;
        public void setMusKod(string kod)
        {
            musterikodu = kod;
        }

        public string getMusKod()
        {
            return musterikodu;
        }
        public void setMusAdi(string ad)
        {
            musteriadi = ad;
        }
        public string getMusAdi()
        {
            return musteriadi;
        }
        public void setMusTel(string tel)
        {
            musteritelefonu = tel;
        }
        public string getMusTel()
        {
            return musteritelefonu;
        }
        public void setMusAdrs(string adres)
        {
            musteriadresi = adres;
        }
        public string getMusAdrs()
        {
            return musteriadresi;
        }
        public void setMusTipi(string tip)
        {
            musteritipi = tip;
        }
        public string getMusTipi()
        {
            return musteritipi;
        }
    }
}
