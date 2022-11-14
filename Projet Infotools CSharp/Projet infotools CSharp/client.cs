using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_infotools_CSharp
{
    class client
    {
        public int id { get; set; }

        public string prenom { get; set; }

        public string nom { get; set; }

        public string telephone { get; set; }

        public string email { get; set; }
        public string adresse { get; set; }
        public string cp { get; set; }
        public string ville { get; set; }
        //Ici on met en place les colonnes de notre datagird qui seront utilisées plus tard lorsqu'il faudra ajouter, modifier ou supprimer les données d'un client dans le datagrid.
        public client (int Id, string Pre,string Nom,string Tel,string Mail,string Adr,string CP,string Ville)
        {
            id = Id;
            prenom = Pre;
            nom = Nom;
            telephone = Tel;
            email = Mail;
            adresse = Adr;
            cp = CP;
            ville = Ville;
        }
    }
}
