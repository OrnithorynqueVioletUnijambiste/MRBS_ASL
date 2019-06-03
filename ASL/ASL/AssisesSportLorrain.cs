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
            //Chargement DataGridView des Ateliers
            List<Atelier> lesAteliers = new List<Atelier>();
            lesAteliers = DAOASL.getAllAteliers();
            dgvAteliers.DataSource = null;
            dgvAteliers.DataSource = lesAteliers;
            dgvAteliers.AutoResizeColumns();

            //Chargement Combobox des Ateliers dans Thème
            cbAtelierAssoc.DataSource = DAOASL.getAllAteliers();
            cbAtelierAssoc.ValueMember = "idAtelier";
            cbAtelierAssoc.DisplayMember = "nomAtelier";
        }

        #region Atelier

        private void btnAddAtelier_Click(object sender, EventArgs e)
        {
            string nomAtelier = txbAtelier.Text;
            int capacite = int.Parse(txbCapacite.Text);
            DateTime horaireDebut = dtpDateDebut.Value;
            DateTime horaireFin = dtpDateFin.Value;
            Atelier atelier = new Atelier(1, nomAtelier, capacite, horaireDebut, horaireFin);
            DAOASL.creerAtelier(atelier);

            List<Atelier> lesAteliers = new List<Atelier>();
            lesAteliers = DAOASL.getAllAteliers();
            dgvAteliers.DataSource = null;
            dgvAteliers.DataSource = lesAteliers;
            dgvAteliers.AutoResizeColumns();
        }

        private void btnModifierAtelier_Click(object sender, EventArgs e)
        {
            int idAtelier = Convert.ToInt32(dgvAteliers.CurrentRow.Cells[0].Value);
            string nomAtelier = txbAtelier.Text;
            int capacite = int.Parse(txbCapacite.Text);
            DateTime horaireDebut = dtpDateDebut.Value;
            DateTime horaireFin = dtpDateFin.Value;
            Atelier atelier = new Atelier(idAtelier, nomAtelier, capacite, horaireDebut, horaireFin);
            DAOASL.modifierAtelier(atelier);

            List<Atelier> lesAteliers = new List<Atelier>();
            lesAteliers = DAOASL.getAllAteliers();
            dgvAteliers.DataSource = null;
            dgvAteliers.DataSource = lesAteliers;
            dgvAteliers.AutoResizeColumns();
        }

        private void BtnSupprimerAtelier_Click(object sender, EventArgs e)
        {
            int idAtelier = Convert.ToInt32(dgvAteliers.CurrentRow.Cells[0].Value);
            DAOASL.supprimerAtelier(idAtelier);

            List<Atelier> lesAteliers = new List<Atelier>();
            lesAteliers = DAOASL.getAllAteliers();
            dgvAteliers.DataSource = null;
            dgvAteliers.DataSource = lesAteliers;
            dgvAteliers.AutoResizeColumns();
        }

        private void dgvAteliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO: Autofill textboxes onclick
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

        #endregion


        #region Theme

        private void BtnAjouterTheme_Click(object sender, EventArgs e)
        {
            string nomTheme = txbTheme.Text;
            int idAtelier = Convert.ToInt32(cbAtelierAssoc.SelectedValue);
            Theme theme = new Theme(1, nomTheme);
            DAOASL.creerTheme(theme, idAtelier);

            List<Theme> lesThemes = new List<Theme>();
            lesThemes = DAOASL.getAllTheme(idAtelier);
            dgvThemes.DataSource = null;
            dgvThemes.DataSource = lesThemes;
            dgvThemes.AutoResizeColumns();
        }

        private void BtnModifierTheme_Click(object sender, EventArgs e)
        {

        }

        private void BtnSupprimerTheme_Click(object sender, EventArgs e)
        {

        }

        private void CbAtelierAssoc_SelectedIndexChanged(object sender, EventArgs e)
        {

            int unIdAtelier = Convert.ToInt32(cbAtelierAssoc?.SelectedValue);
            List<Theme> lesThemes = new List<Theme>();
            lesThemes = DAOASL.getAllTheme(unIdAtelier);
            dgvThemes.DataSource = null;
            dgvThemes.DataSource = lesThemes;
            dgvThemes.AutoResizeColumns();


        }

        private void TxbTheme_TextChanged(object sender, EventArgs e)
        {

        }



        private void DgvThemes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgvThemes.DataSource = null;
            //dgvThemes.DataSource = DAOASL.getAllTheme(dgvAteliers.Rows[DataGridView.SelectedRow[0].Index].Cells[0].Value.ToString());
        }
        #endregion
    }
}
