using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicielMaman
{
    public class ClientsPersonnes : Personne
    {
        protected Personne[] client;

        public ClientsPersonnes()
        {
            client = new Personne[2];
        }
    }
}
