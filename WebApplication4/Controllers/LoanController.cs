using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using WebApplication4.DAL;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class LoanController : Controller
    {   
        private Random rnd = new Random();
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
        public ActionResult Apply(LoanViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string currentUserId = User.Identity.GetUserId();
                    LoanApplication application = new LoanApplication()
                    {
                        Amount = model.Amount,
                        Months = model.Months,
                    };

                    P2PUser currentUser = _db.Users.FirstOrDefault(x => x.Id == currentUserId);

                    application.User = currentUser;

                    _db.LoanApplications.Add(application);

                    _db.SaveChanges();

                    foreach (var type in _db.UserInfoTypes.Where(x => x.Status == UserInfoTypeStatus.Active).ToList())
                    {
                        string data = "";

                        if (type.Id == 2)
                        {
                            data = rnd.Next(0, 1) == 0 ? "male" : "female";
                        }
                        else if (type.Id == 3)
                        {
                            data = model.MaritalStatus.ToString();
                        }
                        else if (type.Id == 4)
                        {
                            data = rnd.Next(0, 3).ToString(); // Cars
                        }
                        else if (type.Id == 5) // Child 
                        {
                            data = rnd.Next(0, 5).ToString();
                        }
                        else if (type.Id == 12) // Job Status
                        {
                            data = model.JobStatus.ToString();
                        }
                        else if (type.Id == 13) // Living Status
                        {
                            data = model.LivingStatus.ToString();
                        }
                        else if (type.Id == 14) // Loan Category
                        {
                            data = model.LoanCategory.ToString();
                        }
                        else if (type.Id == 18) // JobType
                        {
                            data = model.JobType.ToString();
                        }
                        else if (type.Id == 19) // Income
                        {
                            data = rnd.Next(6000, 60000).ToString();
                        }
                        else if (type.Id == 20) // Expenses
                        {
                            data = rnd.Next(3000, 20000).ToString();
                        }
                        else if (type.Id == 21) // Liabilities
                        {
                            data = rnd.Next(3000, 20000).ToString();
                        }
                        else if (type.Id == 22) //  Housing Cost
                        {
                            data = rnd.Next(3000, 20000).ToString();
                        }
                        else if (type.Id == 23) //  TransportCost
                        {
                            data = rnd.Next(3000, 20000).ToString();
                        }
                        else if (type.Id == 24) // Living Costs
                        {
                            data = rnd.Next(3000, 20000).ToString();
                        }
                        else if (type.Id == 25) // Housing Since Date
                        {
                            data = DateTime.UtcNow.AddDays(rnd.Next(90)).ToString();

                        }
                        else if (type.Id == 26) // Housing Since Date
                        {
                            data = DateTime.UtcNow.AddDays(rnd.Next(90)).ToString();

                        }
                        UserInfoData UID = new UserInfoData()
                        {
                            P2PUser = currentUser,
                            UserInfoType = type,
                            Data = data,

                        };

                        _db.UserInfoData.Add(UID);
                    }
                    _db.SaveChanges();


                        // var jt = model.JobType;

                        // _db.Users.FirstOrDefault(x => x.Id == currentUserId).Type = UserType.Ioaner;

                        // _db.Users.FirstOrDefault(x => x.Id == currentUserId).Status = UserStatus.Active;




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



    
