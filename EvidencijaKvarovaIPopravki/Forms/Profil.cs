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
    public partial class Profil : MetroFramework.Forms.MetroForm
    {
        public Profil()
        {
            InitializeComponent();
        }

        private void Profil_Load(object sender, EventArgs e)
        {

            if (DomainModel.DataSet.Instace.PrijavljenKorisnik != null)
            {
                //ne bi trebalo da dodje do ove forme ako je null
                PrikaziSakrij();

                txtIme.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.ime;
                txtPrezime.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.prezime;
                txtTelefon.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.telefon;
                txtDatum.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.datumRodjenja;
                txtGrad.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.Adresa.Grad;
                txtUlicaIBroj.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.Adresa.UlicaIBroj;
                txtEmail.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.authPodaci.email;
            }
            if (DomainModel.DataSet.Instace.PrijavljenKorisnik.kvarovi != null)
            {
                gridPopravkeKorisnika.ColumnCount = 7;
                gridPopravkeKorisnika.Columns[0].Name = "Naziv";
                gridPopravkeKorisnika.Columns[1].Name = "Vreme Prijave";
                gridPopravkeKorisnika.Columns[2].Name = "Vreme Popravke";
                gridPopravkeKorisnika.Columns[3].Name = "Ocena";
                gridPopravkeKorisnika.Columns[4].Name = "Korisnik";
                gridPopravkeKorisnika.Columns[5].Name = "Radionica";
                gridPopravkeKorisnika.Columns[6].Name = "SifraKvara";
                gridPopravkeKorisnika.Columns[6].Visible = false;
                gridPopravkeKorisnika.Rows.Clear();
                foreach (Kvar k in DomainModel.DataSet.Instace.PrijavljenKorisnik.kvarovi)
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


                        gridPopravkeKorisnika.Rows.Add(row);
                    }

                }
            }
        }
        

        private void PrikaziSakrij()
        {
            DomainModel.DataSet.Instace.prijavaKorisnika(DomainModel.DataSet.Instace.PrijavljenKorisnik);
            if (DomainModel.DataSet.Instace.PrijavljenKorisnik.indikator.Equals("zaposleni"))
            {
                slikaRadionica.Visible = true;
                lblRadionica.Visible = true;
                txtRadionica.Visible = true;
                if (DomainModel.DataSet.Instace.vratiRadionicuRadnik(DomainModel.DataSet.Instace.PrijavljenKorisnik) != null)
                    txtRadionica.Text = DomainModel.DataSet.Instace.vratiRadionicuRadnik(DomainModel.DataSet.Instace.PrijavljenKorisnik).naziv;
            }
            else
            {
                slikaRadionica.Visible = false;
                lblRadionica.Visible = false;
                txtRadionica.Visible = false;
            }
        }

        private void btnIzmeniProfil_Click(object sender, EventArgs e)
        {
            var Forma = new IzmeniProfil();
            Forma.ShowDialog();
        }

        private void btnIzmeniSifru_Click(object sender, EventArgs e)
        {
            var Forma = new IzmeniSifru();
            Forma.ShowDialog();
        }

        private void gridPopravkeKorisnika_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "\n\nDa li sigurno zelite da obrisete kvar?", "BRISANJE KVARA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (DomainModel.DataSet.Instace.obrisiKvarSifra(gridPopravkeKorisnika.Rows[e.RowIndex].Cells[6].Value.ToString()))
                {
                    MetroMessageBox.Show(this, "\nUspesno obrisan kvar!", "Obavestenje");
                    this.Close();
                }
                else
                {
                    MetroMessageBox.Show(this, "\nGreska prilikom brisanja kvara!", "Obavestenje");
                    this.Close();
                }
            }
        }
    }
}
