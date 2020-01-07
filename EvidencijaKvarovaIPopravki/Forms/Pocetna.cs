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
            tabKvarovi.TabPages.Remove(tabRadnici);
            if (DomainModel.DataSet.Instace.PrijavljenKorisnik != null)
            {
                if (DomainModel.DataSet.Instace.PrijavljenKorisnik.indikator == "zaposleni")
                {
                    btnRadionica.Visible = true;
                    tabKvarovi.TabPages.Add(tabNoviKvarovi);
                    btnPrijaviKvar.Visible = false;
                    
                }
                else
                {
                    btnRadionica.Visible = false;
                    tabKvarovi.TabPages.Add(tabRadionice);
                    tabKvarovi.TabPages.Add(tabRadnici);
                    btnPrijaviKvar.Visible = true;
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
            ucitajGridPopravke(null);
            ucitajGridRadionice(null);
            ucitajGridNoviKvarovi(null);
            ucitajGridKorisnici(DomainModel.DataSet.Instace.NadjiPrvihPetKorisnika(""));
            ucitajGridRadnici(DomainModel.DataSet.Instace.VratiPodatkeRadnikaKorisnikovihKvarova(""));
            
        }

        public void ucitajGridRadnici(List<LicniPodaci> podaciRadnika)
        {
            gridRadnici.ColumnCount = 3;
            gridRadnici.Columns[0].Name = "Ime";
            gridRadnici.Columns[1].Name = "Prezime";
            gridRadnici.Columns[2].Name = "Kontakt telefon";
            gridRadnici.Rows.Clear();
            if (podaciRadnika != null)
            {
                foreach (LicniPodaci lp in podaciRadnika)
                {
                    string[] row = new string[3];
                    if (lp.ime != null)
                        row[0] = lp.ime;
                    if (lp.prezime != null)
                        row[1] = lp.prezime;
                    if (lp.telefon != null)
                        row[2] = lp.telefon;
                    gridRadnici.Rows.Add(row);

                }
            }
        }
        public void ucitajGridKorisnici(List<Osoba> korisnici)
        {
            gridKorisnici.ColumnCount = 6;
            gridKorisnici.Columns[0].Name = "Ime";
            gridKorisnici.Columns[1].Name = "Prezime";
            gridKorisnici.Columns[2].Name = "Email";
            gridKorisnici.Columns[3].Name = "Telefon";
            gridKorisnici.Columns[4].Name = "Adresa";
            gridKorisnici.Columns[5].Name = "Broj popravki";
            gridKorisnici.Rows.Clear();
            if (korisnici != null)
            {
                foreach (Osoba o in korisnici)
                {
                    string[] row = new string[6];
                    if (o.podaci.ime != null)
                        row[0] = o.podaci.ime;
                    if (o.podaci.prezime != null)
                        row[1] = o.podaci.prezime;
                    if (o.authPodaci.email != null)
                        row[2] = o.authPodaci.email;
                    if (o.podaci.telefon != null)
                        row[3] = o.podaci.telefon;
                    if (o.podaci.Adresa.Grad != null && o.podaci.Adresa.UlicaIBroj != null)
                        row[4] = o.podaci.Adresa.UlicaIBroj + " " + o.podaci.Adresa.Grad;
                    if (o.kvarovi != null)
                        row[5] = o.kvarovi.Count.ToString();
                    gridKorisnici.Rows.Add(row);

                }
            }
        }

        public void ucitajGridPopravke(string text)
        {
            List<Kvar> kvarovi = DomainModel.DataSet.Instace.vratiSveKvarove();

            gridPopravke.ColumnCount = 7;
            gridPopravke.Columns[0].Name = "Naziv";
            gridPopravke.Columns[1].Name = "Vreme Prijave";
            gridPopravke.Columns[2].Name = "Vreme Popravke";
            gridPopravke.Columns[3].Name = "Ocena";
            gridPopravke.Columns[4].Name = "Korisnik";
            gridPopravke.Columns[5].Name = "Radionica";
            gridPopravke.Columns[6].Name = "SifraKvara";
            gridPopravke.Columns[6].Visible = false;
            gridPopravke.Rows.Clear();
            if (kvarovi != null)
            {
                foreach (Kvar k in kvarovi)
                {
                    if (k != null)
                    {
                        if (text == null || k.naziv.Contains(text))
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
            }
        }

        public void ucitajGridNoviKvarovi(string text)
        {
            List<Kvar> kvarovi = DomainModel.DataSet.Instace.vratiSveKvarove();

            gridNoviKvarovi.ColumnCount = 7;
            gridNoviKvarovi.Columns[0].Name = "Naziv";
            gridNoviKvarovi.Columns[1].Name = "Vreme Prijave";
            gridNoviKvarovi.Columns[2].Name = "Vreme Popravke";
            gridNoviKvarovi.Columns[3].Name = "Ocena";
            gridNoviKvarovi.Columns[4].Name = "Korisnik";
            gridNoviKvarovi.Columns[5].Name = "Radionica";
            gridNoviKvarovi.Columns[6].Name = "SifraKvara";
            gridNoviKvarovi.Columns[6].Visible = false;
            gridNoviKvarovi.Rows.Clear();
            if (kvarovi != null)
            {
                foreach (Kvar k in kvarovi)
                {
                    if (k != null)
                    {
                        if ((text == null || k.naziv.Contains(text)) && k.Radionica == null)
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

        }

        public void ucitajGridRadionice(string text)
        { 
            List<Radionica> radionice = DomainModel.DataSet.Instace.vratiSveRadionice();
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
                        if (text == null || r.naziv.Contains(text))
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

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            ucitajGridNoviKvarovi(metroTextBox1.Text);
        }

        private void txtPretragaPopravke_TextChanged(object sender, EventArgs e)
        {
            ucitajGridPopravke(txtPretragaPopravke.Text);
        }

        private void txtPretragaRadionica_TextChanged(object sender, EventArgs e)
        {
            ucitajGridRadionice(txtPretragaRadionica.Text);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            List<Osoba> korisnici = DomainModel.DataSet.Instace.NadjiPrvihPetKorisnika(txtGrad.Text);
            if(korisnici != null)
            {
                ucitajGridKorisnici(korisnici);
            }
            else
            {
                MetroMessageBox.Show(this, "Greska", "Obavestenje");
            }

        }

        private void tabRadnici_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ucitajGridRadnici(DomainModel.DataSet.Instace.VratiPodatkeRadnikaKorisnikovihKvarova(txtRadionicaKontaktirajteRadnike.Text));
        }
    }
}
