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
    public partial class KvarPopravka : MetroFramework.Forms.MetroForm
    {
        public KvarPopravka()
        {
            InitializeComponent();
        }

        public KvarPopravka(Kvar k)
        {
            InitializeComponent();
            txtVremePrijave.Text = k.vremePrijaveKvara;
            txtVremePopravke.Text = k.vremeIspravkeKvara;
            txtModelVozila.Text = k.modelVozila;
            txtOcena.Text = k.ocena.ToString();
            gridKomentari.Rows.Clear();
            if (k.komentari != null)
            {
                foreach (string kom in k.komentari)
                {
                    gridKomentari.ColumnCount = 1;
                    gridKomentari.Columns[0].Name = "Komentar";
                    if (kom != null)
                        gridKomentari.Rows.Add(kom);
                }
            }
            gridSaveti.Rows.Clear();
            if (k.saveti != null)
            {
                foreach (string sav in k.saveti)
                {
                    gridSaveti.ColumnCount = 1;
                    gridSaveti.Columns[0].Name = "Savet";
                    if (sav != null)
                        gridKomentari.Rows.Add(sav);
                }
            }

        }
    }
}
