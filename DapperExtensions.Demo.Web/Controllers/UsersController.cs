using HY.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DapperExtensions.Demo.Web.Controllers
{
    public class UsersController : Controller
    {

        private readonly UsersService _UsersService;

        public UsersController(UsersService usersService)
        {
            _UsersService = usersService;
        }


        // GET: Users
        public ActionResult Index()
        {
      //      _UsersService.DBSession.Begin();
            return View();
        }
    }
}