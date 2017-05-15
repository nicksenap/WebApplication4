using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using WebApplication4.DAL;

namespace WebApplication4.Controllers
{
    public class InvestmentController : Controller
    {
        private readonly P2PDbContext _db = new P2PDbContext();
        // GET: Investment
        public ActionResult Index()
        {
      
        bool isLoggedIn = (System.Web.HttpContext.Current.User != null) &&
                          System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            if (isLoggedIn)
        {
            var user = User.Identity.GetUserId();

            var los = _db.InvestApplications.OrderBy(q => q.Id).ToList();

            var currentUserId = User.Identity.GetUserId();

            var currentUser = _db.Users.FirstOrDefault(x => x.Id == currentUserId);

            var InvestApps = _db.InvestApplications.Where(l => l.User.Id == currentUserId);
               
            return View(InvestApps.ToList());
        }
        else
        {
            var res = RedirectToAction("Login", "Account");

            return res;
        }

            return View();
        }

        public ActionResult Apply([Bind(Include = "Amount, Months, P2PUserId")] InvestmentApplication investmentApplication)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string currentUserId = User.Identity.GetUserId();

                    P2PUser currentUser = _db.Users.FirstOrDefault(x => x.Id == currentUserId);

                    investmentApplication.User = currentUser;

                    _db.Users.FirstOrDefault(x => x.Id == currentUserId).Type = UserType.Investor;

                    _db.Users.FirstOrDefault(x => x.Id == currentUserId).Status = UserStatus.Active;

                    _db.InvestApplications.Add(investmentApplication);

                    _db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            catch (RetryLimitExceededException)
            {
                ModelState.AddModelError("", "Unable to save changes. " +
                                             "Try again, and if the problem " +
                                             "persists see your system administrator.");
            }
            return View();
        }

    }
}