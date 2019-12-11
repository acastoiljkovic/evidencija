using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaKvarovaIPopravki.DomainModel
{
    public class Deo
    {
        public Guid id { get; set; }
        public string naziv { get; set; }
        public string kolicina { get; set; }

        public override string ToString()
        {
            return naziv + ": " + kolicina;
        }
    }
}
