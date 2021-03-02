using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es1Classi
{
    public class Tabella
    {
        List<Riga> righe = new List<Riga> ();

        public Tabella() { }

        public Riga NewRiga()
        {
            Riga r = new Riga();
            righe.Add(r);
            return r;
        }
    }
}
