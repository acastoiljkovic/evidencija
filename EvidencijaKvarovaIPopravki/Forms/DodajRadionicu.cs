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
    public partial class DodajRadionicu : MetroFramework.Forms.MetroForm
    {
        public DodajRadionicu()
        {
            InitializeComponent();
        }

        private void btnDodajPopravku_Click(object sender, EventArgs e)
        {
            var Forma = new NoviKvar();
            Forma.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string provera = DomainModel.DataSet.Instace.proveriDaLiPostojiRadionica(txtNazivRadionice.Text);
            if (provera.Equals("Provera uspesno prosla!"))
                if (
                        DomainModel.DataSet.Instace.dodajRadionicu(new Radionica()
                        {
                            Adresa = new Adresa()
                            {
                                Grad = txtGrad.Text,
                                UlicaIBroj = txtUlicaIBroj.Text
                            },
                            naziv = txtNazivRadionice.Text,
                            Delovi = null,
                            Kvarovi = null,
                            Zaposleni = null

                        }))
                {
                    MetroMessageBox.Show(this, "Uspesno dodata radionica!", "Obavestenje");
                    this.Close();
                }
                else
                    MetroMessageBox.Show(this, "Neuspesno dodavanje radionice!", "Obavestenje");
            else
                MetroMessageBox.Show(this, provera, "Obavestenje");

        }
    }
}
