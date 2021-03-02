using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es1Classi
{
    public class Riga
    {
        List<Cella> celle = new List<Cella>();

        public Riga() { }

        public Cella NewCella()
        {
            Cella c = new Cella();
            celle.Add(c);
            return c;
        }
    }
}
