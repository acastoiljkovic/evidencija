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
    public partial class Registracija : MetroFramework.Forms.MetroForm
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void chkModel_CheckedChanged(object sender, EventArgs e)
        {
            PrikaziSakrij();
        }

        private void Registracija_Load(object sender, EventArgs e)
        {
            chkModel.Checked = false;
            PrikaziSakrij();
        }

        private void PrikaziSakrij()
        {
            if (!chkModel.Checked)
            {
                lblNazivModela.Visible = false;
                txtNazivModela.Visible = false;
            }
            else
            {
                lblNazivModela.Visible = true;
                txtNazivModela.Visible = true;
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (
            DomainModel.DataSet.Instace.dodajKorisnika(new Korisnik()
            {
                podaci = new LicniPodaci()
                {
                    Adresa = new Adresa()
                    {
                        Grad = txtGrad.Text,
                        UlicaIBroj = txtUlicaIBroj.Text
                    },
                    ime = txtIme.Text,
                    prezime = txtPrezime.Text,
                    telefon = "4567890",
                    datumRodjenja = dateVremePopravke.Text
                },
                authPodaci = new Autentifikacija()
                {
                    email = txtEmail.Text,
                    korisnickoIme = txtKorisnickoIme.Text,
                    sifra = txtLozinka.Text
                },
                kvarovi = null
            }))
                MessageBox.Show("Uspesno");
            else
                MessageBox.Show("Neuspesno");
        }
    }
}
