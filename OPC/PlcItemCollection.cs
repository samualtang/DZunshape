﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpcRcw.Da;
using OpcRcw.Comn;

namespace OPC
{
    public static class PlcItemCollection
    {
        public static String OpcPresortServer = "S7:[PackageMachineGroup1]";


        /// <summary>
        /// 烟仓任务发送
        /// </summary>
        /// <returns></returns>
        public static List<string> GetOnlyDBItem()
        {
            List<string> list = new List<string>();
            list.Add(OpcPresortServer + "DB1,DINT0");
            list.Add(OpcPresortServer + "DB1,DINT4");
            for (int i = 8; i <= 198; i += 2)
            {
                list.Add(OpcPresortServer + "DB1,W" + i);//为烟柜内部皮带的条烟总数
            }
            list.Add(OpcPresortServer + "DB1,W200");//2#立式烟仓总条数
            list.Add(OpcPresortServer + "DB1,W202");//卧式烟仓总条数
            list.Add(OpcPresortServer + "DB1,W204");//1#立式烟仓总条数
            list.Add(OpcPresortServer + "DB1,DINT206");//预留
            list.Add(OpcPresortServer + "DB1,W210");//
            list.Add(OpcPresortServer + "DB1,W212");//接收标志
            return list;
        }

        /// <summary>
        /// 烟仓任务监控标志位
        /// </summary>
        /// <returns></returns>
        public static List<string> GetSpyOnlyLineItem()
        {
            List<string> list = new List<string>();

            list.Add(OpcPresortServer + "DB1,W212");// 交互标志 0
            return list;
        }

        /// <summary>
        /// 烟仓任务结束回应
        /// </summary>
        /// <returns></returns>
        public static List<string> GetOnlyLineFinishTaskItem()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 40; i += 4)
            {
                list.Add(OpcPresortServer + "DB31,DINT" + i);
            }
            return list;
        }

        /// <summary>
        /// 卧式烟仓补货任务
        /// </summary>
        /// <returns></returns>
        public static List<string> GetRelenishplanItem()
        {
            List<string> list = new List<string>();
            list.Add(OpcPresortServer + "DB300,DINT0");
            list.Add(OpcPresortServer + "DB300,W4");
            list.Add(OpcPresortServer + "DB300,DINT6");
            list.Add(OpcPresortServer + "DB300,DINT10");
            list.Add(OpcPresortServer + "DB300,W14");
            list.Add(OpcPresortServer + "DB300,W16");
            return list;
        }

        /// <summary>
        /// 补货任务任务结束回应
        /// </summary>
        /// <returns></returns>
        public static List<string> GetReFinishTaskItem()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 400; i += 4)
            {
                list.Add(OpcPresortServer + "DB302,DINT" + i);
            }
            return list;
        }
        /// <summary>
        /// 补货任务监控标志位
        /// </summary>
        /// <returns></returns>
        public static List<string> GetReSpyOnlyLineItem()
        {
            List<string> list = new List<string>();

            list.Add(OpcPresortServer + "DB300,W16");// 交互标志 0
            return list;
        }

        public static List<string> GetScan() 
        {
            List<string> list = new List<string>() { "DB300,DINT18" };
            return list;
        }
        public static List<string> GetOnlyUnnormalItem() 
        {
            List<string> list = new List<string>();
            list.Add(OpcPresortServer + "DB3,DINT0");
            list.Add(OpcPresortServer + "DB3,DINT4");
            list.Add(OpcPresortServer + "DB3,W8");
            list.Add(OpcPresortServer + "DB3,W10");
            list.Add(OpcPresortServer + "DB3,DINT12");
            list.Add(OpcPresortServer + "DB3,W16");
            list.Add(OpcPresortServer + "DB3,W18");
            return list;
        }
        public static List<string> GetSpanUnnormalItem()
        {
            List<string> list = new List<string>();
            list.Add(OpcPresortServer + "DB3,W18");
            return list;
        }
        public static List<string> GetFinishUnnormalItem()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 160; i+=4)
            {
                list.Add(OpcPresortServer + "DB33,DINT" + i);
            }
            
            //list.Add(OpcPresortServer + "DB32,DINT4");
            return list;
        }

    }
}
