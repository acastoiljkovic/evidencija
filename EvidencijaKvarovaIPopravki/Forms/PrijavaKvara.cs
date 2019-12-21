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
            DomainModel.Kvar k1 = new DomainModel.Kvar();
            k1.naziv = txtNazivKvara.Text;
            k1.komentari.Add(txtKomentarKvar.Text);
            if (DomainModel.DataSet.Instace.dodajKvarKorisniku(k1))
            {
                MetroMessageBox.Show(this, "Uspesno dodat kvar !", "Obavestenje");
                this.Close();
            }
            else
                MetroMessageBox.Show(this, "Greska prilikom dodavanja kvara !", "Obavestenje");
        }
    }
}
