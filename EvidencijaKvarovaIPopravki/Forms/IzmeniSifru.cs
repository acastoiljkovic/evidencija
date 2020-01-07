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
    public partial class IzmeniSifru : MetroFramework.Forms.MetroForm
    {
        public IzmeniSifru()
        {
            InitializeComponent();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, DomainModel.DataSet.Instace.IzmenaSifre(txtPostojeca.Text, txtNova.Text, txtPotvrdaNove.Text), "Obavestenje");
        }
    }
}
