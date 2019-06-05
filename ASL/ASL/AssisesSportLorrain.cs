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
        //private Stand aslStand;
        public AssisesSportLorrain()
        {

            InitializeComponent();

        }

        #region Evenements
        private void partenairesDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AssisesSportLorrain_Load(object sender, EventArgs e)
        {
            List<Stand> tousLesStands = new List<Stand>();
            List<Partenaire> tousLesPartenaires = new List<Partenaire>();

            tousLesStands = DAOASL.getAllStands();
            tousLesPartenaires = DAOASL.getAllPartenaires();

            foreach (Stand unStand in tousLesStands)
            {
                //récuperation de l'id dans la base et intégration dans les champs de la combo box ( "id" . "nom" , etc) 
                standCbx.Items.Add(unStand.IdStand + ". " + unStand.NomStand + ", " + unStand.NumAlleeStand + ", " + unStand.NumOrdreStand + " ( " + unStand.CapaciteStand + " places ) ");

            }

            foreach (Partenaire unPartenaire in tousLesPartenaires)
            {
                partenairesCbx.Items.Add(unPartenaire.IdPartenaire + ". " + unPartenaire.NomPartenaire + " (" + unPartenaire.TypePartenaire + " / " + unPartenaire.TarifPartenaire + " € )");
            }



        }


        private void ajouterBtn_Click(object sender, EventArgs e)
        {
            if (standCbx.SelectedItem != null && partenairesCbx.SelectedItem != null)
            {
                //récuperation de l'id avec la chaîne de caractère de la combo box en coupant cette dernière  
                string idStand = standCbx.SelectedItem.ToString().Substring(0, standCbx.SelectedItem.ToString().IndexOf('.'));
                string idPartenaire = partenairesCbx.SelectedItem.ToString().Substring(0, partenairesCbx.SelectedItem.ToString().IndexOf('.'));
                DAOASL.ajouterPartenaire(idStand, idPartenaire);
                remplirPartenaires(idStand);
            }
        }

        private void enleverBtn_Click(object sender, EventArgs e)
        {
            if (standCbx.SelectedItem != null && partenairesCbx.SelectedItem != null)
            {
                string idStand = standCbx.SelectedItem.ToString().Substring(0, standCbx.SelectedItem.ToString().IndexOf('.'));
                string idPartenaire = partenairesCbx.SelectedItem.ToString().Substring(0, partenairesCbx.SelectedItem.ToString().IndexOf('.'));
                DAOASL.enleverPartenaire(idPartenaire);
                remplirPartenaires(idStand);
            }
        }

        private void tabCtrlASL_Click(object sender, EventArgs e)
        {


        }

        private void standCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexPoint = standCbx.SelectedItem.ToString().IndexOf('.');
            int indexVirgule = standCbx.SelectedItem.ToString().IndexOf(',');
            string id = standCbx.SelectedItem.ToString().Substring(0, indexPoint);
            string nomStand = standCbx.SelectedItem.ToString().Substring(indexPoint +1 , indexVirgule -2);
            remplirPartenaires(id);
            deStandLbl.Text = "de " + nomStand;
        }

        #endregion

        #region Procédures
       private void remplirPartenaires(string id)
        {
            List<Partenaire> PartenairesFromSelectedStand = new List<Partenaire>();
            PartenairesFromSelectedStand = DAOASL.getPartenairesFromSelectedStand(id);
            partenairesDgv.DataSource = null;
            partenairesDgv.DataSource = PartenairesFromSelectedStand;
            partenairesDgv.AutoResizeColumns();
        
        }

        private Stand setStand(string unIdStand)
        {
            Stand leStand = new Stand();
            List<Stand> tousLesStands = new List<Stand>();
            tousLesStands = DAOASL.getAllStands();
            foreach(Stand unStand in tousLesStands)
            {
                if(unStand.IdStand == unIdStand )
                {
                    leStand.IdStand = unIdStand;
                    leStand.NomStand = unStand.NomStand;
                    leStand.NumAlleeStand = unStand.NumAlleeStand;
                    leStand.NumOrdreStand = unStand.NumOrdreStand;

                }
            }
            return leStand;
        }

        #endregion


    }
}
