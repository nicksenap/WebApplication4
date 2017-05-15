using System.Linq;
using System.Net;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using WebApplication4.DAL;

namespace WebApplication4.Controllers
{
    public class AdminController : Controller
    {

        private P2PDbContext db = new P2PDbContext();
        // GET: Admin
        public ActionResult Index()
        {
            var user = User.Identity.GetUserId();

            var los = db.LoanApplications.OrderBy(q => q.Id).ToList();

            string currentUserId = User.Identity.GetUserId();

            P2PUser currentUser = db.Users.FirstOrDefault(x => x.Id == currentUserId);

            return View(los);
        }

        // POST Admin
        public ActionResult Edit(int? id)
        {
            if (id == null)

            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            LoanApplication loanApplication = db.LoanApplications.Find(id);

            if (loanApplication == null)
            {
                return HttpNotFound();
            }
            PopulateDepartmentsDropDownList(loanApplication.Id);

            return View();

        }

        private void PopulateDepartmentsDropDownList(object selectedDepartment = null)
        {
            var departmentsQuery = from d in db.LoanApplications
                orderby d.Id
                select d;

            ViewBag.DepartmentID = new SelectList(departmentsQuery, "DepartmentID", "Name", selectedDepartment);
        }
    }
}