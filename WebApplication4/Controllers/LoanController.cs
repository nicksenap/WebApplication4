using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using WebApplication4.DAL;

namespace WebApplication4.Controllers
{
    public class LoanController : Controller
    {
        private readonly P2PDbContext _db = new P2PDbContext();

        //Get: Loan
        public ActionResult Index()
        {   
            // Check if user is logged in;
            bool isLoggedIn = (System.Web.HttpContext.Current.User != null) &&
                              System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            if (isLoggedIn)
            {
                var user = User.Identity.GetUserId();

                var los = _db.LoanApplications.OrderBy(q => q.Id).ToList();

                string currentUserId = User.Identity.GetUserId();

                P2PUser currentUser = _db.Users.FirstOrDefault(x => x.Id == currentUserId);

                IQueryable<LoanApplication> loanApps = _db.LoanApplications.Where(l => l.User.Id == currentUserId);
               
                return View(loanApps.ToList());
            }
            else
            {
                var res = RedirectToAction("Login", "Account");

                return res;
            }
            
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
                    string currentUserId = User.Identity.GetUserId();

                    P2PUser currentUser = _db.Users.FirstOrDefault(x => x.Id == currentUserId);

                    loanApplication.User = currentUser;

                    _db.Users.FirstOrDefault(x => x.Id == currentUserId).Type = UserType.Ioaner;

                    _db.Users.FirstOrDefault(x => x.Id == currentUserId).Status = UserStatus.Active;

                    _db.LoanApplications.Add(loanApplication);
                    
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



    
