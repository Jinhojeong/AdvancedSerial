﻿using System.Windows.Forms;

namespace AdvancedSerialClient
{
    partial class DataPlotter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataPlotter));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_PauseRun = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TB_XAxisTime = new System.Windows.Forms.ToolStripTextBox();
            this.btn_ShowNames = new System.Windows.Forms.ToolStripButton();
            this.BTN_ShowLegend = new System.Windows.Forms.ToolStripButton();
            this.Splitter = new System.Windows.Forms.SplitContainer();
            this.dgvplots = new System.Windows.Forms.DataGridView();
            this.Visible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Signal = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Splitter)).BeginInit();
            this.Splitter.Panel2.SuspendLayout();
            this.Splitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplots)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_PauseRun,
            this.toolStripLabel1,
            this.TB_XAxisTime,
            this.btn_ShowNames,
            this.BTN_ShowLegend});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1032, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_PauseRun
            // 
            this.btn_PauseRun.CheckOnClick = true;
            this.btn_PauseRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_PauseRun.Image = ((System.Drawing.Image)(resources.GetObject("btn_PauseRun.Image")));
            this.btn_PauseRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_PauseRun.Name = "btn_PauseRun";
            this.btn_PauseRun.Size = new System.Drawing.Size(50, 24);
            this.btn_PauseRun.Text = "Pause";
            this.btn_PauseRun.Click += new System.EventHandler(this.btn_PauseRun_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(176, 24);
            this.toolStripLabel1.Text = "Time-Length (*=all time):";
            // 
            // TB_XAxisTime
            // 
            this.TB_XAxisTime.Name = "TB_XAxisTime";
            this.TB_XAxisTime.Size = new System.Drawing.Size(65, 27);
            this.TB_XAxisTime.Text = "*";
            this.TB_XAxisTime.Validating += new System.ComponentModel.CancelEventHandler(this.TB_XAxisTime_Validating);
            this.TB_XAxisTime.KeyPress += new KeyPressEventHandler(this.TB_XAxisTime_KeyPress);
            // 
            // btn_ShowNames
            // 
            this.btn_ShowNames.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_ShowNames.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_ShowNames.Image = ((System.Drawing.Image)(resources.GetObject("btn_ShowNames.Image")));
            this.btn_ShowNames.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ShowNames.Name = "btn_ShowNames";
            this.btn_ShowNames.Size = new System.Drawing.Size(23, 24);
            this.btn_ShowNames.Text = ">";
            this.btn_ShowNames.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // BTN_ShowLegend
            // 
            this.BTN_ShowLegend.Checked = true;
            this.BTN_ShowLegend.CheckOnClick = true;
            this.BTN_ShowLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BTN_ShowLegend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BTN_ShowLegend.Image = ((System.Drawing.Image)(resources.GetObject("BTN_ShowLegend.Image")));
            this.BTN_ShowLegend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_ShowLegend.Name = "BTN_ShowLegend";
            this.BTN_ShowLegend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_ShowLegend.Size = new System.Drawing.Size(98, 24);
            this.BTN_ShowLegend.Text = "Hide Legend";
            this.BTN_ShowLegend.Click += new System.EventHandler(this.BTN_ShowLegend_Click);
            // 
            // Splitter
            // 
            this.Splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Splitter.Location = new System.Drawing.Point(0, 0);
            this.Splitter.Margin = new System.Windows.Forms.Padding(4);
            this.Splitter.Name = "Splitter";
            // 
            // Splitter.Panel2
            // 
            this.Splitter.Panel2.Controls.Add(this.dgvplots);
            this.Splitter.Size = new System.Drawing.Size(1032, 490);
            this.Splitter.SplitterDistance = 717;
            this.Splitter.SplitterWidth = 5;
            this.Splitter.TabIndex = 3;
            // 
            // dgvplots
            // 
            this.dgvplots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvplots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Visible,
            this.Signal});
            this.dgvplots.Location = new System.Drawing.Point(-2, 30);
            this.dgvplots.Margin = new System.Windows.Forms.Padding(4);
            this.dgvplots.Name = "dgvplots";
            this.dgvplots.RowHeadersVisible = false;
            this.dgvplots.Size = new System.Drawing.Size(300, 419);
            this.dgvplots.TabIndex = 0;
            // 
            // Visible
            // 
            this.Visible.FalseValue = "";
            this.Visible.HeaderText = "Visible";
            this.Visible.Name = "Visible";
            this.Visible.TrueValue = "";
            this.Visible.Width = 50;
            // 
            // Signal
            // 
            this.Signal.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Signal.HeaderText = "Name";
            this.Signal.Name = "Signal";
            // 
            // DataPlotter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 490);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Splitter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DataPlotter";
            this.Text = "Advanced Serial Plotter";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Splitter)).EndInit();
            this.Splitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvplots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TB_XAxisTime;
        private System.Windows.Forms.ToolStripButton btn_ShowNames;
        private System.Windows.Forms.SplitContainer Splitter;
        private System.Windows.Forms.DataGridView dgvplots;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Visible;
        private System.Windows.Forms.DataGridViewComboBoxColumn Signal;
        private System.Windows.Forms.ToolStripButton btn_PauseRun;
        private System.Windows.Forms.ToolStripButton BTN_ShowLegend;
    }
}