using Insurance.Models;
using Insurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Insurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (CarInsuranceEntities db = new CarInsuranceEntities())
            {
                var userQuotes = db.UserInfoes;
                var userQuoteVms = new List<UserInfoVm>();
                foreach (var user in userQuotes)
                {
                    var userQuoteVm = new UserInfoVm();
                    userQuoteVm.Id = user.Id;
                    userQuoteVm.FirstName = user.FirstName;
                    userQuoteVm.LastName = user.LastName;
                    userQuoteVm.EmailAddress = user.EmailAddress;
                    userQuoteVms.Add(userQuoteVm);

                }
            }
            return View();
        }
    }
}