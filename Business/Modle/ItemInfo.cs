﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Modle
{
    public class ItemInfo
    {
        /// <summary>
        /// 卷烟编码
        /// </summary>
        public string ItemNo { get; set; }

        /// <summary>
        /// 卷烟名称
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// 卷烟简称
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// 件烟条码
        /// </summary>
        public string BigBox_Bar { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// 长度
        /// </summary>
        public decimal ILength { get; set; }

        /// <summary>
        /// 宽度
        /// </summary>
        public decimal IWidth { get; set; }

        /// <summary>
        /// 件条转化率
        /// </summary>
        public decimal JZ_Size { get; set; }
    }
}