using System;


namespace ASL
{
    public class Utilisateur
    {
        private string username;
        private string password;

        public Utilisateur(string unUser, string unPassword)
	    {
            Username = unUser;
            Password = unPassword;
	    }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }

}
