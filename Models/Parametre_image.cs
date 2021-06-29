using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_ordre_mission.Models
{
    public class Parametre_image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_param_img { get; set; }
        public string type { get; set; }
        public string footer { get; set; }
        public string header { get; set; }
        public string background { get; set; }
    }
}
