﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Modle
{
    public class TaskInfo
    {
        public string REGIONCODE { get; set; }
        public decimal QTY { get; set; }
        public decimal FinishQTY { get; set; }
        public decimal Count { get; set; }
        public decimal FinishCount { get; set; }
        public String Rate { get; set; }


        /////////////////////////////////
        public decimal MACHINESEQ { get; set; }
        public decimal GROUPNO { get; set; }
        public decimal POKENUM { get; set; }
        public decimal UNIONTASKNUM { get; set; }
        public string TROUGHNUM { get; set; }
        public decimal SYNSEQ { get; set; }//批次号 优先取
        public Decimal BATCHODE { get; set; }//批次号
        public string CUSTOMERNAME { get; set; }//货主
        public DateTime? ORDERDATE { get; set; }//订单日期
    }
}