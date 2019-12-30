using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reklamcılık_Otomasyonu
{
    class Sayi
    {
    private string yayinkodu;
    private int sayinumarasi;
    private DateTime yayintarihi;
    private int sayfasayisi;

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
        public void setYayTar(DateTime tar)
        {
            yayintarihi = tar;
        }
        public DateTime getYayTar()
        {
            return yayintarihi;
        }
        public void setSaySay(int say)
        {
            sayfasayisi = say;
        }
        public int getSaySay()
        {
            return sayfasayisi;
        }
    }
}
