using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaKvarovaIPopravki.DomainModel
{
    public class Adresa
    {
        public Guid id { get; set; }
        public string UlicaIBroj { get; set; }
        public string Grad { get; set; }

        public override string ToString()
        {
            return UlicaIBroj + " , " + Grad;
        }
    }
}
