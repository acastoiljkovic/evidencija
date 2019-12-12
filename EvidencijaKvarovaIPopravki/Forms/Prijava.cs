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
    public partial class Prijava : MetroFramework.Forms.MetroForm
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            // TODO: Add login
            MessageBox.Show(DomainModel.DataSet.Instace.prijavaKorisnika(new DomainModel.Osoba()
            {
                authPodaci = new DomainModel.Autentifikacija()
                {
                    email = txtKorisnickoIme.Text,
                    korisnickoIme = txtKorisnickoIme.Text,
                    sifra = txtLozinka.Text
                }
            }
            )
            );
            if (DomainModel.DataSet.Instace.PrijavljenKorisnik != null)
                this.Close();
        }
    }
}
