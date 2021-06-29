using gestion_ordre_mission.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace gestion_ordre_mission.Controllers
{
    public class HomeController : Controller
    {

        private readonly DbContextIndimnite db;

        public HomeController(DbContextIndimnite context)
        {
            db = context;
        }

        //statistique pour gestion économique

        public JsonResult BarChartDataEf()
        {
            //retourné le count des missions
            var count_mission = db.ordremission.GroupBy(p => p.dateArrivee.Year)
             .Select(g => new
             {
                 Count = g.Count()
             });
            //retourner une liste des année
            var year = (from s in db.ordremission select s.dateArrivee.Year).Distinct();


            var data = year.ToList();
            var data1 = count_mission.ToList();
            Models.Chart _Chart = new Models.Chart();
            _Chart.labels = data.Select(x => x).ToArray();
            _Chart.datasets = new List<Datasets>();
            List<Datasets> _dataset = new List<Datasets>();
            _dataset.Add(new Datasets()
            {
                Label = "year",
                data = data1.Select(x => x.Count).ToArray(),
                backgroundColor = new String[] { "#5590e8", "#5590e8", "#5590e8" },
                borderColor = new String[] { "#1ce2ed", "#1ce2ed", "#1ce2ed" },
                borderWidth = "1"
            });
            _Chart.datasets = _dataset;
            return Json(_Chart, new Newtonsoft.Json.JsonSerializerSettings());
        }

        //statistique pour gestion personnel
        public JsonResult BarChartDataEfPersonnel()
        {
            var id_utilisateur = (int)HttpContext.Session.GetInt32("idpersonnel");
            var Year = (from s in db.ordremission where s.personel.IdPers == id_utilisateur select s.dateArrivee.Year).Distinct();
            //retourner le count des mission par année de l'utilisateur connecté
            var countOrdreMissionPersonnel = db.ordremission
               .Where(p => p.personel.IdPers == id_utilisateur)
               .GroupBy(p => p.dateArrivee.Year)
               .Select(g => new { count = g.Count() });

            var data = Year.ToList();
            var data1 = countOrdreMissionPersonnel.ToList();
            Models.Chart _Chart = new Models.Chart();
            _Chart.labels = data.Select(x => x).ToArray();
            _Chart.datasets = new List<Datasets>();
            List<Datasets> _dataset = new List<Datasets>();
            _dataset.Add(new Datasets()
            {
                Label = "Year",
                data = data1.Select(x => x.count).ToArray(),
                backgroundColor = new String[] { "#5590e8", "#5590e8", "#5590e8" },
                borderColor = new String[] { "#1ce2ed", "#1ce2ed", "#1ce2ed" },
                borderWidth = "1"
            });
            _Chart.datasets = _dataset;
            return Json(_Chart, new Newtonsoft.Json.JsonSerializerSettings());
        }

        //GET Index
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("isConnected") == null)
            {
                return RedirectToAction("login");
            }
            else
            {
                //retourner le nombre de ligne de la table utilisateur
                var count_utilisateur = (from o in db.personnels select o).Count();
                ViewBag.count_utilisateur = count_utilisateur;
                //retourner le nombre de ligne de la table ordreVirement
                var count_virement = (from o in db.ordrevirement select o).Count();
                ViewBag.count_virement = count_virement;
                //retourner le nombre de ligne des mission approuvé la table ordremission
                var count_mission_approuve = db.ordremission.Count(t => t.etat == true);
                ViewBag.count_mission_approuve = count_mission_approuve;
                //retourner le nombre de ligne des mission approuvé la table ordremission
                var count_mission_non_approuve = db.ordremission.Count(t => t.etat == false);
                ViewBag.count_mission_non_approuve = count_mission_non_approuve;
                ViewBag.nomUtilisateur = HttpContext.Session.GetString("nomeconomique");

                return View();
            }

        }

        //GET Index Personnel
        public IActionResult IndexPersonnel()
        {
            if (HttpContext.Session.GetString("isConnected")== null)
            {
                return RedirectToAction("login");
            }
            else
            {
                var id_utilisateur = (int)HttpContext.Session.GetInt32("idpersonnel");
                //retourner le nombre de ligne de la table ordreVirement de l'utilisateur connecté
                var count_virement_personnel = db.ordrevirement.Count(p => p.orderpaiment.ordermission.personel.IdPers == id_utilisateur);
                ViewBag.count_virement_personnel = count_virement_personnel;
                //retourner le nombre de ligne des mission approuvé la table ordremission de l'utilisateur connecté
                var count_mission_approuve_personnel = db.ordremission.Count(p => p.personel.IdPers == id_utilisateur && p.etat == true);
                ViewBag.count_mission_approuve_personnel = count_mission_approuve_personnel;
                //retourner le nombre de ligne des mission approuvé la table ordremission de l'utilisateur connecté
                var count_mission_non_approuve_personnel = db.ordremission.Count(p => p.personel.IdPers == id_utilisateur && p.etat == false);
                ViewBag.count_mission_non_approuve_personnel = count_mission_non_approuve_personnel;
                //recuperation du nom d'utilisateur
                ViewBag.nomUtilisateur = HttpContext.Session.GetString("nompersonnel");
                return View();

            }



        }

        //login traitement

        public IActionResult Login()
        {
            HttpContext.Session.SetString("nompersonnel", " ");
            HttpContext.Session.SetInt32("idpersonnel", 0);
            HttpContext.Session.SetString("isConnected", " ");

          
            return View();

        }


        [HttpPost]
        public IActionResult Authorize(Personnel pers)
        {
          
                Personnel userdetails = db.personnels.Where(a => a.Username == pers.Username && a.Password == pers.Password).FirstOrDefault();

                if (userdetails == null)
                {
                    ViewBag.error = "Verifier vos information!";

                    return View("Login");

                }
                else
                {

                    if (CheckRole(userdetails) == 1)
                    {
                        HttpContext.Session.SetString("nompersonnel", userdetails.Nom + " " + userdetails.Prenom );
                        HttpContext.Session.SetInt32("idpersonnel", userdetails.IdPers);
                        HttpContext.Session.SetString ("isConnected", "true");

                    



                        return RedirectToAction("IndexPersonnel", "Home");

                    }
                    else if (CheckRole(userdetails) == 0)
                    {
                     
                        HttpContext.Session.SetString("nomeconomique", userdetails.Nom + " " + userdetails.Prenom);
                        HttpContext.Session.SetString("isConnected", "true");
                        return RedirectToAction("Index", "Home");

                    }
                    else
                    {
                        ViewBag.error = "les informations sont incorrect !";

                        return View("Login");
                    }


                }
            

        }
        public int CheckRole(Personnel pers)
        {


          
                var userdetails = db.personnels.Where(a => a.Username == pers.Username && a.Password == pers.Password).FirstOrDefault();

                if (userdetails.Role == "personnel")
                {
                    return 1;

                }
                else if (userdetails.Role == "economique")
                {
                    return 0;

                }
                else
                {
                    return -1;
                }


            }
        
        //Afficher la liste des ordres de mission d'un personnel

        public IActionResult ListMesOrdresMissions()
        {
            if (HttpContext.Session.GetString("isConnected") == null)
            {
                return RedirectToAction("login");
            }
            else
            {
                
                int idperson = (int)HttpContext.Session.GetInt32("idpersonnel");
                List<OrdreMission> listeordresmissions = db.ordremission.Where(x => x.personel.IdPers == idperson).ToList();

                return View(listeordresmissions);
            }
        }

        //Afficher la liste des ordres de virement d'un personnel


        public IActionResult ListOrdreVirement()
        {
            if (HttpContext.Session.GetString("isConnected") == null)
            {
                return RedirectToAction("login");
            }
            else
            {
                DbContextIndimnite db1 = new DbContextIndimnite();
                int personid = (int)HttpContext.Session.GetInt32("idpersonnel");
                List<OrdreVirement> listeordresmissions = db.ordrevirement.Where(x => x.orderpaiment.ordermission.personel.IdPers == personid).ToList();

                return View(listeordresmissions);
            }

        }

        public IActionResult error()
        {
            return View();
        }
    }
}

