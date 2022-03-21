using DapperLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EindogaveDapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Campus> campuses = OpleidingenService.GetCampuses();
            foreach (Campus c in campuses)
            {
                cmbCampussen.Items.Add(c);
            }
        }
        private void cmbCampussen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetListOfDocenten();
        }
        private void ResetListOfDocenten()
        {
            lstDocenten.Items.Clear();
            List<Docent> docents = OpleidingenService.GetDocentsByCampus(cmbCampussen.SelectedIndex + 1);
            foreach (Docent d in docents)
            {
                lstDocenten.Items.Add(d);
            }
        }
        private void lstDocenten_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblDocentNaam.Visible = true;
            lblFamilieNaam.Visible = true;
            lblWedde.Visible = true;

            int count = 0;
            int selected = lstDocenten.SelectedIndex + 1;
            IEnumerable<Docent> employees = OpleidingenService.GetDocentsByCampus(cmbCampussen.SelectedIndex + 1).ToList();

            foreach (var Docent in employees)
            {
                count++;
                if (count == selected)
                {
                    lblDocentNaam.Text = Docent.Voornaam;
                    lblFamilieNaam.Text = Docent.Familienaam;
                    lblWedde.Text = Docent.Wedde.ToString();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Docent docent = new Docent();
            docent.Voornaam = txtVoornaam.Text;
            docent.Familienaam = txtFamilienaam.Text;
            docent.Wedde =Convert.ToDouble( txtWedde.Text);
            docent.CampusNr = cmbCampussen.SelectedIndex + 1;
            OpleidingenService.AddDocent(docent);
            ResetListOfDocenten();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            int count = 0;
            int selected = lstDocenten.SelectedIndex + 1;
            IEnumerable<Docent> employees = OpleidingenService.GetDocentsByCampus(cmbCampussen.SelectedIndex + 1).ToList();
            int Id = 0;
            foreach (var Docent in employees)
            {
                count++;
                if (count == selected)
                {
                    Id = Docent.DocentNr;
                }
            }
            OpleidingenService.DelDocent(Id);
            ResetListOfDocenten();
        }
    }
}
