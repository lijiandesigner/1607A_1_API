﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_MVC.Controllers
{
    public class LeaveController : Controller
    {
        /// <summary>
        /// 请假管理控制器
        /// </summary>
        /// <returns></returns>
        // GET: Leave
        public ActionResult Index()
        {
            return View();
        }
    }
}