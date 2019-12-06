using Insurance.Models;
using Insurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Insurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        int Quote = 50;

        public ActionResult UserInfo(string FirstName, string LastName, string EmailAddress, int DateOfBirth, int CarYear, string CarMake, string CarModel, string UserDUI, int SpeedingTickets, string Coverage)
        {
            
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(EmailAddress))
            {
                return View("~/views/Shared/Error.cshtml");
            }
            else
            {
                int userAge = 2019 - DateOfBirth;
                


                if (userAge < 25)
                {
                    Quote += 25;
                }
                if (userAge < 18)
                {
                    Quote += 100;
                }
                if (userAge > 100)
                {
                    Quote += 25;
                }
                if (CarYear < 2000)
                {
                    Quote += 25;
                }
                if (CarYear > 2015)
                {
                    Quote += 25;
                }
                if (CarMake == "Porsche")
                {
                    Quote += 25;
                }
                if (CarMake == "Porsche" && CarModel == "Carrera")
                {
                    Quote += 25;
                }
                if (SpeedingTickets > 0)
                {
                    Quote += 10 * SpeedingTickets;
                }
                if (UserDUI == "Yes" || UserDUI == "yes")
                {
                    int Dui = Quote / 4;
                    Quote += Dui;
                }
                if (Coverage == "Yes" || Coverage == "yes")
                {
                    int coverage = Quote / 2;
                    Quote += coverage;
                }
                

                using (CarInsuranceEntities db = new CarInsuranceEntities())
                {
                    var userinfo = new UserInfo();
                    userinfo.FirstName = FirstName;
                    userinfo.LastName = LastName;
                    userinfo.EmailAddress = EmailAddress;
                    userinfo.DateOfBirth = DateOfBirth;
                    userinfo.CarYear = CarYear;
                    userinfo.CarMake = CarMake;
                    userinfo.CarModel = CarModel;
                    userinfo.UserDUI = UserDUI;
                    userinfo.SpeedingTickets = SpeedingTickets;
                    userinfo.Coverage = Coverage;
                    userinfo.Quote = Quote;
                    db.UserInfoes.Add(userinfo);
                    db.SaveChanges();
                }
                
                
            }
            
            return View("Success");
            
        }
        public ActionResult Admin()
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
                    userQuoteVm.Quote = user.Quote;
                    userQuoteVms.Add(userQuoteVm);

                }
                return View(userQuoteVms);
            }
            
        }
    }
}