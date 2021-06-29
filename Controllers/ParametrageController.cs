using gestion_ordre_mission.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_ordre_mission.Controllers
{
    public class ParametrageController : Controller
    {

        private readonly DbContextIndimnite db;

        public ParametrageController(DbContextIndimnite context)
        {
            db = context;
        }

        // GET: Parametrage
        [HttpGet]
        public ActionResult Index()
        {
            //recuperer le nom d'utilisateur 
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(image image_upload)
        {
            Parametre_image param_img = db.parametre_img.Find(1);

            param_img.header = SaveToPhysicalLocation(image_upload.header);
            param_img.footer = SaveToPhysicalLocation(image_upload.footer);
            param_img.background = SaveToPhysicalLocation(image_upload.background);
            db.SaveChanges();
            ViewBag.messageSucces = "les Modification sont bien enregistres ";
            return View();
        }
        public string SaveToPhysicalLocation(IFormFile file)
        {
            if (file.Length > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
                using(var stream=new FileStream(path, FileMode.Create))
                {
                    file.CopyToAsync(stream);
                }
               
                return path;
            }
            return string.Empty;
        }

    }
}
