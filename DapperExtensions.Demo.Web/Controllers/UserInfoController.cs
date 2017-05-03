using HY.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DapperExtensions.Demo.Web.Controllers
{
    public class UserInfoController : Controller
    {
        private readonly UserInfoService _UserInfoService;

        public UserInfoController(UserInfoService userInfoService)
        {
            _UserInfoService = userInfoService;
        }



        // GET: UserInfo
        public ActionResult Index()
        {
            return View();
        }
    }
}