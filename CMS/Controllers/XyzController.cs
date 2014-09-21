using CMS.Models;
using CMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Controllers
{
    public class XyzController : Controller
    {
        private CMSContext DB = new CMSContext();

        // GET: Xyz
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Abc() {

            var subjects = DB.Subjects.ToList();
            return View(subjects);


            //Subject sc1 = new Subject();
            //sc1.SubjectName = "Campus";
            //sc1.SubjectPosition = 1;
            //sc1.SubjectVisible = true;

           
            //Page pg1 = new Page();
            //pg1.SubjectId = 1;
            //pg1.PageName = "Life";
            //pg1.PagePosition = 3;
            //pg1.PageVisible = true;

            //Page pg2 = new Page();
            //pg2.SubjectId = 1;
            //pg2.PageName = "Liberary";
            //pg2.PagePosition = 3;
            //pg2.PageVisible = true;
        

            //List<Page> pgs=new List<Page>();
            //pgs.Add(pg1);
            //pgs.Add(pg2);

            //SubjectPage subpg=new SubjectPage();
            //subpg.pg = pgs;
            //subpg.subj = sc1;
           


            
        }
    }
}