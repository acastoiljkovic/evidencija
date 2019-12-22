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
        Radionica r;

        public RadionicaPrikaz()
        {
            InitializeComponent();
        }

        public RadionicaPrikaz(Radionica rad)
        {
            InitializeComponent();
            r = rad;

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

            if(DomainModel.DataSet.Instace.DaLiJeToRadnikovaRadionica(r.naziv))
            {
                btnIzmeniRadionicu.Visible = true;
            }
            else
            {
                btnIzmeniRadionicu.Visible = false;
            }
        }

        private void btnDelovi_Click(object sender, EventArgs e)
        {
            var Forma = new DostupniDelovi();
            Forma.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var Forma = new IzmeniRadionicu(r);
            Forma.ShowDialog();
        }
    }
}
