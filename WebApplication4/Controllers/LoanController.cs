using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json.Linq;
using WebApplication4.DAL;
using WebApplication4.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WebApplication4.Controllers
{
    public class LoanController : Controller
    {
        private Random rnd = new Random();
        private readonly P2PDbContext _db = new P2PDbContext();
        public string j;
        // public List<JToken> jlist = new List<JToken>();

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
        [HttpGet]
        public ActionResult Apply()
        {
            

            var livingStatusType = _db.UserInfoTypes.Single(z => z.Name == "LivingStatus");

            var livingStatusdatalist =
                JsonConvert.DeserializeObject<LoanViewModel.EnumDynamicType>(livingStatusType.Properties);

            var jobStatusType = _db.UserInfoTypes.Single(z => z.Name == "JobStatus");

            var jobStatusdatalist =
                JsonConvert.DeserializeObject<LoanViewModel.EnumDynamicType>(jobStatusType.Properties);

            var LoanCategoryType = _db.UserInfoTypes.Single(z => z.Name == "LoanCategory");

            var LoanCategorydatalist =
                JsonConvert.DeserializeObject<LoanViewModel.EnumDynamicType>(LoanCategoryType.Properties);

            var CivilStatusType = _db.UserInfoTypes.Single(z => z.Name == "CivilStatus");

            var CivilStatusdatalist =
                JsonConvert.DeserializeObject<LoanViewModel.EnumDynamicType>(CivilStatusType.Properties);

            var JobTypeType = _db.UserInfoTypes.Single(z => z.Name == "JobType");

            var JobTypedatalist =
                JsonConvert.DeserializeObject<LoanViewModel.EnumDynamicType>(JobTypeType.Properties);



            var loanAppModel = new LoanViewModel();

            loanAppModel.LivingStatusItems = livingStatusdatalist.English;
            loanAppModel.CivilStatusItems = CivilStatusdatalist.English;
            loanAppModel.JobStatusItems = jobStatusdatalist.English;
            loanAppModel.LoanCategoryItems = LoanCategorydatalist.English;
            loanAppModel.JobTypeItems = JobTypedatalist.English;



            return View(loanAppModel);

        }




        // POST: Loan/Apply
        [HttpPost]
        public ActionResult Apply(LoanViewModel model)
        {
            // model.LivingStatusItems = new List<SelectListItem>();
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

               

                var StatusType1 = _db.UserInfoTypes.Single(z => z.Name == "LivingStatus");

                var data1 = model.LivingStatus.ToString();

                UserInfoData UID1 = new UserInfoData()
                {
                        P2PUser = currentUser,
                        UserInfoType = StatusType1,
                        Data = data1
                };

                var StatusType2 = _db.UserInfoTypes.Single(z => z.Name == "CivilStatus");

                var data2 = model.CivilStatus.ToString();

                UserInfoData UID2 = new UserInfoData()
                {
                    P2PUser = currentUser,
                    UserInfoType = StatusType2,
                    Data = data2
                };

                var StatusType3 = _db.UserInfoTypes.Single(z => z.Name == "JobStatus");

                var data3 = model.JobStatus.ToString();

                UserInfoData UID3 = new UserInfoData()
                {
                    P2PUser = currentUser,
                    UserInfoType = StatusType3,
                    Data = data3
                };

                var StatusType4 = _db.UserInfoTypes.Single(z => z.Name == "JobType");

                var data4 = model.JobType.ToString();

                UserInfoData UID4 = new UserInfoData()
                {
                    P2PUser = currentUser,
                    UserInfoType = StatusType4,
                    Data = data4
                };

                var StatusType5 = _db.UserInfoTypes.Single(z => z.Name == "LoanCategory");

                var data5 = model.LoanCategory.ToString();

                UserInfoData UID5 = new UserInfoData()
                {
                    P2PUser = currentUser,
                    UserInfoType = StatusType5,
                    Data = data5
                };


                _db.UserInfoData.Add(UID1);
                _db.UserInfoData.Add(UID2);
                _db.UserInfoData.Add(UID3);
                _db.UserInfoData.Add(UID4);
                _db.UserInfoData.Add(UID5); 
                _db.SaveChanges();

                return RedirectToAction("Index","Home");
                //RedirectToAction("Index", "Home");
            }


            return View("Index");
            //RedirectToAction("Index", "Home");
        }


            

    }
}

    







                

    




    
