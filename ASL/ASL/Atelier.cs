using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ASL
{
    public class Atelier
    {
        private int idAtelier;
        private string nomAtelier;
        private int capacite;
        private DateTime horaireDebut;
        private DateTime horaireFin;


        public Atelier(int unIdAtelier, string unNomAtelier, int uneCapacite,
            DateTime unDebut, DateTime uneFin)
        {
            idAtelier = unIdAtelier;
            nomAtelier = unNomAtelier;
            capacite = uneCapacite;
            horaireDebut = unDebut;
            horaireFin = uneFin;

        }
        public int IdAtelier { get; set; }
        public string NomAtelier { get; set; }
        public int Capacite { get; set; }
        public DateTime HoraireDebut { get; set; }
        public DateTime HoraireFin { get; set; }
        
    }

}
