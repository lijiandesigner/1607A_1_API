﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using ERP_Dal;

namespace ERP_Bll
{
    public class MonthAttenBll
    {
        /// <summary>
        /// 根据条件查询月打卡信息
        /// </summary>
        /// <param name="ENo">员工编号</param>
        /// <param name="EName">员工姓名</param>
        /// <param name="Adate">打卡日期</param>
        /// <returns></returns>
        public static List<AttendanceMonth> AttendanceMonth()
        {
            return MonthAttenDal.AttendanceMonth();
        }
    }
}
