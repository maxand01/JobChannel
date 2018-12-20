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
            dtgOffre.DataSource = GetControleur.GetOffresByPoste(comboBoxPoste.SelectedValue.ToString());
        }
    }
}
