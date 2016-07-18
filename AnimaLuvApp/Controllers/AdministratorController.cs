using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AnimaLuvApp.CustomFilters;

namespace AnimaLuvApp.Controllers
{
    [AuthLog(Roles = "Administrator")]
    public class AdministratorController : Controller
    {
        // GET: Administrator
        public ActionResult Index()
        {
            return View();
        }
    }
}