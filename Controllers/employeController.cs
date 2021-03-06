using GestionAbscences.Data;
using GestionAbscences.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace GestionAbscences.Controllers
{
    public class employeController : Controller
    {
         private GestionAbscencesEntities1 db = new GestionAbscencesEntities1();

        // GET: employe
        public ActionResult Index()
        {
 
            return View();
        }

        public ActionResult changePass()
        {

            return View();
        }

        public ActionResult historique()
        {
            employe e = new employe();
     
            string x = Session["matricule"].ToString();

            int x1 = int.Parse(x);


            var demandeConge = db.demandeconge.Include(d => d.employe).Include(d => d.typeconge).Where(p => p.IdEmploye == x1);

                return View(demandeConge.ToList());
            
            
        }





        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Dashboard1()
            {
            
                demandeconge demande = new demandeconge();
               

                string employeIdEmploye1 = Request["matricule"];
                string typeCongeIdTypeconge = Request.Form["typeCongeIdTypeconge"];
                string dateDebut = Request["dateDebut"] + " " + Request["timeDebut"];
                string dateFin = Request["dateFin"] + " " + Request["timeFin"];

                DateTime dc = DateTime.Now;

           
                if (typeCongeIdTypeconge.Equals("reliquat"))
                {
                    demande.IdtypeConge = 1;
                }
                else if (typeCongeIdTypeconge.Equals("1 ere tranche"))
                {
                    demande.IdtypeConge = 2;
                }
                else if (typeCongeIdTypeconge.Equals("2 eme tranche"))
                {
                    demande.IdtypeConge = 3;
                }

                demande.ValidationN1 = "En cours";
                demande.ValidationN2 = "En cours";
                demande.IdEmploye = int.Parse(employeIdEmploye1);

                demande.DateDebut = Convert.ToDateTime(dateDebut);
                demande.DateFin = Convert.ToDateTime(dateFin);
                demande.DateDC = dc;

                db.demandeconge.Add(demande);


                db.SaveChanges();

                //ViewBag.Message = "la demande est enregistré !";

                return RedirectToAction("historique", "employe");
           
            }
        }
    }


