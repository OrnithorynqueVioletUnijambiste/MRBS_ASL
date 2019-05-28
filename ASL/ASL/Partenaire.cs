using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASL
{
    public class Partenaire
    {
        #region Propriétés privées
        private string id;
        private string nom;
        private string type;
        private double tarif;

        #endregion

        #region Constructeur

        public Partenaire(string unId, string unNom, string unType, double unTarif)
        {
            id = unId;
            nom = unNom;
            type = unType;
            tarif = unTarif;
        }

        #endregion

        #region Accesseurs

        public string IdPartenaire
        {
            get { return id; }

        }

        public string NomPartenaire
        {
            get { return nom; }
            set { nom = value; }
        }

        public string TypePartenaire
        {
            get { return type; }
            set { type = value; }
        }

        public double TarifPartenaire
        {
            get { return tarif; }
            set { tarif = value; }
        }

        #endregion
    }
}
