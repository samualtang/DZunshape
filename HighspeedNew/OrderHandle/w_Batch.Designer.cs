﻿namespace HighSpeed.OrderHandle
{
    partial class w_Batch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbnormal = new System.Windows.Forms.CheckBox();
            this.cbunnormal = new System.Windows.Forms.CheckBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.batchdata = new System.Windows.Forms.DataGridView();
            this.batchcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchdata)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbnormal);
            this.panel1.Controls.Add(this.cbunnormal);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 48);
            this.panel1.TabIndex = 1;
            // 
            // cbnormal
            // 
            this.cbnormal.AutoSize = true;
            this.cbnormal.Checked = true;
            this.cbnormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbnormal.Location = new System.Drawing.Point(640, 14);
            this.cbnormal.Margin = new System.Windows.Forms.Padding(2);
            this.cbnormal.Name = "cbnormal";
            this.cbnormal.Size = new System.Drawing.Size(60, 16);
            this.cbnormal.TabIndex = 3;
            this.cbnormal.Text = "标准烟";
            this.cbnormal.UseVisualStyleBackColor = true;
            this.cbnormal.Visible = false;
            // 
            // cbunnormal
            // 
            this.cbunnormal.AutoSize = true;
            this.cbunnormal.Checked = true;
            this.cbunnormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbunnormal.Location = new System.Drawing.Point(750, 14);
            this.cbunnormal.Margin = new System.Windows.Forms.Padding(2);
            this.cbunnormal.Name = "cbunnormal";
            this.cbunnormal.Size = new System.Drawing.Size(60, 16);
            this.cbunnormal.TabIndex = 2;
            this.cbunnormal.Text = "异型烟";
            this.cbunnormal.UseVisualStyleBackColor = true;
            this.cbunnormal.Visible = false;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_close.Location = new System.Drawing.Point(139, 14);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(86, 28);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "关闭批次";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_new.Location = new System.Drawing.Point(25, 14);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(89, 28);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "创建批次";
            this.btn_new.UseCompatibleTextRendering = true;
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // batchdata
            // 
            this.batchdata.AllowUserToAddRows = false;
            this.batchdata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.batchdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.batchdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.batchdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batchcode,
            this.starttime,
            this.endtime,
            this.类型,
            this.status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.batchdata.DefaultCellStyle = dataGridViewCellStyle2;
            this.batchdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.batchdata.Location = new System.Drawing.Point(0, 48);
            this.batchdata.MultiSelect = false;
            this.batchdata.Name = "batchdata";
            this.batchdata.ReadOnly = true;
            this.batchdata.RowTemplate.Height = 23;
            this.batchdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.batchdata.Size = new System.Drawing.Size(821, 271);
            this.batchdata.TabIndex = 2;
            this.batchdata.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.batchdata_CellFormatting);
            this.batchdata.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.batchdata_RowPostPaint);
            // 
            // batchcode
            // 
            this.batchcode.DataPropertyName = "batchcode";
            this.batchcode.HeaderText = "批次编号";
            this.batchcode.Name = "batchcode";
            this.batchcode.ReadOnly = true;
            // 
            // starttime
            // 
            this.starttime.DataPropertyName = "starttime";
            this.starttime.HeaderText = "创建时间";
            this.starttime.Name = "starttime";
            this.starttime.ReadOnly = true;
            this.starttime.Width = 150;
            // 
            // endtime
            // 
            this.endtime.DataPropertyName = "endtime";
            this.endtime.HeaderText = "关闭时间";
            this.endtime.Name = "endtime";
            this.endtime.ReadOnly = true;
            this.endtime.Width = 150;
            // 
            // 类型
            // 
            this.类型.DataPropertyName = "batchtype";
            this.类型.HeaderText = "类型";
            this.类型.Name = "类型";
            this.类型.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "state";
            this.status.HeaderText = "批次状态";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // w_Batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 319);
            this.Controls.Add(this.batchdata);
            this.Controls.Add(this.panel1);
            this.Name = "w_Batch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "分拣批次管理";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbnormal;
        private System.Windows.Forms.CheckBox cbunnormal;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_new;
        public System.Windows.Forms.DataGridView batchdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}