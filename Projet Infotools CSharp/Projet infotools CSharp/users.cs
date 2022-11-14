using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_infotools_CSharp
{
    class users
    {
        public int NumUser { get; set; }

        public string EmailUser { get; set; }

        public string MdpUser { get; set; }

        //Ici on met en place les colonnes de notre datagird qui seront utilisées plus tard lorsqu'il faudra ajouter, modifier ou supprimer les données d'un client dans le datagrid.
        public users(int numuser, string emailuser, string mdpuser)
        {
            NumUser = numuser;
            EmailUser = emailuser;
            MdpUser = mdpuser;
        }
    }
}
