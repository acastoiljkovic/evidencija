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
    public partial class IzmeniProfil : MetroFramework.Forms.MetroForm
    {
        public IzmeniProfil()
        {
            InitializeComponent();
        }

        private void IzmeniProfil_Load(object sender, EventArgs e)
        {
            tbIme.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.ime;
            tbPrezime.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.prezime;
            tbEmail.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.authPodaci.email;
            tbTelefon.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.telefon;
            tbDatumRodjenja.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.datumRodjenja;
            tbGrad.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.Adresa.Grad;
            tbUlicaIBroj.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.Adresa.UlicaIBroj;
        }
    }
}
