using BLLJobChannel;
using BOJobChannel;
using DALJobChannel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            toolTipConsultation.SetToolTip(btnTop10, "Consulter les 10 dernières offres");
            toolTipConsultation.SetToolTip(btnInit, "Initialiser les filtres");
        }

        private void Consultation_Load(object sender, EventArgs e)
        {
            
            bindingSourceOffre.DataSource = GetControleur.GetAll();
            dtgOffre.DataSource = bindingSourceOffre;

            dtgOffre.Columns["IDOffre"].Visible = false;
            dtgOffre.Columns["DescriptionOffre"].Visible = false;
            dtgOffre.Columns["LienWeb"].Visible = false;
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

            if(bindingSourceOffre.Current != null)
            {
                comboBoxContrat.Text = "Veuillez sélectionnez un type de contrat";
                comboBoxPoste.Text = "Veuillez sélectionnez un type de poste";
                comboBoxEntreprise.Text = "Veuillez sélectionnez une entreprise";
                comboBoxRegion.Text = "Veuillez sélectionnez une région";
                Offre offreCourante = (Offre)bindingSourceOffre.Current;
                richTxtBoxDesc.Text = offreCourante.DescriptionOffre;
                linkLblLienWeb.Text = offreCourante.LienWeb;
                LinkLabel.Link link = new LinkLabel.Link();
                //link.LinkData = "http://www.dotnetperls.com/";
                link.LinkData = offreCourante.LienWeb;
                linkLblLienWeb.Links.Add(link);
            }
        }

        private void comboBoxPoste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPoste.SelectedValue != null && comboBoxPoste.SelectedValue is int)
            {
                bindingSourceOffre.DataSource = GetControleur.GetOffresByPoste(comboBoxPoste.SelectedValue.ToString());
                comboBoxContrat.Text = "Veuillez sélectionnez un contrat";
                comboBoxEntreprise.Text = "Veuillez sélectionnez une entreprise";
                comboBoxRegion.Text = "Veuillez sélectionnez une région";

            }
        }

        private void comboBoxContrat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxContrat.SelectedValue != null && comboBoxContrat.SelectedValue is int)
            {
                bindingSourceOffre.DataSource = GetControleur.GetOffresByContrat(comboBoxContrat.SelectedValue.ToString());
                comboBoxEntreprise.Text = "Veuillez sélectionnez une entreprise";
                comboBoxPoste.Text = "Veuillez sélectionnez un type de poste";
                comboBoxRegion.Text = "Veuillez sélectionnez une région";

            }
        }

        private void comboBoxEntreprise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxEntreprise.SelectedValue != null && comboBoxEntreprise.SelectedValue is int)
            {
                bindingSourceOffre.DataSource = GetControleur.GetOffresByEntreprise(comboBoxEntreprise.SelectedValue.ToString());
                comboBoxContrat.Text = "Veuillez sélectionnez un contrat";
                comboBoxPoste.Text = "Veuillez sélectionnez un type de poste";
                comboBoxRegion.Text = "Veuillez sélectionnez une région";

            }

        }

        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRegion.SelectedValue != null && comboBoxRegion.SelectedValue is int)
            {
                bindingSourceOffre.DataSource = GetControleur.GetOffresByRegion(comboBoxRegion.SelectedValue.ToString());
                comboBoxContrat.Text = "Veuillez sélectionnez un contrat";
                comboBoxEntreprise.Text = "Veuillez sélectionnez une entreprise";
                comboBoxPoste.Text = "Veuillez sélectionnez un type de poste";
            }

        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            comboBoxContrat.Text = "Veuillez sélectionnez un type de contrat";
            comboBoxPoste.Text = "Veuillez sélectionnez un type de poste";
            comboBoxEntreprise.Text = "Veuillez sélectionnez une entreprise";
            comboBoxRegion.Text = "Veuillez sélectionnez une région";
            bindingSourceOffre.DataSource = GetControleur.GetAll();
            dtgOffre.DataSource = bindingSourceOffre;
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            bindingSourceOffre.DataSource = GetControleur.Top10();
            dtgOffre.DataSource = bindingSourceOffre;
            comboBoxContrat.Text = "Veuillez sélectionnez un type de contrat";
            comboBoxPoste.Text = "Veuillez sélectionnez un type de poste";
            comboBoxEntreprise.Text = "Veuillez sélectionnez une entreprise";
            comboBoxRegion.Text = "Veuillez sélectionnez une région";
        }

        private void bindingSourceOffre_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSourceOffre.Current != null)
            {
                Offre offreCourante = (Offre)bindingSourceOffre.Current;
                richTxtBoxDesc.Text = offreCourante.DescriptionOffre;
                linkLblLienWeb.Text = offreCourante.LienWeb;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);

        }

        private void linkLblLienWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLblLienWeb.LinkVisited = true;
            Process.Start(e.Link.LinkData as string);
        }
    }
}
