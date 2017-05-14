using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using WebApplication4.Models;
using WebApplication4.DAL;
using Microsoft.AspNet.Identity;

namespace WebApplication4.Controllers
{
    public class LoanController : Controller
    {
        private P2PDbContext db = new P2PDbContext();

        //Get: Loan
        public ActionResult Index()
        {
            var user = User.Identity.GetUserId();
            var los = db.LoanApplications.OrderBy(q => q.Id).ToList();

            //IQueryable loansQueryable = db.LoanApplications.Where(l => l == user);
            
            
            // ViewBag.message = user;
            //Console.WriteLine(user);
            // db.LoanApplications.SqlQuery("SELECT * FROM LoanApplication");
            
            return View(los);
        }

        //
        
        // GET: Loan/Apply
        public ActionResult Apply()
        {

            return View();
        }
        

        // POST: Loan/Apply
        [HttpPost]
        public ActionResult Apply([Bind(Include = "Amount, Months, P2PUserId")] LoanApplication loanApplication)
        {
            try
            {
                if (ModelState.IsValid)
                {   
                    db.LoanApplications.Add(loanApplication);
                    
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (RetryLimitExceededException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View();


        }

    }
}



    
