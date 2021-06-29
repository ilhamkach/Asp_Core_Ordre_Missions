using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_ordre_mission.Models
{
    public class OrdrePayment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOrdrePayment { get; set; }

        //Amount For Hotel and food
        public double totalDeplacement { get; set; }

        //Amount for Fuel
        public double tatalKilo { get; set; }
        [ForeignKey("idOrdreVirement")]
        public virtual OrdreVirement ordreVirement { get; set; }

        [Required]
        [ForeignKey("idOrdremission")]
        public virtual OrdreMission ordermission { get; set; }
    }
}
