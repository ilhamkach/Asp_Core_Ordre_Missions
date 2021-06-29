using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_ordre_mission.Models
{
    public class OrdrePaiement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOrderPaiement { get; set; }
        public double totalDeplacement { get; set; }
        public double tatalKilo { get; set; }
        [ForeignKey("idOrdreVirement")]
        public virtual OrdreVirement ordreVirement { get; set; }
        [ForeignKey("idOrdremission")]
        public int id_mission { get; set; }
        [Required]
        public virtual OrdreMission ordermission { get; set; }
    }
}
