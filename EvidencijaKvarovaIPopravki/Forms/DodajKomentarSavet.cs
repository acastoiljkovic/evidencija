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
    public partial class DodajKomentarSavet : MetroFramework.Forms.MetroForm
    {
        Kvar k;

        public DodajKomentarSavet()
        {
            InitializeComponent();
        }

        public DodajKomentarSavet(Kvar kv)
        {
            InitializeComponent();
            k = kv;
            txtNazivKvara.Text = k.naziv;
        }

        private void DodajKomentarSavet_Activated(object sender, EventArgs e)
        {
            Prilagodi();
        }

        private void Prilagodi()
        {
            if (DomainModel.DataSet.Instace.PrijavljenKorisnik != null)
            {
                if (DomainModel.DataSet.Instace.PrijavljenKorisnik.indikator.Equals("zaposleni"))
                {
                    lblNaslov.Text = "Dodaj savet";
                    lblKomentarSavet.Text = "Savet:";
                }
                else
                {
                    lblNaslov.Text = "Dodaj komentar";
                    lblKomentarSavet.Text = "Komentar:";
                }
            }
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            if(DomainModel.DataSet.Instace.PrijavljenKorisnik != null)
            {
                if(DomainModel.DataSet.Instace.PrijavljenKorisnik.indikator.Equals("zaposleni"))
                {
                    k.komentari.Add(txtKomentarSavet.Text);
                    if(DomainModel.DataSet.Instace.dodajKomentarSavet(k))
                        MetroMessageBox.Show(this, "Uspesno!", "Obavestenje");
                }
                else
                {
                    k.saveti.Add(txtKomentarSavet.Text);
                    if (DomainModel.DataSet.Instace.dodajKomentarSavet(k))
                        MetroMessageBox.Show(this, "Uspesno!", "Obavestenje");
                         
                }
            }
            this.Close();
        }
    }
}
