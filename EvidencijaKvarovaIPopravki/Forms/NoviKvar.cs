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
        public NoviKvar()
        {
            InitializeComponent();
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
        }

        private void chkModel_CheckedChanged(object sender, EventArgs e)
        {
            PrikaziSakrij();
        }
    }
}
