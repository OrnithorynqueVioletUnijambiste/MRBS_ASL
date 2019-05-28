using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASL
{
    public class Stand
    {
        #region Propriétés privées 
        private string id;
        private string nom;
        private double capacite;
        private string num_ordre;
        private string num_allee;
        public List<Partenaire> lesPartenaires;

        #endregion

        #region Constructeur de la classe

        public Stand() { }
    
        public Stand(string unId, string unNom, double uneCapacite, string unNumOrdre, string unNumAllee)
        {
            id = unId;
            nom = unNom;
            capacite = uneCapacite;
            num_ordre = unNumOrdre;
            num_allee = unNumAllee;
            lesPartenaires = new List<Partenaire>();
            lesPartenaires = DAOASL.getPartenairesFromSelectedStand(id);
        }

        #endregion

        #region Accesseurs
        public string IdStand
        {
            get { return id; }
            set { id = value; }
        }
        public string NomStand
        {
            get { return nom; }
            set { nom = value; }
        }

        public double CapaciteStand
        {
            get { return capacite; }
            set { capacite = value; }
        }

        public string NumAlleeStand
        {
            get { return num_allee; }
            set { num_allee = value; }
        }

        public string NumOrdreStand
        {
            get { return num_ordre; }
            set { num_ordre = value; }
        }
        #endregion

    }

}
