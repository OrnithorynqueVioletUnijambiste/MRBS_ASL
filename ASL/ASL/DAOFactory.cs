using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace ASL
{
    public class DAOFactory
    {
        SqlConnection maConnexion;
        SqlDataAdapter monDataAdapter;
        SqlCommand maCommand;
        public DAOFactory() {

            maConnexion = new SqlConnection("Data Source='172.17.21.10';Database='SIO2_M2L_TeamE';User ID=SIO2-dev;Password=btssio-slam-2019");
        }
        public void connexion()
        {
           
            maConnexion.Open();

        }
        public void deconnexion()
        {
            maConnexion.Close();
        }

        public SqlDataReader excecSQLread(string requete)
        {
            //maConnexion.Open();

            maCommand = new SqlCommand();
            maCommand.CommandText = requete;
            maCommand.Connection = maConnexion;
            monDataAdapter = new SqlDataAdapter();
            monDataAdapter.SelectCommand = maCommand;

            SqlDataReader monDR;
            monDR = maCommand.ExecuteReader();
           //maConnexion.Close();
            return monDR;
        }

        public void excecSQLWrite(string requete)
        {
            //maConnexion.Open();

            maCommand = new SqlCommand();
            maCommand.CommandText = requete;
            maCommand.Connection = maConnexion;

            maCommand.ExecuteNonQuery();
            //maConnexion.Close();

        }

       
    }

  
             
    

}
