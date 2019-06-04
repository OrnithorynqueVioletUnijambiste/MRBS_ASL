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

        #region Atelier
        public static List<Atelier> getAllAteliers()
        {
            string requete = "Select * from Atelier";
            DAOFactory dao = new DAOFactory();
            dao.connexion();
            SqlDataReader DataReading = dao.excecSQLread(requete);
            List<Atelier> listeAteliers = new List<Atelier>();
            while (DataReading.Read())
            {
                Atelier unAtelier = new Atelier(int.Parse(DataReading[0].ToString()), DataReading[1].ToString(),
                    int.Parse(DataReading[2].ToString()), Convert.ToDateTime(DataReading[3]),
                    Convert.ToDateTime(DataReading[4]));
                listeAteliers.Add(unAtelier);
            }
            dao.deconnexion();
            return listeAteliers;
        }


        public static void creerAtelier(Atelier unAtelier)
        {
            DAOFactory dao = new DAOFactory();
            dao.connexion();
            string requete = "Insert into Atelier "
                           + "values('" + unAtelier.NomAtelier + "', "
                           + unAtelier.Capacite + ", '"
                           + unAtelier.HoraireDebut + "', '"
                           + unAtelier.HoraireFin + "')";
            dao.excecSQLWrite(requete);
            dao.deconnexion();
        }

        public static void modifierAtelier(Atelier unAtelier)
        {
            string requete = "Update Atelier "
                           + "SET "
                           + "nom = '" + unAtelier.NomAtelier + "', "
                           + "capacite = " + unAtelier.Capacite + ", "
                           + "horaire_debut = '" + unAtelier.HoraireDebut + "', "
                           + "horaire_fin = '" + unAtelier.HoraireFin + "' " 
                           + "Where id = " + unAtelier.IdAtelier;

            DAOFactory dao = new DAOFactory();
            dao.connexion();
            dao.excecSQLWrite(requete);
            dao.deconnexion();
        }
        public static void supprimerAtelier(int unIdAtelier)
        {
            string requete = "Delete from Atelier "
                           + "Where id = " + unIdAtelier;
            DAOFactory dao = new DAOFactory();
            dao.connexion();
            dao.excecSQLWrite(requete);
            dao.deconnexion();
        }

        #endregion

        #region Theme
        public static List<Theme> getAllTheme(int unIdAtelier)
        {
            string requete = "Select T.* from Theme T "
                           + "Join Atelier A "
                           + "On id_Atelier = A.id "
                           + "Where id_Atelier= " + unIdAtelier;
            DAOFactory dao = new DAOFactory();
            dao.connexion();
            SqlDataReader DataReading = dao.excecSQLread(requete);
            List<Theme> listeThemes = new List<Theme>();
            while (DataReading.Read())
            {
                Theme unTheme = new Theme(int.Parse(DataReading[0].ToString()), DataReading[1].ToString());
                listeThemes.Add(unTheme);
            }
            dao.deconnexion();
            return listeThemes;
        }

        public static void creerTheme(Theme unTheme, int unIdAtelier)
        {
            DAOFactory dao = new DAOFactory();
            dao.connexion();
            string requete = "Insert into Theme "
                           + "values('" + unTheme.Libelle + "', "
                           + unIdAtelier + ")";
            dao.excecSQLWrite(requete);
            dao.deconnexion();
        }

        public static void modifierTheme(Theme unTheme)
        {

            string requete = "Update Theme "
                           + "SET "
                           + "libelle = '" + unTheme.Libelle + "' "
                           + "WHERE id = " + unTheme.IdTheme;
            DAOFactory dao = new DAOFactory();
            dao.connexion();
            dao.excecSQLWrite(requete);
            dao.deconnexion();
        }

        public static void supprimerTheme(int unIdTheme)
        {
            string requete = "Delete from Theme "
                           + "Where id = " + unIdTheme;
            DAOFactory dao = new DAOFactory();
            dao.connexion();
            dao.excecSQLWrite(requete);
            dao.deconnexion();
        }
        #endregion
    }
}
