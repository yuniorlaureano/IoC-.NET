using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoFacNetCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoFacNetCore.Controllers
{
    public class HomeController : Controller
    {
        private ITryAutoFac _tryAutoFac;

        public HomeController(ITryAutoFac tryAutoFac)
        {
            _tryAutoFac = tryAutoFac;
        }
        
        public JsonResult Index()
        {
            return new JsonResult(_tryAutoFac.Tray());
        }
    }
}