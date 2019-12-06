using Insurance.Models;
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

        public ActionResult UserInfo(string FirstName, string LastName, string EmailAddress, int DateOfBirth, int CarYear, string CarMake, string CarModel, string UserDUI, int SpeedingTickets, string Coverage)
        {
            int userQuote = 50;
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(EmailAddress))
            {
                return View("~/views/Shared/Error.cshtml");
            }
            else
            {
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
                    db.UserInfoes.Add(userinfo);
                    db.SaveChanges();
                }
                int userAge = 2019 - DateOfBirth;

                

                if (userAge < 25)
                {
                    userQuote += 25;
                }
                if (userAge < 18)
                {
                    userQuote += 100;
                }
                if (userAge > 100)
                {
                    userQuote += 25;
                }
                if (CarYear < 2000)
                {
                    userQuote += 25;
                }
                if (CarYear > 2015)
                {
                    userQuote += 25;
                }
                if (CarMake == "Porsche")
                {
                    userQuote += 25;
                }
                if (CarMake == "Porsche" && CarModel == "Carrera")
                {
                    userQuote += 25;
                }
                if (SpeedingTickets > 0)
                {
                    userQuote += 10 * SpeedingTickets;
                }
                if (UserDUI == "Yes" || UserDUI == "yes")
                {
                    int Dui = userQuote / 4;
                    userQuote += Dui;
                }
                if (Coverage == "Yes" || Coverage == "yes")
                {
                    int coverage = userQuote / 2;
                    userQuote += coverage;
                }
                
            }
            
            return View(UserInfoes);
            
        }
    }
}