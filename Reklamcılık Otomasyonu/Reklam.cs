using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reklamcılık_Otomasyonu
{
    class Reklam
    {
        private string reklamkodu;
        private string musterikodu;
        private string reklamgorunumu;
        private string reklamboyutu;
        public void setRekKod(string kod)
        {
            reklamkodu = kod;
        }
        public string getRekKod()
        {
            return reklamkodu;
        }
        public void setMusKod(string kod)
        {
            musterikodu = kod;
        }
        public string getMusKod()
        {
            return musterikodu;
        }
        public void setRekGor(string gor)
        {
            reklamgorunumu = gor;
        }
        public string getRekGor()
        {
            return reklamgorunumu;
        }
        public void setRekBoy(string boy)
        {
            reklamboyutu = boy;
        }
        public string getRekBoy()
        {
            return reklamboyutu;
        }
    }
}
