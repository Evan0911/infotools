using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_infotools_CSharp
{
    class rdv
    {

        public rdv (int Id, DateTime DateRDV, client Cli, commercial Com)
        {
            id = Id;
            dateRDV = Convert.ToDateTime(DateRDV.ToString("dd/MM/yyyy HH:mm:ss"));
            cli = Cli;
            com = Com;
        }

        public int id { get; set; }
        public DateTime dateRDV { get; set; }
        public client cli { get; set; }
        public commercial com { get; set; }
    }
}
