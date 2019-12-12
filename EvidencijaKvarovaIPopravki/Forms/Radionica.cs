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
    public partial class Radionica : MetroFramework.Forms.MetroForm
    {
        public Radionica()
        {
            InitializeComponent();
        }

        private void btnDelovi_Click(object sender, EventArgs e)
        {
            var Forma = new DostupniDelovi();
            Forma.ShowDialog();
        }
    }
}
