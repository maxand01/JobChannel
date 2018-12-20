using BLLJobChannel;
using BOJobChannel;
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
    public partial class Edition : Form
    {
        public Controleur GetControleur { get; set; }
        public Edition()
        {
            InitializeComponent();
            GetControleur = new Controleur();
        }

        private void Edition_Load(object sender, EventArgs e)
        {

            bindingSourceTypeContrat.DataSource = GetControleur.GetAllTypeContrats();
            comboBoxContrat.DataSource = bindingSourceTypeContrat;
            comboBoxContrat.DisplayMember = "NomTypeContrat";
            comboBoxContrat.ValueMember = "IDTypeContrat";

            bindingSourceOffre.DataSource = GetControleur.GetAllOffres();
            comboBoxDate.DataSource = bindingSourceOffre;
            comboBoxDate.DisplayMember = "DateOffre";
            comboBoxDate.ValueMember = "IDOffre";

            bindingSourceEntreprise.DataSource = GetControleur.GetAllEntreprises();
            comboBoxEntreprise.DataSource = bindingSourceEntreprise;
            comboBoxEntreprise.DisplayMember = "NomEntreprise";
            comboBoxEntreprise.ValueMember = "IDEntreprise";

            comboBoxLienWeb.DataSource = bindingSourceOffre;
            comboBoxLienWeb.DisplayMember = "LienWeb";
            comboBoxLienWeb.ValueMember = "IDOffre";

            bindingSourceTypePoste.DataSource = GetControleur.GetAllTypePostes();
            comboBoxPoste.DataSource = bindingSourceTypePoste;
            comboBoxPoste.DisplayMember = "NomPoste";
            comboBoxPoste.ValueMember = "IDTypePoste";

            bindingSourceRegion.DataSource = GetControleur.GetAllRegions();
            comboBoxRegion.DataSource = bindingSourceRegion;
            comboBoxRegion.DisplayMember = "NomRegion";
            comboBoxRegion.ValueMember = "IDRegion";

            comboBoxTitre.DataSource = bindingSourceOffre;
            comboBoxTitre.DisplayMember = "TitreOffre";
            comboBoxTitre.ValueMember = "IDOffre";

            LoadDataGrid();
        }

       

        private void LoadDataGrid()
        {
            bindingSourceDtg.DataSource = GetControleur.GetAll();
            dtgOffre.DataSource = bindingSourceDtg;
            dtgOffre.Columns["IDOffre"].Visible = false;
            dtgOffre.Columns["IDEntreprise"].Visible = false;
            dtgOffre.Columns["IDRegion"].Visible = false;
            dtgOffre.Columns["IDTypeContrat"].Visible = false;
            dtgOffre.Columns["IDTypePoste"].Visible = false;
            //dtgOffre.Columns["TypeContrat"].HeaderText = "Test";

        }

        private void bindingSourceDtg_CurrentChanged(object sender, EventArgs e)
        {
            Offre offreCourante = (Offre)bindingSourceDtg.Current;
            richTextBoxDesc.Text = offreCourante.DescriptionOffre;
            comboBoxContrat.SelectedValue = offreCourante.IDTypeContrat;
            comboBoxEntreprise.SelectedValue = offreCourante.IDEntreprise;
            comboBoxDate.SelectedValue = offreCourante.IDOffre;
            comboBoxLienWeb.SelectedValue = offreCourante.IDOffre;
            comboBoxRegion.SelectedValue = offreCourante.IDRegion;
            comboBoxPoste.SelectedValue = offreCourante.IDTypePoste;
        }

        private void buttonMajOffre_Click(object sender, EventArgs e)
        {
            Offre offreCourante = (Offre)bindingSourceDtg.Current;
            offreCourante.DescriptionOffre = richTextBoxDesc.Text;
            offreCourante.IDTypeContrat = (int)comboBoxContrat.SelectedValue;
            offreCourante.IDEntreprise = (int)comboBoxEntreprise.SelectedValue;
            offreCourante.LienWeb = comboBoxLienWeb.Text;
            offreCourante.IDRegion = (int)comboBoxRegion.SelectedValue;
            offreCourante.IDTypePoste = (int)comboBoxPoste.SelectedValue;
            offreCourante.TitreOffre = comboBoxTitre.Text;
            offreCourante.DateOffre =Convert.ToDateTime(comboBoxDate.Text).ToString("dd/MM/yyyy");
            int nbLignes = GetControleur.UpdateOffre(offreCourante);

            labelResultatMaj.Text = nbLignes + "ligne(s) mise à jour";
            LoadDataGrid();
        }

        private void buttonReinit_Click(object sender, EventArgs e)
        {
            comboBoxContrat.SelectedItem = null;
            comboBoxDate.SelectedItem = null;
            comboBoxEntreprise.SelectedItem = null;
            comboBoxLienWeb.SelectedItem = null;
            comboBoxPoste.SelectedItem = null;
            comboBoxRegion.SelectedItem = null;
            comboBoxTitre.SelectedItem = null;
            richTextBoxDesc.Text = null;
            buttonMajOffre.Enabled = false;
        }

        private void buttonnAddOffre_Click(object sender, EventArgs e)
        {
            Offre offreCourante = new Offre();
            offreCourante.DescriptionOffre = richTextBoxDesc.Text;
            offreCourante.IDTypeContrat = (int)comboBoxContrat.SelectedValue;
            offreCourante.IDEntreprise = (int)comboBoxEntreprise.SelectedValue;
            offreCourante.LienWeb = comboBoxLienWeb.Text;
            offreCourante.IDRegion = (int)comboBoxRegion.SelectedValue;
            offreCourante.IDTypePoste = (int)comboBoxPoste.SelectedValue;
            offreCourante.TitreOffre = comboBoxTitre.Text;
            offreCourante.DateOffre = Convert.ToDateTime(comboBoxDate.Text).ToString("dd/MM/yyyy");
            int nbLignes = GetControleur.AddOffre(offreCourante);

            labelResultatMaj.Text = nbLignes + "ligne(s) mise à jour";

            LoadDataGrid();
        }
    }
}
