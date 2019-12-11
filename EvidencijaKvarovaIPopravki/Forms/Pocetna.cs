using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvidencijaKvarovaIPopravki.DomainModel;

namespace EvidencijaKvarovaIPopravki.Forms
{
    public partial class Pocetna : MetroFramework.Forms.MetroForm
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void btnDodajKvar_Click(object sender, EventArgs e)
        {
            var Forma = new NoviKvar();
            Forma.ShowDialog();
        }

        private void btnKreirajNalog_Click(object sender, EventArgs e)
        {
            var Forma = new Registracija();
            Forma.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var Forma = new Profil();
            Forma.ShowDialog();
        }

        private void btnUlogujSe_Click(object sender, EventArgs e)
        {
            var Forma = new Prijava();
            Forma.ShowDialog();
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = TabPopravke;
            foreach(Kvar k in DomainModel.DataSet.Instace.vratiSveKvarove())
            {
                DataGridViewRow rw = (DataGridViewRow)gridPopravke.Rows[0].Clone();
                rw.Cells[0].Value = k.naziv;
                gridPopravke.Rows.Add(rw);
            }
        }

        private void btnPopravka_Click(object sender, EventArgs e)
        {
            var Forma = new KvarPopravka();
            Forma.ShowDialog();
        }

        private void btnDelovi_Click(object sender, EventArgs e)
        {
            var Forma = new DostupniDelovi();
            Forma.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //foreach(Kvar k in DomainModel.DataSet.Instace.GetKorisnik(92).kvarovi)
            //{
            //    MessageBox.Show(k.Radionica.ToString());
            //}

            //MessageBox.Show(DomainModel.DataSet.Instace.GetKorisnik(92).kvarovi[0].ToString());
            //MessageBox.Show(DomainModel.DataSet.Instace.GetKorisnik(92).ToString());

            if (
            //DomainModel.DataSet.Instace.dodajLicnePodatke
            //    ( new LicniPodaci() {
            //        Adresa = new Adresa() { Grad = "Nis", UlicaIBroj = "MIlojka Radovica 12", id = Guid.NewGuid() },
            //        ime = "Nikola",
            //        prezime = "Nikolic",
            //        datumRodjenja = "5.2.1999",
            //        telefon = "018/123-551"
            //    })
            DomainModel.DataSet.Instace.dodajAutentifikaciju(new Autentifikacija() { 
                email="mail@mail",
                korisnickoIme = "korisnik1",
                sifra="asd"
            })
                )
                MessageBox.Show("Uspesno dodati podaci");
            else
                MessageBox.Show("Neuspesno dodati podaci");

        }
    }
}
