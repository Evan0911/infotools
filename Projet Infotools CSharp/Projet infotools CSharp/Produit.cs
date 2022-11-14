using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_infotools_CSharp
{
    class Produit
    {
        public int NumProd { get; set; }

        public string NomProd { get; set; }

        public decimal Prix { get; set; }

        //Ici on met en place les colonnes de notre datagird qui seront utilisées plus tard lorsqu'il faudra ajouter, modifier ou supprimer les données d'un client dans le datagrid.
        public Produit(int numprod, string nomprod, decimal prix)
        {
            NumProd = numprod;
            NomProd = nomprod;
            Prix = prix;
        }
    }
}
