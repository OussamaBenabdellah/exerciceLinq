using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoLinq
{
    public class Personne
    {
        public string Nom { get; set; } = "";
        public string PreNom { get; set; } = "";
        public DateTime? DateDeNaissance { get; set; } 
        public int TailleCm { get; set; }
        public Genre Genres { get; set; }
    }
}
