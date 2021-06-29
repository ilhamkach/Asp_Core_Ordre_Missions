using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_ordre_mission.Models
{
    public class OrdreMission
    {
        internal string name_respo_mission="";

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idOrdremission { get; set; }

        public String numero { get; set; }

        public bool etat { get; set; }

        public DateTime dateDepart { get; set; }

        public DateTime dateArrivee { get; set; }

        public String heureDepart { get; set; }

        public String heureArrivee { get; set; }

        public int echlon { get; set; }

        public String matricule { get; set; }

        public String grade { get; set; }

        public String objetDepart { get; set; }

        public String moyenTransport { get; set; }

        public int nombreCheuvaux { get; set; }

        public float montant_total { get; set; }

        public virtual List<OrdrePaiement> ordrePaiement { get; set; }
        public virtual List<OrdrePayment> ordrePayment { get; set; }
        [Required]
        [ForeignKey("IdPers")]
        public virtual Personnel personel { get; set; }
        [Required]
        [ForeignKey("id_trajet")]
        public virtual Trajet trajet { get; set; }
    }
}
