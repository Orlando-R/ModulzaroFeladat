using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro0414
{
    class Balosok
    {
        public string nev { get; set; }
        public string elso { get; set; }
        public string utolso { get; set; }
        public double suly { get; set; }
        public double magassag { get; set; }

        public Balosok(string soronkent)
        {
            string[] sor = soronkent.Split(';');
            this.nev = sor[0];
            this.elso = sor[1];
            this.utolso = sor[2];
            this.suly = int.Parse(sor[3]);
            this.magassag = int.Parse(sor[4]);
        }
    }


    
}
