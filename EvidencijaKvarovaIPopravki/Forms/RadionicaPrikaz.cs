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

            if(DomainModel.DataSet.Instace.DaLiJeToRadnikovaRadionica(r.naziv))
            {
                btnIzmeniRadionicu.Visible = true;
            }
            else
            {
                btnIzmeniRadionicu.Visible = false;
            }
            List<Kvar> kvarovi = DomainModel.DataSet.Instace.vratiSveKvarove();

            gridPopravkeRadionice.ColumnCount = 7;
            gridPopravkeRadionice.Columns[0].Name = "Naziv";
            gridPopravkeRadionice.Columns[1].Name = "Vreme Prijave";
            gridPopravkeRadionice.Columns[2].Name = "Vreme Popravke";
            gridPopravkeRadionice.Columns[3].Name = "Ocena";
            gridPopravkeRadionice.Columns[4].Name = "Korisnik";
            gridPopravkeRadionice.Columns[5].Name = "Radionica";
            gridPopravkeRadionice.Columns[6].Name = "SifraKvara";
            //gridPopravkeRadionice.Columns[6].Visible = false;
            gridPopravkeRadionice.Rows.Clear();
            if (kvarovi != null)
            {
                foreach (Kvar k in kvarovi)
                {
                    if (k != null && k.Radionica != null && k.Radionica.naziv == r.naziv)
                    {
                        string[] row = new string[7];
                        if (k.naziv != null)
                            row[0] = k.naziv;
                        else
                            row[0] = "";
                        if (k.vremePrijaveKvara != null)
                            row[1] = k.vremePrijaveKvara;
                        else
                            row[1] = "";
                        if (k.vremeIspravkeKvara != null)
                            row[2] = k.vremeIspravkeKvara;
                        else
                            row[2] = "";
                        if (k.ocena != null)
                            row[3] = k.ocena.ToString();
                        else
                            row[3] = "";
                        if (k.Korisnik != null)
                            row[4] = k.Korisnik.podaci.ime + " " + k.Korisnik.podaci.prezime;
                        else
                            row[4] = "";
                        if (k.Radionica != null)
                            row[5] = k.Radionica.naziv;
                        else
                            row[5] = "";
                        if (k.sifraKvara != null)
                            row[6] = k.sifraKvara;
                        else
                            row[6] = "";


                        gridPopravkeRadionice.Rows.Add(row);
                    }
                }
            }


            List<Osoba> radnici = DomainModel.DataSet.Instace.vratiSveRadnikeRadionice(r);
            gridZaposleniRadionica.ColumnCount = 5;
            gridZaposleniRadionica.Columns[0].Name = "Ime";
            gridZaposleniRadionica.Columns[1].Name = "Prezime";
            gridZaposleniRadionica.Columns[2].Name = "Email";
            gridZaposleniRadionica.Columns[3].Name = "Telefon";
            gridZaposleniRadionica.Columns[4].Name = "Adresa";
            gridZaposleniRadionica.Rows.Clear();
            if (radnici != null)
            {
                foreach (Osoba o in radnici)
                {
                    string[] row = new string[5];
                    if (o.podaci.ime != null)
                        row[0] = o.podaci.ime;
                    if (o.podaci.prezime != null)
                        row[1] = o.podaci.prezime;
                    if (o.authPodaci.email != null)
                        row[2] = o.authPodaci.email;
                    if (o.podaci.telefon != null)
                        row[3] = o.podaci.telefon;
                    if (o.podaci.Adresa.Grad != null && o.podaci.Adresa.UlicaIBroj != null)
                        row[4] = o.podaci.Adresa.UlicaIBroj + " "+ o.podaci.Adresa.Grad;
                    gridZaposleniRadionica.Rows.Add(row);

                }
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
