using System;


namespace ASL
{
    public class Theme
    {
        private int idTheme;
        private string libelle;

        public Theme(int unIdTheme, string unLibelle)
        {
            idTheme = unIdTheme;
            libelle = unLibelle;

        }

        public int IdTheme { get; set; }

        public string Libelle { get; set; }
    }
}