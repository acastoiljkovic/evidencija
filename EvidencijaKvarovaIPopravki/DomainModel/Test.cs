using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaKvarovaIPopravki.DomainModel
{
    public class Test
    {
        public String ime { get; set; }
        public String prezime { get; set; }
        public String datumRodjenja { get; set; }
        public int MyProperty { get; set; }
        public String telefon { get; set; }
        public Test()
        {

        }

        public override string ToString()
        {
            return "Ime: " + this.ime + Environment.NewLine + "Prezime: " + this.prezime + Environment.NewLine + "DatumRodjenja: " + this.datumRodjenja + Environment.NewLine + "Telefon: " + this.telefon;
        }
    }
}
