using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_infotools_CSharp
{
    class commercial
    {
        public commercial (int Id, string Prenom, string Nom, string Adresse, string CP, string Ville, string Email)
        {
            id = Id;
            nom = Nom;
            prenom = Prenom;
            adresse = Adresse;
            cp = CP;
            ville = Ville;
            email = Email;
        }

        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adresse { get; set; }
        public string cp { get; set; }
        public string ville { get; set; }
        public string email { get; set; }
    }
}
