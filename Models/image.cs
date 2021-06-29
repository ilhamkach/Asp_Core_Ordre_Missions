using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
namespace gestion_ordre_mission.Models
{
    public class image
    {
        public IFormFile footer { get; set; }
        public IFormFile background { get; set; }
        public IFormFile header { get; set; }
    }
}
