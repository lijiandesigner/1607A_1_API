﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_MVC.Models
{
    public class AttendanceMonth1
    {
        public int MID { get; set; }//主键ID
        public string ENo { get; set; }//员工编号
        public string EName { get; set; }//姓名
        public int MAbsenteeism { get; set; }//总旷工次数
        public int MLateTime { get; set; }//总迟到分钟数
        public string Adate { get; set; }//考勤日期
    }
}