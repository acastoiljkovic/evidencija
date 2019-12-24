using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
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
            PrikaziSakrij();
        }

        //btnProfil
        private void metroButton1_Click(object sender, EventArgs e)
        {
            var Forma = new Profil();
            Forma.ShowDialog();
        }

        private void btnUlogujSe_Click(object sender, EventArgs e)
        {
            var Forma = new Prijava();
            Forma.ShowDialog();
            PrikaziSakrij();
        }

        private void PrikaziSakrij()
        {
            tabKvarovi.TabPages.Remove(tabRadionice);
            tabKvarovi.TabPages.Remove(tabNoviKvarovi);
            if (DomainModel.DataSet.Instace.PrijavljenKorisnik != null)
            {
                if (DomainModel.DataSet.Instace.PrijavljenKorisnik.indikator == "zaposleni")
                {
                    btnRadionica.Visible = true;
                    tabKvarovi.TabPages.Add(tabNoviKvarovi);
                }
                else
                {
                    btnRadionica.Visible = false;
                    tabKvarovi.TabPages.Add(tabRadionice);
                }
                btnProfil.Visible = true;
                btnKreirajNalog.Visible = false;
                btnUlogujSe.Visible = false;
                btnOdjaviSe.Visible = true;
                btnPrijaviKvar.Visible = true;
            }
            else
            {
                btnKreirajNalog.Visible = true;
                btnUlogujSe.Visible = true;
                btnOdjaviSe.Visible = false;
                btnProfil.Visible = false;
                btnRadionica.Visible = false;
                btnPrijaviKvar.Visible = false;
            }
            ucitajGridData();
        }

        public void ucitajGridData()
        {
            List<Kvar> kvarovi = DomainModel.DataSet.Instace.vratiSveKvarove();
            List<Radionica> radionice = DomainModel.DataSet.Instace.vratiSveRadionice();

            gridPopravke.ColumnCount = 7;
            gridPopravke.Columns[0].Name = "Naziv";
            gridPopravke.Columns[1].Name = "Vreme Prijave";
            gridPopravke.Columns[2].Name = "Vreme Popravke";
            gridPopravke.Columns[3].Name = "Ocena";
            gridPopravke.Columns[4].Name = "Korisnik";
            gridPopravke.Columns[5].Name = "Radionica";
            gridPopravke.Columns[6].Name = "SifraKvara";
            //gridPopravke.Columns[6].Visible = false;
            gridPopravke.Rows.Clear();
            if (kvarovi != null)
            {
                foreach (Kvar k in kvarovi)
                {
                    if (k != null)
                    {
                        string[] row = new string[7];
                        if (k.naziv != null)
                            row[0] = k.naziv;
                        else
                            row[0] = "";
                        if (k.vremePrijaveKvara != null)
                            row[1] = k.vremePrijaveKvara;
                        else
                            row[1] = "";
                        if (k.vremeIspravkeKvara != null)
                            row[2] = k.vremeIspravkeKvara;
                        else
                            row[2] = "";
                        if (k.ocena != null)
                            row[3] = k.ocena.ToString();
                        else
                            row[3] = "";
                        if (k.Korisnik != null)
                            row[4] = k.Korisnik.podaci.ime + " " + k.Korisnik.podaci.prezime;
                        else
                            row[4] = "";
                        if (k.Radionica != null)
                            row[5] = k.Radionica.naziv;
                        else
                            row[5] = "";
                        if (k.sifraKvara != null)
                            row[6] = k.sifraKvara;
                        else
                            row[6] = "";


                        gridPopravke.Rows.Add(row);
                    }
                }
            }

            gridRadionice.ColumnCount = 2;
            gridRadionice.Columns[0].Name = "Naziv";
            gridRadionice.Columns[1].Name = "Adresa";
            gridRadionice.Rows.Clear();
            if (radionice != null)
            {
                foreach (Radionica r in radionice)
                {
                    if (r != null)
                    {
                        string[] row = new string[2];

                        if (r.naziv != null)
                            row[0] = r.naziv;
                        else
                            row[0] = "";
                        if (r.Adresa != null)
                            row[1] = r.Adresa.UlicaIBroj + ", " + r.Adresa.Grad;
                        else
                            row[1] = "";
                        gridRadionice.Rows.Add(row);
                    }
                }
            }


            gridNoviKvarovi.ColumnCount = 7;
            gridNoviKvarovi.Columns[0].Name = "Naziv";
            gridNoviKvarovi.Columns[1].Name = "Vreme Prijave";
            gridNoviKvarovi.Columns[2].Name = "Vreme Popravke";
            gridNoviKvarovi.Columns[3].Name = "Ocena";
            gridNoviKvarovi.Columns[4].Name = "Korisnik";
            gridNoviKvarovi.Columns[5].Name = "Radionica";
            gridNoviKvarovi.Columns[6].Name = "SifraKvara";
            //gridPopravke.Columns[6].Visible = false;
            gridNoviKvarovi.Rows.Clear();
            if (kvarovi != null)
            {
                foreach (Kvar k in kvarovi)
                {
                    if (k != null && k.Radionica == null)
                    {
                        string[] row = new string[7];
                        if (k.naziv != null)
                            row[0] = k.naziv;
                        else
                            row[0] = "";
                        if (k.vremePrijaveKvara != null)
                            row[1] = k.vremePrijaveKvara;
                        else
                            row[1] = "";
                        if (k.vremeIspravkeKvara != null)
                            row[2] = k.vremeIspravkeKvara;
                        else
                            row[2] = "";
                        if (k.ocena != null)
                            row[3] = k.ocena.ToString();
                        else
                            row[3] = "";
                        if (k.Korisnik != null)
                            row[4] = k.Korisnik.podaci.ime + " " + k.Korisnik.podaci.prezime;
                        else
                            row[4] = "";
                        if (k.Radionica != null)
                            row[5] = k.Radionica.naziv;
                        else
                            row[5] = "";
                        if (k.sifraKvara != null)
                            row[6] = k.sifraKvara;
                        else
                            row[6] = "";


                        gridNoviKvarovi.Rows.Add(row);
                    }
                }
            }

        }
        private void Pocetna_Load(object sender, EventArgs e)
        {
            PrikaziSakrij();
            tabKvarovi.SelectedTab = tabPopravke;
            ucitajGridData();
            
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
                MessageBox.Show("Uspesno dodata autentifikacija");
            else
                MessageBox.Show("Neuspesno dodati podaci");

        }

        private void btnRadionica_Click(object sender, EventArgs e)
        {
            if (DomainModel.DataSet.Instace.PrijavljenKorisnik != null)
            {
                var Forma = new RadionicaPrikaz(DomainModel.DataSet.Instace.vratiRadionicuRadnik(DomainModel.DataSet.Instace.PrijavljenKorisnik));
                Forma.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this,"Niste zaposleni ni u jednoj radionici !","Obavestenje");
            }
        }

        private void btnPrijaviKvar_Click(object sender, EventArgs e)
        {
            var Forma = new PrijavaKvara();
            Forma.ShowDialog();
        }

        private void gridPopravke_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            DomainModel.DataSet.Instace.PrijavljenKorisnik = null;
            PrikaziSakrij();
        }

        private void gridPopravke_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Forma = new KvarPopravka(DomainModel.DataSet.Instace.vratiKvarSifra(gridPopravke.Rows[e.RowIndex].Cells[6].Value.ToString()));
            Forma.ShowDialog();
        }

        private void gridRadionice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var Forma = new RadionicaPrikaz(DomainModel.DataSet.Instace.vratiRadionicuNaziv(gridRadionice.Rows[e.RowIndex].Cells[0].Value.ToString()));
            Forma.ShowDialog();
        }

        private void Pocetna_Activated(object sender, EventArgs e)
        {
            ucitajGridData();
        }

        private void gridNoviKvarovi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var formNoviKvar = new NoviKvar(DomainModel.DataSet.Instace.vratiKvarSifra(gridNoviKvarovi.Rows[e.RowIndex].Cells[6].Value.ToString()));
            formNoviKvar.ShowDialog();
        }
    }
}
