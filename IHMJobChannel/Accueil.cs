﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;

namespace IHMJobChannel
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
            labelNom.Text = "Bonjour " + UserPrincipal.Current.GivenName;
            toolTipAccueil.SetToolTip(btnEdit, "Ajouter, modifier ou supprimer une offre");
            toolTipAccueil.SetToolTip(btnRead, "Consulter une offre");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (Edition FenEdit = new Edition()) 
            {
                FenEdit.BackColor = Color.Beige;
                this.Opacity = 0.75;
                FenEdit.ShowDialog();
                this.Opacity = 1;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (Consultation FenConsult= new Consultation())
            {
                FenConsult.BackColor = Color.Beige;
                this.Opacity = 0.75;
                FenConsult.ShowDialog();
                this.Opacity = 1;
            }
        }
    }
}
