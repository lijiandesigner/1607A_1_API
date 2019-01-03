﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_Model
{
    /// <summary>
    /// 月考勤信息表
    /// </summary>
    public class MonthAttenModel
    {
        [Key]
        public int MID { get; set; }//主键ID
        public int EID { get; set; }//员工ID
        public int MAbsenteeism { get; set; }//总旷工次数
        public int MLateTime { get; set; }//总迟到分钟数
        public int MLeaveTime { get; set; }//总早退分钟数
        public string Remark { get; set; }//说明
    }
}
