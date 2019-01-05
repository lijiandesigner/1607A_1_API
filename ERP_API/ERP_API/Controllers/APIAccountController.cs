﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using ERP_Bll;
using Newtonsoft.Json;

namespace ERP_API.Controllers
{
    public class APIAccountController : ApiController
    {
        /// <summary>
        /// 登录管理
        /// </summary>
        /// <param name="ENo">员工编号</param>
        /// <param name="Rpassword">密码(身份证后六位)</param>
        /// <returns></returns>
       
        public LoginResult Get(string jsonstr)
        {
            LoginJsonString loginJsonString = JsonConvert.DeserializeObject<LoginJsonString>(jsonstr);
            return EmployeeInfoBll.Login(loginJsonString.ENo, loginJsonString.Rpassword);
        }

    }
}
