using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if(DomainModel.DataSet.Instace.PrijavljenKorisnik != null)
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
            gridPopravkeKorisnika.DataSource = DomainModel.DataSet.Instace.PrijavljenKorisnik.kvarovi;
        }

        private void PrikaziSakrij()
        {
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
    }
}
