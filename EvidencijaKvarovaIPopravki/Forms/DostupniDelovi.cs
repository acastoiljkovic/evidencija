﻿using System;
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
    public partial class DostupniDelovi : MetroFramework.Forms.MetroForm
    {
        public DostupniDelovi()
        {
            InitializeComponent();
        }

        private void btnDodajDeo_Click(object sender, EventArgs e)
        {
            var Forma = new DodajDeo();
            Forma.ShowDialog();
        }
    }
}
