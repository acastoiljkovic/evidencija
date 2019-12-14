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
        }
    }
}
