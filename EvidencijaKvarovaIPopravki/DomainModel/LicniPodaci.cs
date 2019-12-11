using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaKvarovaIPopravki.DomainModel
{
    public class LicniPodaci
    {
        public Guid id { get; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public Adresa Adresa { get; set; }
        public string telefon { get; set; }
        public string datumRodjenja { get; set; }
    }
}
