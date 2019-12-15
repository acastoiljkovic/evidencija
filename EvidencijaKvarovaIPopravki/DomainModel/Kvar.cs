using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaKvarovaIPopravki.DomainModel
{
    public class Kvar
    {
        public int sifraKvara { get; set; }//unique
        public string naziv { get; set; }//unique - u cilju lakse pretrage
        //public string zahtevnostPopravke { get; set; }//u smislu dodatnih objasnjenja, pored samih, novih delova
        public string vremePrijaveKvara { get; set; }
        public string vremeIspravkeKvara { get; set; }//predvidjeno/stvarno
        public int ocena { get; set; }
        public string modelVozila { get; set; }
        public List<string> komentari { get; set; }
        public List<string> saveti { get; set; }
        // korisnik kod koga se javio kvar
        public Osoba Korisnik { get; set; }
        public Radionica Radionica { get; set; }//konkretna radionica u lancu radionica
        // zaposleni koji rade na kvaru 
        public List<Osoba> ListaZaposlenih { get; set; }
        public List<Deo> Delovi { get; set; }

        public Kvar()
        {
            Delovi = new List<Deo>();
            ListaZaposlenih = new List<Osoba>();
            komentari = new List<string>();
            saveti = new List<string>();
        }

        public override string ToString()
        {
            return "Naziv: "+naziv +Environment.NewLine+ "Model Vozila: " + modelVozila;
        }
    }
}
