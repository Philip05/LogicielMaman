using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicielMaman
{
    public class AdministrateurPersonne: Personne
    {
        public AdministrateurPersonne()
        {

        }
        public static string NomAdministrateurConnecte
        {
            get
            {
                return nomUtilisateur;
            }
            set
            {
                nomUtilisateur = value;
            }
        }
    }
}
