using HY.DataAccess;
using HY.Freamework.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using HY.Domain;
using DapperExtensions.Demo.Model.Entities;

namespace DapperExtensions.Demo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly UsersService _UsersService;
        public HomeController(UsersService usersService)
        {
            _UsersService = usersService;
        }




        // GET: Home
        public ActionResult Index()
        {
            UsersEntity entity = _UsersService.GetById(1);
            _UsersService.DBSession.Begin();
            return View();
        }
    }
}