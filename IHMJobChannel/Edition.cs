using BLLJobChannel;
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
        public Edition()
        {
            InitializeComponent();
        }

        private void Edition_Load(object sender, EventArgs e)
        {
            Controleur getData = new Controleur();
            comboBoxContrat.DataSource = getData.GetAllTypeContrats();
            comboBoxContrat.DisplayMember = "NomTypeContrat";
            comboBoxContrat.ValueMember = "IDTypeContrat";
            bindingSource1.DataSource = getData.GetAll();
            dtgOffre.DataSource = bindingSource1;
        }
    }
}
