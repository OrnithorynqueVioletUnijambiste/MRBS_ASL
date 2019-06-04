using System;


namespace ASL
{
    public class Theme
    {
        private int idTheme;
        private string libelle;

        public Theme(int unIdTheme, string unLibelle)
        {
            IdTheme = unIdTheme;
            Libelle = unLibelle;

        }

        public int IdTheme
        {
            get
            {
                return idTheme;
            }

            set
            {
                idTheme = value;
            }
        }

        public string Libelle
        {
            get
            {
                return libelle;
            }

            set
            {
                libelle = value;
            }
        }
    }
}