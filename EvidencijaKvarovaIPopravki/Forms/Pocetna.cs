﻿using System;
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
    public partial class Pocetna : MetroFramework.Forms.MetroForm
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void btnDodajKvar_Click(object sender, EventArgs e)
        {
            var Forma = new NoviKvar();
            Forma.ShowDialog();
        }

        private void btnKreirajNalog_Click(object sender, EventArgs e)
        {
            var Forma = new Registracija();
            Forma.ShowDialog();
            PrikaziSakrij();
        }

        //btnProfil
        private void metroButton1_Click(object sender, EventArgs e)
        {
            var Forma = new Profil();
            Forma.ShowDialog();
        }

        private void btnUlogujSe_Click(object sender, EventArgs e)
        {
            var Forma = new Prijava();
            Forma.ShowDialog();
            PrikaziSakrij();
        }

        private void PrikaziSakrij()
        {
            gridPopravke.Columns[0].Visible = false;
            if (DomainModel.DataSet.Instace.PrijavljenKorisnik != null)
            {
                btnKreirajNalog.Visible = false;
                btnUlogujSe.Visible = false;
                btnOdjaviSe.Visible = true;
                btnProfil.Visible = true;
            }
            else
            {
                btnKreirajNalog.Visible = true;
                btnUlogujSe.Visible = true;
                btnOdjaviSe.Visible = false;
                btnProfil.Visible = false;
            }
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            PrikaziSakrij();
            metroTabControl1.SelectedTab = TabPopravke;
            //foreach(Kvar k in DomainModel.DataSet.Instace.vratiSveKvarove())
            //{
            //    DataGridViewRow rw = (DataGridViewRow)gridPopravke.Rows[0].Clone();
            //    rw.Cells[0].Value = k.naziv;
            //    gridPopravke.Rows.Add(rw);
            //}
            gridPopravke.DataSource = DomainModel.DataSet.Instace.vratiSveKvarove();
            gridRadionice.DataSource = DomainModel.DataSet.Instace.vratiSveRadionice();
        }

        private void btnPopravka_Click(object sender, EventArgs e)
        {
            var Forma = new KvarPopravka();
            Forma.ShowDialog();
        }

        private void btnDelovi_Click(object sender, EventArgs e)
        {
            var Forma = new DostupniDelovi();
            Forma.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //foreach(Kvar k in DomainModel.DataSet.Instace.GetKorisnik(92).kvarovi)
            //{
            //    MessageBox.Show(k.Radionica.ToString());
            //}

            //MessageBox.Show(DomainModel.DataSet.Instace.GetKorisnik(92).kvarovi[0].ToString());
            //MessageBox.Show(DomainModel.DataSet.Instace.GetKorisnik(92).ToString());

            if (
            //DomainModel.DataSet.Instace.dodajLicnePodatke
            //    ( new LicniPodaci() {
            //        Adresa = new Adresa() { Grad = "Nis", UlicaIBroj = "MIlojka Radovica 12", id = Guid.NewGuid() },
            //        ime = "Nikola",
            //        prezime = "Nikolic",
            //        datumRodjenja = "5.2.1999",
            //        telefon = "018/123-551"
            //    })
            DomainModel.DataSet.Instace.dodajAutentifikaciju(new Autentifikacija() { 
                email="mail@mail",
                korisnickoIme = "korisnik1",
                sifra="asd"
            })
                )
                MessageBox.Show("Uspesno dodata autentifikacija");
            else
                MessageBox.Show("Neuspesno dodati podaci");

        }

        private void btnRadionica_Click(object sender, EventArgs e)
        {
            var Forma = new RadionicaPrikaz();
            Forma.ShowDialog();
        }

        private void btnPrijaviKvar_Click(object sender, EventArgs e)
        {
            var Forma = new PrijavaKvara();
            Forma.ShowDialog();
        }

        private void gridPopravke_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            DomainModel.DataSet.Instace.PrijavljenKorisnik = null;
            PrikaziSakrij();
        }

        private void gridPopravke_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Forma = new KvarPopravka((Kvar)gridPopravke.Rows[e.RowIndex].DataBoundItem);
            Forma.ShowDialog();
        }

        private void gridRadionice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Forma = new RadionicaPrikaz((Radionica)gridRadionice.Rows[e.RowIndex].DataBoundItem);
            Forma.ShowDialog();
        }
    }
}
