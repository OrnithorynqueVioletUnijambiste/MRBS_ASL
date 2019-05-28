using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASL
{
    public partial class AssisesSportLorrain : Form
    {
        public AssisesSportLorrain()
        {
            InitializeComponent();
        }

        private void dgvAteliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvAteliers.DataSource = null;
            dgvAteliers.DataSource = DAOASL.getAllAteliers();

            dgvAteliers.AutoResizeColumns();
        }

        private void txbCapacite_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDateDebut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpDateFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void txbAtelier_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTheme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
