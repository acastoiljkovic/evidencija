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

namespace EvidencijaKvarovaIPopravki.Forms
{
    public partial class NoviKvar : MetroFramework.Forms.MetroForm
    {
        Kvar kvar;
        public NoviKvar()
        {
            InitializeComponent();
        }

        public NoviKvar(Kvar k)
        {
            InitializeComponent();
            this.kvar = k;
        }
        private void chkRadnici_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNazivRadnika_Click(object sender, EventArgs e)
        {

        }

        private void NoviKvar_Load(object sender, EventArgs e)
        {
            chkModel.Checked = false;

            PrikaziSakrij();
        }

        private void PrikaziSakrij()
        {
            if(!chkModel.Checked)
            {
                lblNazivModela.Visible = false;
                txtNazivModela.Visible = false;
            }
            else
            {
                lblNazivModela.Visible = true;
                txtNazivModela.Visible = true;
            }
            if(kvar != null)
            {
                txtNazivKvara.Text = kvar.naziv;
                txtSifraKvara.Text = kvar.sifraKvara;
                txtPredvidjenoVreme.Text = kvar.komentari[0];
            }
        }

        private void chkModel_CheckedChanged(object sender, EventArgs e)
        {
            PrikaziSakrij();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {

        }
    }
}
