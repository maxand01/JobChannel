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
            this.dtgOffre = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxPoste = new System.Windows.Forms.ComboBox();
            this.comboBoxContrat = new System.Windows.Forms.ComboBox();
            this.comboBoxEntreprise = new System.Windows.Forms.ComboBox();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.bindingSourcePoste = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceContrat = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceEntreprise = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceRegion = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceOffre = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOffre)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.dtgOffre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.44444F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtgOffre
            // 
            this.dtgOffre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOffre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgOffre.Location = new System.Drawing.Point(3, 72);
            this.dtgOffre.Name = "dtgOffre";
            this.dtgOffre.Size = new System.Drawing.Size(794, 375);
            this.dtgOffre.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxRegion);
            this.panel1.Controls.Add(this.comboBoxEntreprise);
            this.panel1.Controls.Add(this.comboBoxContrat);
            this.panel1.Controls.Add(this.comboBoxPoste);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 63);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxPoste
            // 
            this.comboBoxPoste.FormattingEnabled = true;
            this.comboBoxPoste.Location = new System.Drawing.Point(170, 21);
            this.comboBoxPoste.Name = "comboBoxPoste";
            this.comboBoxPoste.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPoste.TabIndex = 0;
            this.comboBoxPoste.SelectedIndexChanged += new System.EventHandler(this.comboBoxPoste_SelectedIndexChanged);
            // 
            // comboBoxContrat
            // 
            this.comboBoxContrat.FormattingEnabled = true;
            this.comboBoxContrat.Location = new System.Drawing.Point(315, 21);
            this.comboBoxContrat.Name = "comboBoxContrat";
            this.comboBoxContrat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxContrat.TabIndex = 1;
            this.comboBoxContrat.SelectedIndexChanged += new System.EventHandler(this.comboBoxContrat_SelectedIndexChanged);
            // 
            // comboBoxEntreprise
            // 
            this.comboBoxEntreprise.FormattingEnabled = true;
            this.comboBoxEntreprise.Location = new System.Drawing.Point(457, 21);
            this.comboBoxEntreprise.Name = "comboBoxEntreprise";
            this.comboBoxEntreprise.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEntreprise.TabIndex = 2;
            this.comboBoxEntreprise.SelectedIndexChanged += new System.EventHandler(this.comboBoxEntreprise_SelectedIndexChanged);
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(598, 21);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRegion.TabIndex = 3;
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged);
            // 
            // Consultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Consultation";
            this.Text = "Consultation";
            this.Load += new System.EventHandler(this.Consultation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOffre)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePoste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceContrat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEntreprise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOffre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dtgOffre;
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
    }
}