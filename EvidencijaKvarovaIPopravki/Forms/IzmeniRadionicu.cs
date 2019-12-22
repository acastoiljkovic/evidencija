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
    public partial class IzmeniRadionicu : MetroFramework.Forms.MetroForm
    {
        Radionica radionica;

        public IzmeniRadionicu()
        {
            InitializeComponent();
        }

        public IzmeniRadionicu(Radionica r)
        {
            InitializeComponent();
            radionica = r;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, DomainModel.DataSet.Instace.izmeniRadionicu(radionica.naziv, txtNaziv.Text, txtGrad.Text, txtUlica.Text), "Obavestenje");
        }

        private void IzmeniRadionicu_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = radionica.naziv;
            txtGrad.Text = radionica.Adresa.Grad;
            txtUlica.Text = radionica.Adresa.UlicaIBroj;
        }
    }
}
