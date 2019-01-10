namespace IHMJobChannel
{
    partial class Edition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAddOffre = new System.Windows.Forms.Button();
            this.buttonReinit = new System.Windows.Forms.Button();
            this.buttonMajOffre = new System.Windows.Forms.Button();
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.comboBoxPoste = new System.Windows.Forms.ComboBox();
            this.comboBoxTitre = new System.Windows.Forms.ComboBox();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.comboBoxLienWeb = new System.Windows.Forms.ComboBox();
            this.comboBoxEntreprise = new System.Windows.Forms.ComboBox();
            this.comboBoxContrat = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgOffre = new System.Windows.Forms.DataGridView();
            this.labelResultatMaj = new System.Windows.Forms.Label();
            this.bindingSourceTypeContrat = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceOffre = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceTypePoste = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceEntreprise = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceRegion = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceDtg = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDeleteOffre = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOffre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypeContrat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOffre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypePoste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEntreprise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDtg)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.25F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDeleteOffre);
            this.panel2.Controls.Add(this.buttonAddOffre);
            this.panel2.Controls.Add(this.buttonReinit);
            this.panel2.Controls.Add(this.buttonMajOffre);
            this.panel2.Controls.Add(this.richTextBoxDesc);
            this.panel2.Controls.Add(this.comboBoxRegion);
            this.panel2.Controls.Add(this.comboBoxPoste);
            this.panel2.Controls.Add(this.comboBoxTitre);
            this.panel2.Controls.Add(this.comboBoxDate);
            this.panel2.Controls.Add(this.comboBoxLienWeb);
            this.panel2.Controls.Add(this.comboBoxEntreprise);
            this.panel2.Controls.Add(this.comboBoxContrat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(513, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 444);
            this.panel2.TabIndex = 1;
            // 
            // buttonAddOffre
            // 
            this.buttonAddOffre.Location = new System.Drawing.Point(11, 412);
            this.buttonAddOffre.Name = "buttonAddOffre";
            this.buttonAddOffre.Size = new System.Drawing.Size(75, 23);
            this.buttonAddOffre.TabIndex = 11;
            this.buttonAddOffre.Text = "Ajouter offre";
            this.buttonAddOffre.UseVisualStyleBackColor = true;
            this.buttonAddOffre.Click += new System.EventHandler(this.buttonnAddOffre_Click);
            // 
            // buttonReinit
            // 
            this.buttonReinit.Location = new System.Drawing.Point(96, 364);
            this.buttonReinit.Name = "buttonReinit";
            this.buttonReinit.Size = new System.Drawing.Size(90, 37);
            this.buttonReinit.TabIndex = 10;
            this.buttonReinit.Text = "Reinitialiser champs";
            this.buttonReinit.UseVisualStyleBackColor = true;
            this.buttonReinit.Click += new System.EventHandler(this.buttonReinit_Click);
            // 
            // buttonMajOffre
            // 
            this.buttonMajOffre.Location = new System.Drawing.Point(200, 412);
            this.buttonMajOffre.Name = "buttonMajOffre";
            this.buttonMajOffre.Size = new System.Drawing.Size(75, 23);
            this.buttonMajOffre.TabIndex = 9;
            this.buttonMajOffre.Text = "Mettre à jour";
            this.buttonMajOffre.UseVisualStyleBackColor = true;
            this.buttonMajOffre.Click += new System.EventHandler(this.buttonMajOffre_Click);
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Location = new System.Drawing.Point(11, 199);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(264, 159);
            this.richTextBoxDesc.TabIndex = 8;
            this.richTextBoxDesc.Text = "";
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(11, 37);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(264, 21);
            this.comboBoxRegion.TabIndex = 7;
            // 
            // comboBoxPoste
            // 
            this.comboBoxPoste.FormattingEnabled = true;
            this.comboBoxPoste.Location = new System.Drawing.Point(11, 64);
            this.comboBoxPoste.Name = "comboBoxPoste";
            this.comboBoxPoste.Size = new System.Drawing.Size(264, 21);
            this.comboBoxPoste.TabIndex = 6;
            // 
            // comboBoxTitre
            // 
            this.comboBoxTitre.FormattingEnabled = true;
            this.comboBoxTitre.Location = new System.Drawing.Point(11, 118);
            this.comboBoxTitre.Name = "comboBoxTitre";
            this.comboBoxTitre.Size = new System.Drawing.Size(264, 21);
            this.comboBoxTitre.TabIndex = 5;
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Location = new System.Drawing.Point(11, 145);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(264, 21);
            this.comboBoxDate.TabIndex = 3;
            // 
            // comboBoxLienWeb
            // 
            this.comboBoxLienWeb.FormattingEnabled = true;
            this.comboBoxLienWeb.Location = new System.Drawing.Point(11, 172);
            this.comboBoxLienWeb.Name = "comboBoxLienWeb";
            this.comboBoxLienWeb.Size = new System.Drawing.Size(264, 21);
            this.comboBoxLienWeb.TabIndex = 2;
            // 
            // comboBoxEntreprise
            // 
            this.comboBoxEntreprise.FormattingEnabled = true;
            this.comboBoxEntreprise.Location = new System.Drawing.Point(11, 91);
            this.comboBoxEntreprise.Name = "comboBoxEntreprise";
            this.comboBoxEntreprise.Size = new System.Drawing.Size(264, 21);
            this.comboBoxEntreprise.TabIndex = 1;
            // 
            // comboBoxContrat
            // 
            this.comboBoxContrat.FormattingEnabled = true;
            this.comboBoxContrat.Location = new System.Drawing.Point(11, 10);
            this.comboBoxContrat.Name = "comboBoxContrat";
            this.comboBoxContrat.Size = new System.Drawing.Size(264, 21);
            this.comboBoxContrat.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgOffre);
            this.panel1.Controls.Add(this.labelResultatMaj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 444);
            this.panel1.TabIndex = 0;
            // 
            // dtgOffre
            // 
            this.dtgOffre.AllowUserToAddRows = false;
            this.dtgOffre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOffre.Location = new System.Drawing.Point(3, 3);
            this.dtgOffre.Name = "dtgOffre";
            this.dtgOffre.RowHeadersVisible = false;
            this.dtgOffre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgOffre.Size = new System.Drawing.Size(498, 235);
            this.dtgOffre.TabIndex = 0;
            // 
            // labelResultatMaj
            // 
            this.labelResultatMaj.AutoSize = true;
            this.labelResultatMaj.Location = new System.Drawing.Point(385, 422);
            this.labelResultatMaj.Name = "labelResultatMaj";
            this.labelResultatMaj.Size = new System.Drawing.Size(0, 13);
            this.labelResultatMaj.TabIndex = 1;
            // 
            // bindingSourceDtg
            // 
            this.bindingSourceDtg.CurrentChanged += new System.EventHandler(this.bindingSourceDtg_CurrentChanged);
            // 
            // buttonDeleteOffre
            // 
            this.buttonDeleteOffre.Location = new System.Drawing.Point(104, 412);
            this.buttonDeleteOffre.Name = "buttonDeleteOffre";
            this.buttonDeleteOffre.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteOffre.TabIndex = 12;
            this.buttonDeleteOffre.Text = "Supprimer offre";
            this.buttonDeleteOffre.UseVisualStyleBackColor = true;
            this.buttonDeleteOffre.Click += new System.EventHandler(this.buttonDeleteOffre_Click);
            // 
            // Edition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Edition";
            this.Text = "Edition";
            this.Load += new System.EventHandler(this.Edition_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOffre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypeContrat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOffre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypePoste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEntreprise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgOffre;
        private System.Windows.Forms.BindingSource bindingSourceTypeContrat;
        private System.Windows.Forms.ComboBox comboBoxContrat;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.ComboBox comboBoxPoste;
        private System.Windows.Forms.ComboBox comboBoxTitre;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.ComboBox comboBoxLienWeb;
        private System.Windows.Forms.ComboBox comboBoxEntreprise;
        private System.Windows.Forms.BindingSource bindingSourceOffre;
        private System.Windows.Forms.BindingSource bindingSourceTypePoste;
        private System.Windows.Forms.BindingSource bindingSourceEntreprise;
        private System.Windows.Forms.BindingSource bindingSourceRegion;
        private System.Windows.Forms.BindingSource bindingSourceDtg;
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.Button buttonMajOffre;
        private System.Windows.Forms.Label labelResultatMaj;
        private System.Windows.Forms.Button buttonAddOffre;
        private System.Windows.Forms.Button buttonReinit;
        private System.Windows.Forms.Button buttonDeleteOffre;
    }
}