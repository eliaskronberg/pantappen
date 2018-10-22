using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PantApp.Models;
using PantApp.Services;
using System.Web.Script.Serialization;

namespace PantApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserDataService _userDataService;
        public HomeController()
        {
            _userDataService = new UserDataService();
        }
        [HttpPost]
        public ActionResult Index(string name)
        {
            var viewModel = new UserViewModel();
            if (!string.IsNullOrEmpty(name))
            {
                var userModel =_userDataService.GetUserData(name);
                viewModel.Id = userModel.Id;
                viewModel.Name = userModel.Name;
                viewModel.Balance = userModel.Balance;
                viewModel.RecycledCans = userModel.RecycledCans;
            }
            return View(viewModel);
        }
        public ActionResult Index()
        {
            var viewModel = new UserViewModel();

            return View(viewModel);
        }
        [HttpPost]
        public JsonResult Recycle(int value, int userId)
        {
            var userData =_userDataService.UpdateUserData(userId, value);
            return new JsonResult()
            {
                Data = new { newBalance = userData.Balance.ToString(), newCanCount = userData.RecycledCans.ToString() },
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };

        }

    }
}