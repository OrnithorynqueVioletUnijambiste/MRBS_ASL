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

        private void AssisesSportLorrain_Load(object sender, EventArgs e)
        {
            List<Atelier> lesAteliers = new List<Atelier>();
            List<Theme> lesThemes = new List<Theme>();

            lesAteliers = DAOASL.getAllAteliers();
            //lesThemes = DAOASL.getAllTheme();
        }

        #region Atelier
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
        private void txbAtelier_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAtelier_Click(object sender, EventArgs e)
        {

        }

        private void btnModifierAtelier_Click(object sender, EventArgs e)
        {

        }

       
        private void BtnSupprimerAtelier_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region Theme

        private void TxbTheme_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbAtelierAssoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAjouterTheme_Click(object sender, EventArgs e)
        {

        }

        private void BtnModifierTheme_Click(object sender, EventArgs e)
        {

        }

        private void BtnSupprimerTheme_Click(object sender, EventArgs e)
        {

        }

        private void DgvThemes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvThemes.DataSource = null;
            //dgvThemes.DataSource = DAOASL.getAllTheme(dgvAteliers.Rows[DataGridView.SelectedRow[0].Index].Cells[0].Value.ToString());
        }
        #endregion
    }
}
