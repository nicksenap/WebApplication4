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
            var stolid = new List<string>();
            foreach (var usr in _db.Users)
            {
                stolid.Add(usr.Id);
            }
            ;

            return stolid;

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

                var gender = JObject.Parse(res)["results"][0]["gender"];
                var email = JObject.Parse(res)["results"][0]["email"];
                var phone = JObject.Parse(res)["results"][0]["phone"];
                var first = JObject.Parse(res)["results"][0]["name"]["first"];
                var last = JObject.Parse(res)["results"][0]["name"]["last"];
                var pictureUrl = JObject.Parse(res)["results"][0]["picture"]["large"];
                var title = JObject.Parse(res)["results"][0]["name"]["title"];
                var street = JObject.Parse(res)["results"][0]["location"]["street"];
                var city = JObject.Parse(res)["results"][0]["location"]["city"];
                var state = JObject.Parse(res)["results"][0]["location"]["state"];
                var postcode = JObject.Parse(res)["results"][0]["location"]["postcode"];
                var nat = JObject.Parse(res)["results"][0]["nat"];


                P2PUser user = new P2PUser {
                    UserName = email.ToString(),
                    Email = email.ToString(),
                    PersoNunmber = (2017 - rnd.Next(15,80)).ToString() + rnd.Next(10, 12).ToString() + rnd.Next(10, 30) + "-" +
                                   rnd.Next(1000, 9999),
                    FirstName = first.ToString(),
                    LastName = last.ToString(),
                    Type = (UserType) (DateTime.Now.Second % 2),
                    PhoneNumber = phone.ToString(),
                    pictureUrl = pictureUrl.ToString(),
                    UCScore = rnd.Next(0, 30),
                    HasInfo = false,
                };
                var password = "Lendify69*";
                var resultti = await UserManager.CreateAsync(user, password);

                foreach (var uzer in _db.Users.Where(x => x.HasInfo == false).ToList())
                {

                    foreach (var type in _db.UserInfoTypes.ToList())
                    {
                        string data = "";
                        if (type.Id == 2)
                        {
                            data = gender.ToString();
                        }
                        else if (type.Id == 3)
                        {
                            data = rnd.Next(0, 1) == 0 ? "gift" : "ogift";
                        }
                        else if (type.Id == 4)
                        {
                            data = rnd.Next(0, 3).ToString();
                        }
                        else if (type.Id == 5)
                        {
                            data = rnd.Next(0, 5).ToString();
                        }
                        else if (type.Id == 6)
                        {
                            data = title.ToString();
                        }
                        else if (type.Id == 7)
                        {
                            data = street.ToString();
                        }
                        else if (type.Id == 8)
                        {
                            data = city.ToString();
                        }
                        else if (type.Id == 9)
                        {
                            data = state.ToString();
                        }
                        else if (type.Id == 10)
                        {
                            data = postcode.ToString();
                        }
                        else if (type.Id == 11)
                        {
                            data = nat.ToString();
                        }

                        UserInfoData UID = new UserInfoData()
                        {
                            P2PUser = uzer,
                            UserInfoType = type,
                            Data = data,

                        };
                        _db.UserInfoData.Add(UID);
                        
                    }
                    uzer.HasInfo = true;
                    _db.SaveChanges();
                }


                response.Dispose();
                
                }

            
            return View("Index");
        }

        [HttpPost]
        public ActionResult CreateLoans()
        {
            var Loaners = _db.Users.Where(x => x.Type == UserType.Ioaner).ToList();
            var rates = _db.Rates.Where(x => x.Type == LoanRateType.APR).ToList();

            foreach (var loaner in Loaners)
            {
                _db.LoanApplications.Add(new LoanApplication
                {
                    Months = rnd.Next(12, 24),
                    User = loaner,
                    Amount = rnd.Next(10000, 80000),
                    UCScore = loaner.UCScore,
                    APR = rates.Single(x => x.P2PScoreMin <= loaner.UCScore && x.P2PScoreMax >= loaner.UCScore).Value,
                    isSigned = rnd.Next(100) <= 50 ? true : false,
                    isVerified = rnd.Next(100) <= 50 ? true : false,
                    Flag = (CreditFlag)rnd.Next(0 ,6),
                    Status = (LoanApplicationStatus)rnd.Next(0,3),
                    BaseCurrency = rates.Single(x => x.P2PScoreMin <= loaner.UCScore && x.P2PScoreMax >= loaner.UCScore).BaseCurrency,

                }
                
                );
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