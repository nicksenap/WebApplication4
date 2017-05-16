using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using WebApplication4.DAL;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Newtonsoft.Json.Linq;
using WebApplication4;

namespace P2PSystem.Controllers
{
    public class HomeController : Controller
    {
        private bool rich;

        private ApplicationUserManager _userManager;

        private Random rnd = new Random();

        private List<string> list = new List<string>();

        private List<string> loaner = new List<string>();

        private List<string> Investor = new List<string>();

        private readonly P2PDbContext _db = new P2PDbContext();

       

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }



        public ActionResult Index()
        {

            bool isLoggedIn = (System.Web.HttpContext.Current.User != null) &&
                              System.Web.HttpContext.Current.User.Identity.IsAuthenticated;

            var user = User.Identity.GetUserId();

            var los = _db.LoanApplications.OrderBy(q => q.Id).ToList();

            string currentUserId = User.Identity.GetUserId();

            P2PUser currentUser = _db.Users.FirstOrDefault(x => x.Id == currentUserId);
            if (isLoggedIn && User.IsInRole("Investor"))
            {

                ViewBag.Invest = true;
                ViewBag.loan = false;
            }
            else if (isLoggedIn && User.IsInRole("Loan"))
            {
                ViewBag.loan = true;
                ViewBag.Invest = false;
            }
            else
            {
                ViewBag.loan = true;
                ViewBag.invest = true;
            }
        
        return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public List<string> LISTOFID()
        {
            var listofid = new List<string>();
            int count = 0;
            foreach (var usr in _db.Users)
            {
                listofid.Add(usr.Id);
                count += 1;
            }
            ;

            return listofid;

        }

        [HttpPost]
        public async Task<ActionResult> CreateUsers()
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(_db));
           
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://randomuser.me/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetAsync("/api").Result;
            string res = "";
            using (HttpContent content = response.Content)
            {
                // ... Read the string.
                Task<string> result = content.ReadAsStringAsync();
                res = result.Result;

                var email = JObject.Parse(res)["results"][0]["email"];
                var phone = JObject.Parse(res)["results"][0]["phone"];
                var first = JObject.Parse(res)["results"][0]["name"]["first"];
                var last = JObject.Parse(res)["results"][0]["name"]["last"];

                P2PUser user = new P2PUser {UserName = email.ToString(),

                    Email = email.ToString(),
                    PersoNunmber = (2017 - rnd.Next(15,80)).ToString() + rnd.Next(10, 12).ToString() + rnd.Next(10, 30) + "-" +
                                   rnd.Next(1000, 9999),
                    FirstName = first.ToString(),
                    LastName = last.ToString(),
                    Type = (UserType) (DateTime.Now.Second % 2),
                    PhoneNumber = phone.ToString(),
                };
               
                var password = "?9Rec+o9Z7tF";
                //var ls = LISTOFID();
                var resultti = await UserManager.CreateAsync(user, password);

                response.Dispose();
                
                }
            
            return View("Index");
        }

        [HttpPost]
        public ActionResult CreateLoans()
        {
            var Loaners = _db.Users.Where(x => x.Type == UserType.Ioaner);
            foreach (var loaner in Loaners)
            {
                _db.LoanApplications.Add(new LoanApplication
                {
                    Months = rnd.Next(12, 24),
                    User = loaner,
                    Amount = rnd.Next(10000, 80000),
                    

                });
            }

            _db.SaveChanges();

            return View("Index");
        }

        [HttpPost]
        public ActionResult CreateInvestment()
        {
            var Investors = _db.Users.Where(x => x.Type == UserType.Investor);
            Random rnd = new Random();
            foreach (var investor in Investors)
            {
                _db.InvestApplications.Add(new InvestmentApplication
                {
                    Amount = rnd.Next(10000, 1000000),
                    User = investor,
                    Months = rnd.Next(12, 64),
                  

                });
            }
            

            _db.SaveChanges();

            return View("Index");
        }


    }
}