using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_ordre_mission.Models
{
    public class OrdreVirement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOrdreVirement { get; set; }

        public String numero { get; set; }

        public int idAdmin { get; set; }

        public String numeroCompte { get; set; }
        [ForeignKey("IdOrdrePayment")]

        [Required]
        public virtual OrdrePayment orderPayment { get; set; }
        [ForeignKey("IdOrderPaiement")]

        [Required]
        public virtual OrdrePaiement orderpaiment { get; set; }
    }
}
