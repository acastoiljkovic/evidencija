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
                txtIme.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.ime;
                txtPrezime.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.prezime;
                txtTelefon.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.telefon;
                txtDatum.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.datumRodjenja;
                txtGrad.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.Adresa.Grad;
                txtUlicaIBroj.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.Adresa.UlicaIBroj;
                txtEmail.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.authPodaci.email;
            }
            // TODO: dodaj popravke koje je korisnik imao do sada
        }
    }
}
