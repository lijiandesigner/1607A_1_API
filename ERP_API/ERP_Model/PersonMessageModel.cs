﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_Model
{
    /// <summary>
    /// 人事管理表
    /// </summary>
    public class PersonMessageModel
    {
        [Key]
        public int PID { get; set; }//主键ID
        public int EID { get; set; }//员工ID
        public DateTime PeBeginWork { get; set; }//入职时间
        public DateTime PeEndwork { get; set; }//离职时间
        public bool Pstatic { get; set; }//状态
    }
}
