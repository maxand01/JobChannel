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
            LoadComboBox();
            LoadDataGrid();
            toolTipEdition.SetToolTip(buttonAddOffre, "Ajouter une offre");
            toolTipEdition.SetToolTip(buttonAddPoste, "Ajouter un type de poste");
            toolTipEdition.SetToolTip(buttonAjoutEntreprise, "Ajouter une entreprise");
            toolTipEdition.SetToolTip(buttonAddContrat, "Ajouter un contrat");
            toolTipEdition.SetToolTip(buttonDeleteOffre, "Supprimer une offre");
            toolTipEdition.SetToolTip(buttonMajOffre, "Mettra à jour l'offre");
            toolTipEdition.SetToolTip(buttonReinit, "Initialiser les champs");
        }


        private void LoadComboBox()
        {
            bindingSourceTypeContrat.DataSource = GetControleur.GetAllTypeContrats();
            comboBoxContrat.DataSource = bindingSourceTypeContrat;
            comboBoxContrat.DisplayMember = "NomTypeContrat";
            comboBoxContrat.ValueMember = "IDTypeContrat";

            bindingSourceEntreprise.DataSource = GetControleur.GetAllEntreprises();
            comboBoxEntreprise.DataSource = bindingSourceEntreprise;
            comboBoxEntreprise.DisplayMember = "NomEntreprise";
            comboBoxEntreprise.ValueMember = "IDEntreprise";

            bindingSourceTypePoste.DataSource = GetControleur.GetAllTypePostes();
            comboBoxPoste.DataSource = bindingSourceTypePoste;
            comboBoxPoste.DisplayMember = "NomPoste";
            comboBoxPoste.ValueMember = "IDTypePoste";

            bindingSourceRegion.DataSource = GetControleur.GetAllRegions();
            comboBoxRegion.DataSource = bindingSourceRegion;
            comboBoxRegion.DisplayMember = "NomRegion";
            comboBoxRegion.ValueMember = "IDRegion";

            bindingSourceOffre.DataSource = GetControleur.GetAllOffres();
            comboBoxTitre.DataSource = bindingSourceOffre;
            comboBoxTitre.DisplayMember = "TitreOffre";
            comboBoxTitre.ValueMember = "IDOffre";
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
            comboBoxRegion.SelectedValue = offreCourante.IDRegion;
            comboBoxPoste.SelectedValue = offreCourante.IDTypePoste;
            textBoxLienWeb.Text = offreCourante.LienWeb;
            dtpOffre.Text = offreCourante.DateOffre;

        }

        private void buttonMajOffre_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir modifier cette offre", "Modification de l'offre", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Offre offreCourante = (Offre)bindingSourceDtg.Current;
                offreCourante.DescriptionOffre = richTextBoxDesc.Text;
                offreCourante.IDTypeContrat = (int)comboBoxContrat.SelectedValue;
                offreCourante.IDEntreprise = (int)comboBoxEntreprise.SelectedValue;
                offreCourante.LienWeb = textBoxLienWeb.Text;
                offreCourante.IDRegion = (int)comboBoxRegion.SelectedValue;
                offreCourante.IDTypePoste = (int)comboBoxPoste.SelectedValue;
                offreCourante.TitreOffre = comboBoxTitre.Text;
                offreCourante.DateOffre = Convert.ToDateTime(dtpOffre.Text).ToString("dd/MM/yyyy");
                int nbLignes = GetControleur.UpdateOffre(offreCourante);

                labelResultatMaj.Text = nbLignes + " ligne(s) mise à jour";
                LoadDataGrid();
            }

        }

        private void buttonReinit_Click(object sender, EventArgs e)
        {
            comboBoxContrat.SelectedItem = null;
            dtpOffre.Text = String.Empty;
            comboBoxEntreprise.SelectedItem = null;
            textBoxLienWeb.Text = String.Empty;
            comboBoxPoste.SelectedItem = null;
            comboBoxRegion.SelectedItem = null;
            comboBoxTitre.SelectedItem = null;
            richTextBoxDesc.Text = null;
        }

        private void buttonnAddOffre_Click(object sender, EventArgs e)
        {
            Offre offreCourante = new Offre();
            offreCourante.DescriptionOffre = richTextBoxDesc.Text;
            offreCourante.IDTypeContrat = (int)comboBoxContrat.SelectedValue;
            offreCourante.IDEntreprise = (int)comboBoxEntreprise.SelectedValue;
            offreCourante.LienWeb = textBoxLienWeb.Text;
            offreCourante.IDRegion = (int)comboBoxRegion.SelectedValue;
            offreCourante.IDTypePoste = (int)comboBoxPoste.SelectedValue;
            offreCourante.TitreOffre = comboBoxTitre.Text;
            offreCourante.DateOffre = Convert.ToDateTime(dtpOffre.Text).ToString("dd/MM/yyyy");
            int nbLignes = GetControleur.AddOffre(offreCourante);

            labelResultatMaj.Text = nbLignes + " ligne(s) ajoutée(s)";

            LoadDataGrid();
        }

        private void buttonDeleteOffre_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer cette offre", "Suppression de l'offre", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                int nbLignes = GetControleur.DeleteOffre(dtgOffre.CurrentRow.Cells["IDOffre"].Value.ToString());
                labelResultatMaj.Text = nbLignes + " ligne(s)supprimée(s)";
            }
            LoadDataGrid();
        }      

        private void buttonAjoutEntreprise_Click(object sender, EventArgs e)
        {
            Entreprise entreprise = new Entreprise();
            entreprise.NomEntreprise = textBoxNomEntreprise.Text;
            entreprise.ContactEntreprise = textBoxConseiller.Text;
            entreprise.NumeroEntreprise = Convert.ToInt32(textBoxTel.Text);
            int nbLignes = GetControleur.AddEntreprise(entreprise);
            labelResultatMaj.Text = nbLignes + " entreprise ajoutée";
            LoadComboBox();
        }

        private void buttonAddPoste_Click(object sender, EventArgs e)
        {
            TypePoste typePoste = new TypePoste();
            typePoste.NomPoste = textBoxAjout.Text;
            int nbLignes = GetControleur.AddPoste(typePoste);
            labelResultatMaj.Text = nbLignes + " poste ajouté";
            LoadComboBox();
        }

        private void buttonAddContrat_Click(object sender, EventArgs e)
        {
            TypeContrat typeContrat = new TypeContrat();
            typeContrat.NomTypeContrat = textBoxAjout.Text;
            int nbLignes = GetControleur.AddContrat(typeContrat);
            labelResultatMaj.Text = nbLignes + " contrat ajouté";
            LoadComboBox();
        }
    }
}
