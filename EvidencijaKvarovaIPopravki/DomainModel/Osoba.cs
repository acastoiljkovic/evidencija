using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvidencijaKvarovaIPopravki.DomainModel;

namespace EvidencijaKvarovaIPopravki.DomainModel
{
    public class Osoba
    {
        public string indikator { get; set; }//korisnik/zaposleni
        public LicniPodaci podaci { get; set; }
        public Autentifikacija authPodaci { get; set; }
        public List<Kvar> kvarovi { get; set; }
        public Osoba()
        {
            kvarovi = new List<Kvar>();
        }

        public override string ToString()
        {
            return "Korisnicko Ime: " + authPodaci.korisnickoIme +
                "\nEmail: " + authPodaci.email +
                "\nAdresa: " + podaci.Adresa.ToString() +
                "\nTelefon: " + podaci.telefon +
                "\nIme: " + podaci.ime +
                "\nPrezime:" + podaci.prezime +
                "\nDatum rodjenja: " + podaci.datumRodjenja;
        }
    }
}
