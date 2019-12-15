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
using MetroFramework;

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
            chkZaposleni.Checked = false;
            PrikaziSakrij();
        }

        private void PrikaziSakrij()
        {
            if (!chkZaposleni.Checked)
            {
                lblZaposleni.Visible = false;
                comboBoxRadionica.Visible = false;
                btnDodajRadionicu.Visible = false;
            }
            else
            {
                lblZaposleni.Visible = true;
                comboBoxRadionica.Visible = true;
                btnDodajRadionicu.Visible = true;
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            string provera = DomainModel.DataSet.Instace.proveriDaLiPostojiKorisnik(txtEmail.Text, txtKorisnickoIme.Text);
            if (provera.Equals("Provera uspesno prosla!"))
            {
                if (!txtLozinka.Text.Equals(txtLozinkaPonovo.Text))
                    MetroMessageBox.Show(this, "Lozinke ne odgovaraju jedna drugoj!", "Obavestenje");
                else
                {
                    string indikatorOsobe;
                    if (chkZaposleni.Checked)
                    {
                        indikatorOsobe = "zaposleni";
                        if(comboBoxRadionica.SelectedItem != null){
                            if (
                            DomainModel.DataSet.Instace.dodajZaposlenog(new Osoba()
                            {
                                indikator = indikatorOsobe,
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
                            }, comboBoxRadionica.SelectedItem.ToString()))
                            {
                                MetroMessageBox.Show(this, "Uspesno dodat zaposleni!", "Obavestenje");
                                this.Close();
                            }
                            else
                                MetroMessageBox.Show(this, "Neuspesno kreirnaje zaposlenog !", "Obavestenje");
                        }
                        else
                            MetroMessageBox.Show(this, "Odaberite radionicu, ili ukoliko je nema u listi kreirajte !", "Obavestenje");
                    }
                    else
                    {
                        indikatorOsobe = "korisnik";
                        if (
                        DomainModel.DataSet.Instace.dodajKorisnika(new Osoba()
                        {
                            indikator = indikatorOsobe,
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
                        {
                            MetroMessageBox.Show(this, "Uspesno dodat korisnik!", "Obavestenje");
                            this.Close();
                        }
                        else
                            MetroMessageBox.Show(this, "Neuspesno kreirnaje korisnika !", "Obavestenje");
                    }
                }
            }
            else
                MetroMessageBox.Show(this, provera, "Obavestenje");
        }

        private void chkZaposleni_CheckedChanged(object sender, EventArgs e)
        {
            PrikaziSakrij();
        }

        private void btnDodajRadionicu_Click(object sender, EventArgs e)
        {
            var Forma = new DodajRadionicu();
            Forma.ShowDialog();
        }

        private void Registracija_Activated(object sender, EventArgs e)
        {
            comboBoxRadionica.Items.Clear();
            foreach (Radionica r in DomainModel.DataSet.Instace.vratiSveRadionice())
            {
                comboBoxRadionica.Items.Add(r.naziv);
            }
        }
    }
}
