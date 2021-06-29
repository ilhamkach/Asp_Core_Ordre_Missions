using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_ordre_mission.Models
{
    public class grilleTb
    {
        public int jour;
        public bool repasMidi;
        public bool repasSoir;

        public grilleTb(int jour, bool repasMidi, bool repasSoir)
        {
            this.jour = jour;
            this.repasMidi = repasMidi;
            this.repasSoir = repasSoir;
        }
    }
}
