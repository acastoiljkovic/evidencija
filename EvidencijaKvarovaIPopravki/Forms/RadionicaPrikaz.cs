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
    public partial class RadionicaPrikaz : MetroFramework.Forms.MetroForm
    {
        public RadionicaPrikaz()
        {
            InitializeComponent();
        }

        public RadionicaPrikaz(Radionica r)
        {
            InitializeComponent();
            lblNazivRadionice.Text = r.naziv;

            txtGrad.Text = r.Adresa.Grad;
            txtUlicaIBroj.Text = r.Adresa.UlicaIBroj;

            if (r.Kvarovi != null)
            {
                gridPopravkeRadionice.DataSource = r.Kvarovi;
            }
            if (r.Zaposleni != null)
            {
                gridZaposleniRadionica.DataSource = r.Zaposleni;
            }
        }

        private void btnDelovi_Click(object sender, EventArgs e)
        {
            var Forma = new DostupniDelovi();
            Forma.ShowDialog();
        }
    }
}
