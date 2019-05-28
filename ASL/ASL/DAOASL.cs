using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ASL
{
    public class DAOASL
    {
        public DAOASL()
        {

        }

        public static List<Partenaire> getAllPartenaires()
        {
            string requete = "select * from Partenaire join Type on Type.id = Partenaire.id_type";
            DAOFactory Dao = new DAOFactory();
            Dao.connexion();
            SqlDataReader monDR = Dao.excecSQLread(requete);
            List<Partenaire> listePartenaires = new List<Partenaire>();
            while (monDR.Read())
            {
                Partenaire Partenaire = new Partenaire(monDR[0].ToString(), monDR[3].ToString(), monDR[5].ToString(), float.Parse(monDR[6].ToString()));
                listePartenaires.Add(Partenaire);
            }
            Dao.deconnexion();
            return listePartenaires;
        }
        
        public static List<Stand> getAllStands()
        {
            string requete = "select * from Stand";
            DAOFactory Dao = new DAOFactory();
            Dao.connexion();
            SqlDataReader monDR = Dao.excecSQLread(requete);
            List<Stand> listeStands = new List<Stand>();
            while(monDR.Read())
            {
                Stand Stand = new Stand(monDR[0].ToString(), monDR[4].ToString(), float.Parse(monDR[1].ToString()), monDR[3].ToString(), monDR[2].ToString());
                listeStands.Add(Stand); 
            }
            Dao.deconnexion();
            return listeStands;

        }

        public static List<Partenaire> getPartenairesFromSelectedStand(string unIdStand)
        {
            string requete = "select * from Partenaire join Type on Type.id = Partenaire.id_type where id_stand = " + unIdStand + "";
            DAOFactory Dao = new DAOFactory();
            Dao.connexion();
            SqlDataReader monDR = Dao.excecSQLread(requete);
            List<Partenaire> listePartenairesFromStandId = new List<Partenaire>();
            while (monDR.Read())
            {
                Partenaire Partenaire = new Partenaire(monDR[0].ToString(), monDR[3].ToString(), monDR[5].ToString(), float.Parse(monDR[6].ToString()));
                listePartenairesFromStandId.Add(Partenaire);
            }
            Dao.deconnexion();
            return listePartenairesFromStandId;
        }

        public static void ajouterPartenaire(string idStand, string idPartenaire)
        {
            string requete = "update Partenaire set id_stand = " + idStand + " where id = " + idPartenaire + "";
            DAOFactory Dao = new DAOFactory();
            Dao.connexion();
            Dao.excecSQLWrite(requete);
            Dao.deconnexion();
        }

        public static void enleverPartenaire(string idPartenaire)
        {
            string requete = "update Partenaire set id_stand = null where id = " + idPartenaire + "";
            DAOFactory Dao = new DAOFactory();
            Dao.connexion();
            Dao.excecSQLWrite(requete);
            Dao.deconnexion();
        }

    }
}
