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

        public int IdAtelier {
            get
            {
                return idAtelier;
            }
        }
        public string NomAtelier {
            get
            {
                return nomAtelier;
            }
            set
            {
                nomAtelier = value;
            }
        }
        public int Capacite {
            get
            {
                return capacite;
            }
            set
            {
                capacite = value;
            }
        }
        public DateTime HoraireDebut {
            get
            {
                return horaireDebut;
            }
            set
            {
                horaireDebut = value;
            }
        }
        public DateTime HoraireFin {
            get
            {
                return horaireFin;
            }
            set
            {
                horaireFin = value;
            }
        }

    }
}
