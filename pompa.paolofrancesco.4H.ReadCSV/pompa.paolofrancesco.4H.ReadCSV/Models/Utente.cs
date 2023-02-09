using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pompa.paolofrancesco._4H.ReadCSV.Models
{
    public class Utente
    {
        public string Nome { get; set; }

        public string Cognome { get; set; }

        public string Email { get; set; }

        public string Tipo { get; set; }

        public Utente(string str)
        {
            string[] colonne = str.Split(";");
            Nome = colonne[0];
            Cognome = colonne[1]; 
            Email = colonne[2];
            Tipo = colonne[3];
            
        }
    }
   

}
