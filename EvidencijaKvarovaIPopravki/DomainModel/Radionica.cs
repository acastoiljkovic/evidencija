using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaKvarovaIPopravki.DomainModel
{
    public class Radionica
    {
        public Guid id { get; set; }
        public string naziv { get; set; }
        public Adresa Adresa { get; set; }
        public List<Zaposleni> Zaposleni { get; set; }
        public List<Deo> Delovi { get; set; }
        public List<Kvar> Kvarovi { get; set; }

        public Radionica()
        {
            Zaposleni = new List<Zaposleni>();
            Delovi = new List<Deo>();
            Kvarovi = new List<Kvar>();
        }

        public override string ToString()
        {
            return "Radionica: "+this.naziv;
        }
    }
}
