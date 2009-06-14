﻿namespace Radegast
{
    partial class frmMap
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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.prgTeleport = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTeleport = new System.Windows.Forms.Button();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudZ = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lstRegions = new System.Windows.Forms.ListView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.pnlSearch.SuspendLayout();
            this.pnlProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnGoHome);
            this.pnlSearch.Controls.Add(this.pnlProgress);
            this.pnlSearch.Controls.Add(this.btnClose);
            this.pnlSearch.Controls.Add(this.btnTeleport);
            this.pnlSearch.Controls.Add(this.nudX);
            this.pnlSearch.Controls.Add(this.label3);
            this.pnlSearch.Controls.Add(this.nudY);
            this.pnlSearch.Controls.Add(this.label5);
            this.pnlSearch.Controls.Add(this.nudZ);
            this.pnlSearch.Controls.Add(this.label4);
            this.pnlSearch.Controls.Add(this.lstRegions);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtRegion);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSearch.Location = new System.Drawing.Point(619, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(194, 511);
            this.pnlSearch.TabIndex = 0;
            // 
            // btnGoHome
            // 
            this.btnGoHome.Location = new System.Drawing.Point(10, 338);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(75, 23);
            this.btnGoHome.TabIndex = 21;
            this.btnGoHome.Text = "Go home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // pnlProgress
            // 
            this.pnlProgress.Controls.Add(this.lblStatus);
            this.pnlProgress.Controls.Add(this.prgTeleport);
            this.pnlProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProgress.Location = new System.Drawing.Point(0, 453);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(194, 58);
            this.pnlProgress.TabIndex = 20;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(185, 21);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Teleport status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgTeleport
            // 
            this.prgTeleport.Enabled = false;
            this.prgTeleport.Location = new System.Drawing.Point(6, 24);
            this.prgTeleport.MarqueeAnimationSpeed = 50;
            this.prgTeleport.Name = "prgTeleport";
            this.prgTeleport.Size = new System.Drawing.Size(182, 23);
            this.prgTeleport.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(112, 309);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTeleport
            // 
            this.btnTeleport.Enabled = false;
            this.btnTeleport.Location = new System.Drawing.Point(10, 309);
            this.btnTeleport.Name = "btnTeleport";
            this.btnTeleport.Size = new System.Drawing.Size(75, 23);
            this.btnTeleport.TabIndex = 18;
            this.btnTeleport.Text = "Teleport";
            this.btnTeleport.UseVisualStyleBackColor = true;
            this.btnTeleport.Click += new System.EventHandler(this.btnTeleport_Click);
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(10, 274);
            this.nudX.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(48, 20);
            this.nudX.TabIndex = 12;
            this.nudX.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "X";
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(64, 274);
            this.nudY.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(48, 20);
            this.nudY.TabIndex = 14;
            this.nudY.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Z";
            // 
            // nudZ
            // 
            this.nudZ.Location = new System.Drawing.Point(118, 274);
            this.nudZ.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.nudZ.Name = "nudZ";
            this.nudZ.Size = new System.Drawing.Size(48, 20);
            this.nudZ.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Y";
            // 
            // lstRegions
            // 
            this.lstRegions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstRegions.Location = new System.Drawing.Point(6, 38);
            this.lstRegions.MultiSelect = false;
            this.lstRegions.Name = "lstRegions";
            this.lstRegions.ShowGroups = false;
            this.lstRegions.Size = new System.Drawing.Size(182, 211);
            this.lstRegions.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstRegions.TabIndex = 2;
            this.lstRegions.UseCompatibleStateImageBehavior = false;
            this.lstRegions.View = System.Windows.Forms.View.List;
            this.lstRegions.SelectedIndexChanged += new System.EventHandler(this.lstRegions_SelectedIndexChanged);
            this.lstRegions.Enter += new System.EventHandler(this.lstRegions_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(136, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 21);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(6, 12);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(124, 20);
            this.txtRegion.TabIndex = 0;
            this.txtRegion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegion_KeyDown);
            this.txtRegion.Enter += new System.EventHandler(this.txtRegion_Enter);
            // 
            // pnlMap
            // 
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(0, 0);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(619, 511);
            this.pnlMap.TabIndex = 1;
            // 
            // frmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 511);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.pnlSearch);
            this.Name = "frmMap";
            this.ShowIcon = false;
            this.Text = "Map";
            this.VisibleChanged += new System.EventHandler(this.frmMap_VisibleChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMap_FormClosing);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.ListView lstRegions;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTeleport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.ProgressBar prgTeleport;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnGoHome;
    }
}