using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
using WebApplication4.DAL;

namespace WebApplication4.Controllers
{
    public class LoanController : Controller
    {
        // GET: Loan
        public ActionResult Index()
        {
            return View();
        }

        //public async Task<ActionResult> ApplyForLoan(LoanViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var LoanApps = new LoanApplication { Amount = model.Amount, Months = model.Month };
        //        var result = await
        //    }


        //}
        // public


    }
}