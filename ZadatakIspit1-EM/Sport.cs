using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakIspit1_EM
{
    class Sport
    {
        private string Naziv;
        private bool IgraLiSeSportom;
        private byte BrojIgraca;

        public Sport(string s)
        {
            Naziv = s;
        }
        public Sport(string s, bool b)
        {
            Naziv = s;
            IgraLiSeSportom = b;
        }
        public Sport(string s, bool b, byte n)
        {
            Naziv = s;
            IgraLiSeSportom = b;
            BrojIgraca = n;
        }

    }
}
