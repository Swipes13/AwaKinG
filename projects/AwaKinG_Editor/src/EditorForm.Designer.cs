﻿namespace AwaKinG_Editor
{
    partial class EditorForm
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
      this.menuMain = new System.Windows.Forms.MenuStrip();
      this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
      this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
      this.pnlDown = new System.Windows.Forms.Panel();
      this.pnlLeft = new System.Windows.Forms.FlowLayoutPanel();
      this.pnlRight = new System.Windows.Forms.FlowLayoutPanel();
      this.pnlRender = new System.Windows.Forms.Panel();
      this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.menuEditCamera = new System.Windows.Forms.ToolStripMenuItem();
      this.menuEditCameraFirstPerson = new System.Windows.Forms.ToolStripMenuItem();
      this.menuEditCameraRedactor = new System.Windows.Forms.ToolStripMenuItem();
      this.menuMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuMain
      // 
      this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit});
      this.menuMain.Location = new System.Drawing.Point(0, 0);
      this.menuMain.Name = "menuMain";
      this.menuMain.Size = new System.Drawing.Size(784, 24);
      this.menuMain.TabIndex = 0;
      this.menuMain.Text = "menuStrip1";
      // 
      // menuFile
      // 
      this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileExit});
      this.menuFile.Name = "menuFile";
      this.menuFile.Size = new System.Drawing.Size(37, 20);
      this.menuFile.Text = "File";
      // 
      // menuFileExit
      // 
      this.menuFileExit.Name = "menuFileExit";
      this.menuFileExit.Size = new System.Drawing.Size(152, 22);
      this.menuFileExit.Text = "Exit";
      this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
      // 
      // pnlDown
      // 
      this.pnlDown.BackColor = System.Drawing.SystemColors.ControlLight;
      this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlDown.Location = new System.Drawing.Point(0, 536);
      this.pnlDown.Name = "pnlDown";
      this.pnlDown.Size = new System.Drawing.Size(784, 25);
      this.pnlDown.TabIndex = 1;
      // 
      // pnlLeft
      // 
      this.pnlLeft.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnlLeft.Location = new System.Drawing.Point(0, 24);
      this.pnlLeft.Name = "pnlLeft";
      this.pnlLeft.Size = new System.Drawing.Size(176, 512);
      this.pnlLeft.TabIndex = 2;
      // 
      // pnlRight
      // 
      this.pnlRight.BackColor = System.Drawing.SystemColors.InactiveBorder;
      this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.pnlRight.Location = new System.Drawing.Point(610, 24);
      this.pnlRight.Name = "pnlRight";
      this.pnlRight.Size = new System.Drawing.Size(174, 512);
      this.pnlRight.TabIndex = 3;
      // 
      // pnlRender
      // 
      this.pnlRender.BackColor = System.Drawing.Color.RoyalBlue;
      this.pnlRender.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlRender.Location = new System.Drawing.Point(176, 24);
      this.pnlRender.Name = "pnlRender";
      this.pnlRender.Size = new System.Drawing.Size(434, 512);
      this.pnlRender.TabIndex = 4;
      this.pnlRender.SizeChanged += new System.EventHandler(this.pnlRender_SizeChanged);
      // 
      // menuEdit
      // 
      this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditCamera});
      this.menuEdit.Name = "menuEdit";
      this.menuEdit.Size = new System.Drawing.Size(39, 20);
      this.menuEdit.Text = "Edit";
      // 
      // menuEditCamera
      // 
      this.menuEditCamera.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditCameraFirstPerson,
            this.menuEditCameraRedactor});
      this.menuEditCamera.Name = "menuEditCamera";
      this.menuEditCamera.Size = new System.Drawing.Size(152, 22);
      this.menuEditCamera.Text = "Camera";
      // 
      // menuEditCameraFirstPerson
      // 
      this.menuEditCameraFirstPerson.Checked = true;
      this.menuEditCameraFirstPerson.CheckState = System.Windows.Forms.CheckState.Checked;
      this.menuEditCameraFirstPerson.Name = "menuEditCameraFirstPerson";
      this.menuEditCameraFirstPerson.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
      this.menuEditCameraFirstPerson.Size = new System.Drawing.Size(175, 22);
      this.menuEditCameraFirstPerson.Tag = "1";
      this.menuEditCameraFirstPerson.Text = "First person";
      this.menuEditCameraFirstPerson.Click += new System.EventHandler(this.CameraType_Click);
      // 
      // menuEditCameraRedactor
      // 
      this.menuEditCameraRedactor.Name = "menuEditCameraRedactor";
      this.menuEditCameraRedactor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
      this.menuEditCameraRedactor.Size = new System.Drawing.Size(175, 22);
      this.menuEditCameraRedactor.Tag = "2";
      this.menuEditCameraRedactor.Text = "Redactor";
      this.menuEditCameraRedactor.Click += new System.EventHandler(this.CameraType_Click);
      // 
      // EditorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 561);
      this.Controls.Add(this.pnlRender);
      this.Controls.Add(this.pnlRight);
      this.Controls.Add(this.pnlLeft);
      this.Controls.Add(this.pnlDown);
      this.Controls.Add(this.menuMain);
      this.MainMenuStrip = this.menuMain;
      this.MinimumSize = new System.Drawing.Size(800, 600);
      this.Name = "EditorForm";
      this.ShowIcon = false;
      this.Text = "AwaKinG Engine Editor";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Activated += new System.EventHandler(this.EditorForm_Activated);
      this.Deactivate += new System.EventHandler(this.EditorForm_Deactivate);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.redactorForm_FormClosing);
      this.Load += new System.EventHandler(this.EditorForm_Load);
      this.SizeChanged += new System.EventHandler(this.EditorForm_SizeChanged);
      this.menuMain.ResumeLayout(false);
      this.menuMain.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.FlowLayoutPanel pnlLeft;
        private System.Windows.Forms.FlowLayoutPanel pnlRight;
        private System.Windows.Forms.Panel pnlRender;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditCamera;
        private System.Windows.Forms.ToolStripMenuItem menuEditCameraFirstPerson;
        private System.Windows.Forms.ToolStripMenuItem menuEditCameraRedactor;
    }
}