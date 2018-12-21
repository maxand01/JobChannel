using BLLJobChannel;
using DALJobChannel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHMJobChannel
{
    public partial class Consultation : Form
    {
        public Controleur GetControleur { get; set; }

        public Consultation()
        {
            InitializeComponent();
            GetControleur = new Controleur();
        }

        private void Consultation_Load(object sender, EventArgs e)
        {

            bindingSourceOffre.DataSource = GetControleur.GetAll();
            dtgOffre.DataSource = bindingSourceOffre;

            dtgOffre.Columns["IDOffre"].Visible = false;
            dtgOffre.Columns["IDEntreprise"].Visible = false;
            dtgOffre.Columns["IDRegion"].Visible = false;
            dtgOffre.Columns["IDTypeContrat"].Visible = false;
            dtgOffre.Columns["IDTypePoste"].Visible = false;

            bindingSourcePoste.DataSource = GetControleur.GetAllTypePostes();
            comboBoxPoste.DataSource = bindingSourcePoste;
            comboBoxPoste.DisplayMember = "NomPoste";
            comboBoxPoste.ValueMember = "IDTypePoste";

            bindingSourceContrat.DataSource = GetControleur.GetAllTypeContrats();
            comboBoxContrat.DataSource = bindingSourceContrat;
            comboBoxContrat.DisplayMember = "NomTypeContrat";
            comboBoxContrat.ValueMember = "IDTypeContrat";

            bindingSourceEntreprise.DataSource = GetControleur.GetAllEntreprises();
            comboBoxEntreprise.DataSource = bindingSourceEntreprise;
            comboBoxEntreprise.DisplayMember = "NomEntreprise";
            comboBoxEntreprise.ValueMember = "IDEntreprise";

            bindingSourceRegion.DataSource = GetControleur.GetAllRegions();
            comboBoxRegion.DataSource = bindingSourceRegion;
            comboBoxRegion.DisplayMember = "NomRegion";
            comboBoxRegion.ValueMember = "IDRegion";

        }

        private void comboBoxPoste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPoste.SelectedValue != null && comboBoxPoste.SelectedValue is int)
            {
                dtgOffre.DataSource = GetControleur.GetOffresByPoste(comboBoxPoste.SelectedValue.ToString());
            }
        }

        private void comboBoxContrat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxContrat.SelectedValue != null && comboBoxContrat.SelectedValue is int)
            {
                dtgOffre.DataSource = GetControleur.GetOffresByContrat(comboBoxContrat.SelectedValue.ToString());
            }
        }

        private void comboBoxEntreprise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxEntreprise.SelectedValue != null && comboBoxEntreprise.SelectedValue is int)
            {
                dtgOffre.DataSource = GetControleur.GetOffresByEntreprise(comboBoxEntreprise.SelectedValue.ToString());
            }

        }

        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRegion.SelectedValue != null && comboBoxRegion.SelectedValue is int)
            {
                dtgOffre.DataSource = GetControleur.GetOffresByRegion(comboBoxRegion.SelectedValue.ToString());

            }

        }
    }
}
