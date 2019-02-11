namespace IHMJobChannel
{
    partial class Consultation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTop10 = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.comboBoxEntreprise = new System.Windows.Forms.ComboBox();
            this.comboBoxContrat = new System.Windows.Forms.ComboBox();
            this.comboBoxPoste = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgOffre = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLienWeb = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.linkLblLienWeb = new System.Windows.Forms.LinkLabel();
            this.richTxtBoxDesc = new System.Windows.Forms.RichTextBox();
            this.bindingSourcePoste = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceContrat = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceEntreprise = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceRegion = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceOffre = new System.Windows.Forms.BindingSource(this.components);
            this.toolTipConsultation = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOffre)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePoste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceContrat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEntreprise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOffre)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.44444F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1014, 518);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTop10);
            this.panel1.Controls.Add(this.btnInit);
            this.panel1.Controls.Add(this.comboBoxRegion);
            this.panel1.Controls.Add(this.comboBoxEntreprise);
            this.panel1.Controls.Add(this.comboBoxContrat);
            this.panel1.Controls.Add(this.comboBoxPoste);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 74);
            this.panel1.TabIndex = 1;
            // 
            // btnTop10
            // 
            this.btnTop10.Location = new System.Drawing.Point(885, 27);
            this.btnTop10.Name = "btnTop10";
            this.btnTop10.Size = new System.Drawing.Size(114, 23);
            this.btnTop10.TabIndex = 0;
            this.btnTop10.Text = "10 dernières offres";
            this.btnTop10.UseVisualStyleBackColor = true;
            this.btnTop10.Click += new System.EventHandler(this.btnTop10_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(9, 25);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(111, 23);
            this.btnInit.TabIndex = 4;
            this.btnInit.Text = "Reinitialiser filtre";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(684, 27);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(180, 21);
            this.comboBoxRegion.TabIndex = 3;
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged);
            // 
            // comboBoxEntreprise
            // 
            this.comboBoxEntreprise.FormattingEnabled = true;
            this.comboBoxEntreprise.Location = new System.Drawing.Point(497, 27);
            this.comboBoxEntreprise.Name = "comboBoxEntreprise";
            this.comboBoxEntreprise.Size = new System.Drawing.Size(180, 21);
            this.comboBoxEntreprise.TabIndex = 2;
            this.comboBoxEntreprise.SelectedIndexChanged += new System.EventHandler(this.comboBoxEntreprise_SelectedIndexChanged);
            // 
            // comboBoxContrat
            // 
            this.comboBoxContrat.FormattingEnabled = true;
            this.comboBoxContrat.Location = new System.Drawing.Point(311, 27);
            this.comboBoxContrat.Name = "comboBoxContrat";
            this.comboBoxContrat.Size = new System.Drawing.Size(180, 21);
            this.comboBoxContrat.TabIndex = 1;
            this.comboBoxContrat.SelectedIndexChanged += new System.EventHandler(this.comboBoxContrat_SelectedIndexChanged);
            // 
            // comboBoxPoste
            // 
            this.comboBoxPoste.FormattingEnabled = true;
            this.comboBoxPoste.Location = new System.Drawing.Point(125, 27);
            this.comboBoxPoste.Name = "comboBoxPoste";
            this.comboBoxPoste.Size = new System.Drawing.Size(180, 21);
            this.comboBoxPoste.TabIndex = 0;
            this.comboBoxPoste.SelectedIndexChanged += new System.EventHandler(this.comboBoxPoste_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dtgOffre, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.27808F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.72192F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1008, 432);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dtgOffre
            // 
            this.dtgOffre.AllowUserToAddRows = false;
            this.dtgOffre.AllowUserToDeleteRows = false;
            this.dtgOffre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgOffre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOffre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgOffre.Location = new System.Drawing.Point(3, 3);
            this.dtgOffre.Name = "dtgOffre";
            this.dtgOffre.ReadOnly = true;
            this.dtgOffre.RowHeadersVisible = false;
            this.dtgOffre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgOffre.Size = new System.Drawing.Size(1002, 228);
            this.dtgOffre.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLienWeb);
            this.panel2.Controls.Add(this.lblDesc);
            this.panel2.Controls.Add(this.linkLblLienWeb);
            this.panel2.Controls.Add(this.richTxtBoxDesc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 192);
            this.panel2.TabIndex = 2;
            // 
            // lblLienWeb
            // 
            this.lblLienWeb.AutoSize = true;
            this.lblLienWeb.Location = new System.Drawing.Point(392, 19);
            this.lblLienWeb.Name = "lblLienWeb";
            this.lblLienWeb.Size = new System.Drawing.Size(99, 13);
            this.lblLienWeb.TabIndex = 3;
            this.lblLienWeb.Text = "Lien web de l\'offre :";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(17, 16);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(109, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Description de l\'offre :";
            // 
            // linkLblLienWeb
            // 
            this.linkLblLienWeb.AutoSize = true;
            this.linkLblLienWeb.Location = new System.Drawing.Point(392, 54);
            this.linkLblLienWeb.Name = "linkLblLienWeb";
            this.linkLblLienWeb.Size = new System.Drawing.Size(0, 13);
            this.linkLblLienWeb.TabIndex = 1;
            this.linkLblLienWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblLienWeb_LinkClicked);
            // 
            // richTxtBoxDesc
            // 
            this.richTxtBoxDesc.Location = new System.Drawing.Point(20, 35);
            this.richTxtBoxDesc.Name = "richTxtBoxDesc";
            this.richTxtBoxDesc.Size = new System.Drawing.Size(308, 128);
            this.richTxtBoxDesc.TabIndex = 0;
            this.richTxtBoxDesc.Text = "";
            // 
            // bindingSourceOffre
            // 
            this.bindingSourceOffre.CurrentChanged += new System.EventHandler(this.bindingSourceOffre_CurrentChanged);
            // 
            // Consultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 518);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Consultation";
            this.Text = "Consultation";
            this.Load += new System.EventHandler(this.Consultation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOffre)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePoste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceContrat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEntreprise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOffre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.ComboBox comboBoxEntreprise;
        private System.Windows.Forms.ComboBox comboBoxContrat;
        private System.Windows.Forms.ComboBox comboBoxPoste;
        private System.Windows.Forms.BindingSource bindingSourcePoste;
        private System.Windows.Forms.BindingSource bindingSourceContrat;
        private System.Windows.Forms.BindingSource bindingSourceEntreprise;
        private System.Windows.Forms.BindingSource bindingSourceRegion;
        private System.Windows.Forms.BindingSource bindingSourceOffre;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dtgOffre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTop10;
        private System.Windows.Forms.Label lblLienWeb;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.LinkLabel linkLblLienWeb;
        private System.Windows.Forms.RichTextBox richTxtBoxDesc;
        private System.Windows.Forms.ToolTip toolTipConsultation;
    }
}