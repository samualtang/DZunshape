﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HighSpeed.OrderHandle;
using HighspeedNew.OrderHandle;
using HighSpeedNew.OrderHandle;
using Tool;

namespace HighSpeed
{
    public partial class w_main : Form
    {
        public w_main()
        {
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(this);
            //this.skinEngine1.SkinFile = Application.StartupPath + @"\Skin\SportsBlack.ssk";

            InitializeComponent();
            toolStripStatusLabel1.Text = "山东德州烟草配送中心";
            //toolStripStatusLabel2.Text = "当前用户：";//+ //PublicFun.PubStruserempname;
            toolStripStatusLabel3.Text = "系统时间：" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            ProgramAutoRun.SetMeStart(true);
        }

        private void TSM_OrderReceive_Click(object sender, EventArgs e)
        {
            w_Order_Recieve frm = new w_Order_Recieve();
            if (CheckExist(frm))
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        #region 查找是否已经打开
        /// <summary>
        /// 查找是否已经打开
        /// </summary>
        /// <param name="frm"></param>
        /// <returns></returns>
        private bool CheckExist(Form frm)
        {
            bool blResult = false;
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                if (MdiChildren[i].GetType().Name == frm.GetType().Name)
                {
                    Form tmpFrm = MdiChildren[i];
                    if (tmpFrm.Text == frm.Text)
                    {
                        blResult = true;
                        tmpFrm.Activate();
                    }
                    else if (frm.Text == "")
                    {
                        blResult = true;
                        tmpFrm.Activate();
                    }
                    else if (frm.GetType().Name.ToLower() == "w_export_new")
                    {
                        blResult = true;
                        tmpFrm.Activate();
                    }
                }
            }
            return blResult;
        }
        #endregion

        private void 数据库设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_Database_Set frm = new w_Database_Set();
            frm.ShowDialog();
        }

        private void 分拣批次管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_Batch frm = new w_Batch();
            if (CheckExist(frm))
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 分拣通道管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_Through frm = new w_Through();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 预排程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            win_schedule frm = new win_schedule();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 任务排程ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            w_SortFm_New frm = new w_SortFm_New();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 订单信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_CigaretteInfo frm = new w_CigaretteInfo();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 任务导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_Export_N frm = new w_Export_N();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 今日订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_order_Union frm = new w_order_Union();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 今日订单汇总ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_orderdata frm = new w_orderdata();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 排程报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_schedulereport frm = new w_schedulereport();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 分拣进度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortingProcess frm = new SortingProcess();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 件烟补货顺序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_relenishment frm = new w_relenishment();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 异型烟补货计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_Unnormal frm = new w_Unnormal();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 混合道补烟顺序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_HunheReport frm = new w_HunheReport();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 品牌尾数维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_Cigarette_LeftCount frm = new w_Cigarette_LeftCount();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 件烟补货汇总ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_PlanReport frm = new w_PlanReport();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "系统时间：" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void 一条烟订单汇总ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_OneCigOrderReport frm = new w_OneCigOrderReport();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 分拣报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_SortingInfo frm = new w_SortingInfo();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 分拣换道ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_SortReplace frm = new w_SortReplace();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 包装机数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_PackageReport frm = new w_PackageReport();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 特异形烟任务定位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_SpecialShapePosition frm = new w_SpecialShapePosition();
            frm.ShowDialog();
        }

        private void 车组分拣顺序管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_RegionSortManage frm = new w_RegionSortManage();
            if (CheckExist(frm) == true)
            {
                frm.Dispose();
                frm = null;
                return;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        

    }
}
