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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
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
