﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_ordre_mission.Models
{
    public class Grades
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idgrades { get; set; }
        [Required]
        public string Nom { get; set; }
        public string NomComplet { get; set; }
        public string Nomarabe { get; set; }

        [ForeignKey("IdCadre")]
        public virtual Cadre Cadre { get; set; }

        public virtual IList<Personnel> Personnels { get; set; }
    }
}
