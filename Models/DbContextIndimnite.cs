using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_ordre_mission.Models
{
    public class DbContextIndimnite : DbContext
    {
        public DbContextIndimnite():base()
        {
        }

        public DbContextIndimnite(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<Personnel> personnels { get; set; }
        public DbSet<Cadre> cadres { get; set; }
        public DbSet<Corps> corp { get; set; }
        public DbSet<Grades> grade { get; set; }
        public DbSet<OrdreMission> ordremission { get; set; }
        public DbSet<OrdrePaiement> ordrepaiement { get; set; }
        public DbSet<OrdreVirement> ordrevirement { get; set; }
        public DbSet<Trajet> trajet { get; set; }
        public DbSet<Parametre_voiture> param_voiture { get; set; }
        public DbSet<Parameter> parametre { get; set; }
        public DbSet<Parametre_paiement> param_paiement { get; set; }
        public DbSet<Parametre_image> parametre_img { get; set; }
    }
}
