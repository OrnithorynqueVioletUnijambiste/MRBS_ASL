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
            //Form Login = new Form();
            //Form App = new Form();

            //Chargement DataGridView des Ateliers
            List<Atelier> lesAteliers = new List<Atelier>();
            lesAteliers = DAOASL.getAllAteliers();
            dgvAteliers.DataSource = null;
            dgvAteliers.DataSource = lesAteliers;
            dgvAteliers.AutoResizeColumns();

            foreach(Atelier unAtelier in lesAteliers)
            {
                cbAtelierAssoc.Items.Add(unAtelier.IdAtelier + ". " + unAtelier.NomAtelier);
            }

            
        }

        #region Atelier

        private void btnAddAtelier_Click(object sender, EventArgs e)
        {
            string nomAtelier = txbAtelier.Text;
            int capacite = int.Parse(nupCapacite.Text);
            DateTime horaireDebut = dtpDateDebut.Value;
            DateTime horaireFin = dtpDateFin.Value;
            Atelier atelier = new Atelier(1, nomAtelier, capacite, horaireDebut, horaireFin);
            DAOASL.creerAtelier(atelier);
            refreshDgvAtelier();
        }

        private void btnModifierAtelier_Click(object sender, EventArgs e)
        {
            int idAtelier = Convert.ToInt32(dgvAteliers.CurrentRow.Cells[0].Value);
            string nomAtelier = txbAtelier.Text;
            int capacite = int.Parse(nupCapacite.Text);
            DateTime horaireDebut = dtpDateDebut.Value;
            DateTime horaireFin = dtpDateFin.Value;
            Atelier atelier = new Atelier(idAtelier, nomAtelier, capacite, horaireDebut, horaireFin);
            DAOASL.modifierAtelier(atelier);
            refreshDgvAtelier();
        }

        private void BtnSupprimerAtelier_Click(object sender, EventArgs e)
        {
            int idAtelier = Convert.ToInt32(dgvAteliers.CurrentRow.Cells[0].Value);
            DAOASL.supprimerAtelier(idAtelier);
            refreshDgvAtelier();
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

            int index = cbAtelierAssoc.SelectedItem.ToString().IndexOf('.');
            int id = int.Parse(cbAtelierAssoc.SelectedItem.ToString().Substring(0, index));

            Theme theme = new Theme(42, nomTheme);
            DAOASL.creerTheme(theme, id);

            refreshDgvTheme(id);
        }

        private void BtnModifierTheme_Click(object sender, EventArgs e)
        {
            int idTheme = Convert.ToInt32(dgvThemes.CurrentRow.Cells[0].Value);
            string nomTheme = txbTheme.Text;
            Theme theme = new Theme(idTheme, nomTheme);
            DAOASL.modifierTheme(theme);

            int index = cbAtelierAssoc.SelectedItem.ToString().IndexOf('.');
            int id = int.Parse(cbAtelierAssoc.SelectedItem.ToString().Substring(0, index));

            refreshDgvTheme(id);
        }

        private void BtnSupprimerTheme_Click(object sender, EventArgs e)
        {
            int idTheme = Convert.ToInt32(dgvThemes.CurrentRow.Cells[0].Value);
            DAOASL.supprimerTheme(idTheme);
            
            int index = cbAtelierAssoc.SelectedItem.ToString().IndexOf('.');
            int id = int.Parse(cbAtelierAssoc.SelectedItem.ToString().Substring(0, index));

            refreshDgvTheme(id);
        }

        private void CbAtelierAssoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbAtelierAssoc.SelectedItem.ToString().IndexOf('.');
            int id = int.Parse(cbAtelierAssoc.SelectedItem.ToString().Substring(0, index));
            refreshDgvTheme(id);

        }

        private void TxbTheme_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvThemes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        #region fonctions du turfu
        
        public void refreshDgvAtelier()
        {
            cbAtelierAssoc.Items.Clear();
            List<Atelier> lesAteliers = new List<Atelier>();
            lesAteliers = DAOASL.getAllAteliers();
            dgvThemes.DataSource = null;
            dgvAteliers.DataSource = null;
            dgvAteliers.DataSource = lesAteliers;
            dgvAteliers.AutoResizeColumns();

            foreach (Atelier unAtelier in lesAteliers)
            {
                cbAtelierAssoc.Items.Add(unAtelier.IdAtelier + ". " + unAtelier.NomAtelier);
            }
        }

        public void refreshDgvTheme(int id)
        {
            List<Theme> lesThemes = new List<Theme>();
            lesThemes = DAOASL.getAllTheme(id);
            dgvThemes.DataSource = null;
            dgvThemes.DataSource = lesThemes;
            dgvThemes.AutoResizeColumns();
        }

        #endregion
    }
}
