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
    public partial class PrijavaKvara : MetroFramework.Forms.MetroForm
    {
        public PrijavaKvara()
        {
            InitializeComponent();
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            Kvar k1 = new Kvar();
            k1.naziv = txtNazivKvara.Text;
            k1.komentari.Add(txtKomentarKvar.Text);
            if(comboBoxRadionica.SelectedItem != null && comboBoxRadionica.SelectedItem.ToString() != "Bez Radionice")
                k1.Radionica = DomainModel.DataSet.Instace.vratiRadionicuNaziv(comboBoxRadionica.SelectedItem.ToString());
            if (DomainModel.DataSet.Instace.dodajKvarKorisnikuRadionici(k1))
            {
                MetroMessageBox.Show(this, "Uspesno dodat kvar !", "Obavestenje");
                this.Close();
            }
            else
                MetroMessageBox.Show(this, "Greska prilikom dodavanja kvara !", "Obavestenje");
        }

        private void PrijavaKvara_Load(object sender, EventArgs e)
        {

        }

        private void PrijavaKvara_Activated(object sender, EventArgs e)
        {
            comboBoxRadionica.Items.Clear();
            comboBoxRadionica.Items.Add("Bez Radionice");
            foreach (Radionica r in DomainModel.DataSet.Instace.vratiSveRadionice())
            {
                comboBoxRadionica.Items.Add(r.naziv);
            }
        }
    }
}
