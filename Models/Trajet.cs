using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_ordre_mission.Models
{
    public class Trajet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_trajet { get; set; }
        public String villeDepart { get; set; }
        public String villeArrivee { get; set; }
        public int distance { get; set; }
        public virtual IList<OrdreMission> OrdreMissions { get; set; }
    }
}
