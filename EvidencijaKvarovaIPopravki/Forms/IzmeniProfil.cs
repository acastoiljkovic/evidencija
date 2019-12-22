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
    public partial class IzmeniProfil : MetroFramework.Forms.MetroForm
    {
        public IzmeniProfil()
        {
            InitializeComponent();
        }

        private void IzmeniProfil_Load(object sender, EventArgs e)
        {
            PrikaziSakrij();

            tbIme.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.ime;
            tbPrezime.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.prezime;
            tbEmail.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.authPodaci.email;
            tbTelefon.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.telefon;
            tbDatumRodjenja.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.datumRodjenja;
            tbGrad.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.Adresa.Grad;
            tbUlicaIBroj.Text = DomainModel.DataSet.Instace.PrijavljenKorisnik.podaci.Adresa.UlicaIBroj;
            if(DomainModel.DataSet.Instace.PrijavljenKorisnik.indikator.Equals("zaposleni"))
            {
                Radionica radnikovaRadionica = DomainModel.DataSet.Instace.vratiRadionicuRadnik(DomainModel.DataSet.Instace.PrijavljenKorisnik);
                comboRadionica.Items.Clear();
                for(int i = 0; i < DomainModel.DataSet.Instace.vratiSveRadionice().Count; i++)
                {

                }
                foreach (Radionica r in DomainModel.DataSet.Instace.vratiSveRadionice())
                {
                    comboRadionica.Items.Add(r.naziv);
                    if (r.naziv.Equals(radnikovaRadionica.naziv))
                    {
                        comboRadionica.SelectedItem = r.naziv;
                    }
                        
                        
                }
            }
                
        }

        private void PrikaziSakrij()
        {
            if(DomainModel.DataSet.Instace.PrijavljenKorisnik != null)
            {
                if (DomainModel.DataSet.Instace.PrijavljenKorisnik.indikator.Equals("zaposleni"))
                {
                    lblRadionica.Visible = true;
                    slikaRadionica.Visible = true;
                    comboRadionica.Visible = true;
                }
                else
                {
                    lblRadionica.Visible = false;
                    slikaRadionica.Visible = false;
                    comboRadionica.Visible = false;
                }
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, DomainModel.DataSet.Instace.IzmeniKorisnikovProfil(tbIme.Text, tbPrezime.Text, tbEmail.Text, tbTelefon.Text, tbDatumRodjenja.Text, tbGrad.Text, tbUlicaIBroj.Text, comboRadionica.SelectedItem.ToString()), "Obavestenje");
            this.Close();
        }
    }
}
