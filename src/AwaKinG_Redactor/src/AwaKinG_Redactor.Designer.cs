﻿namespace AwaKinG_Redactor
{
    partial class AwaKinG_Redactor
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlRender = new System.Windows.Forms.Panel();
            this.awA_Value_Button1 = new GUI_elements.AWA_Value_Button();
            this.awA_Value_Button2 = new GUI_elements.AWA_Value_Button();
            this.awA_Button1 = new GUI_elements.AWA_Button();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMapToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openMapToolStripMenuItem
            // 
            this.openMapToolStripMenuItem.Name = "openMapToolStripMenuItem";
            this.openMapToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openMapToolStripMenuItem.Text = "Open map...";
            this.openMapToolStripMenuItem.Click += new System.EventHandler(this.openMapToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freeToolStripMenuItem,
            this.freeToolStripMenuItem1});
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.cameraToolStripMenuItem.Text = "Camera ";
            // 
            // freeToolStripMenuItem
            // 
            this.freeToolStripMenuItem.Checked = true;
            this.freeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.freeToolStripMenuItem.Name = "freeToolStripMenuItem";
            this.freeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.freeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.freeToolStripMenuItem.Tag = "0";
            this.freeToolStripMenuItem.Text = "Redactor";
            this.freeToolStripMenuItem.Click += new System.EventHandler(this.freeToolStripMenuItem_Click);
            // 
            // freeToolStripMenuItem1
            // 
            this.freeToolStripMenuItem1.Name = "freeToolStripMenuItem1";
            this.freeToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.freeToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.freeToolStripMenuItem1.Tag = "1";
            this.freeToolStripMenuItem1.Text = "Free";
            this.freeToolStripMenuItem1.Click += new System.EventHandler(this.freeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 28);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 533);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 28);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.awA_Button1);
            this.panel3.Controls.Add(this.awA_Value_Button2);
            this.panel3.Controls.Add(this.awA_Value_Button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 481);
            this.panel3.TabIndex = 3;
            // 
            // pnlRender
            // 
            this.pnlRender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRender.Location = new System.Drawing.Point(173, 52);
            this.pnlRender.Name = "pnlRender";
            this.pnlRender.Size = new System.Drawing.Size(611, 481);
            this.pnlRender.TabIndex = 4;
            this.pnlRender.SizeChanged += new System.EventHandler(this.pnlRender_SizeChanged);
            // 
            // awA_Value_Button1
            // 
            this.awA_Value_Button1.ARROWHEIGHT = 0;
            this.awA_Value_Button1.ARROWTOOLSH = 1;
            this.awA_Value_Button1.ARRWIDTH = 20;
            this.awA_Value_Button1.BackColor = System.Drawing.Color.Transparent;
            this.awA_Value_Button1.BACKCOLOR = System.Drawing.Color.Transparent;
            this.awA_Value_Button1.BORDERCOLOR = System.Drawing.Color.Black;
            this.awA_Value_Button1.BORDERRADIUS = 5;
            this.awA_Value_Button1.BORDERWIDTH = 1;
            this.awA_Value_Button1.Image = null;
            this.awA_Value_Button1.Location = new System.Drawing.Point(13, 36);
            this.awA_Value_Button1.MaxValue = 32F;
            this.awA_Value_Button1.MinValue = 1F;
            this.awA_Value_Button1.Name = "awA_Value_Button1";
            this.awA_Value_Button1.Size = new System.Drawing.Size(60, 31);
            this.awA_Value_Button1.SVC = GUI_elements.AWA_Value_Button.SpeedOfValueChanging.Normal;
            this.awA_Value_Button1.TabIndex = 0;
            this.awA_Value_Button1.Text = "awA_Value_Button1";
            this.awA_Value_Button1.UseVisualStyleBackColor = false;
            this.awA_Value_Button1.VALUEV = 1F;
            // 
            // awA_Value_Button2
            // 
            this.awA_Value_Button2.ARROWHEIGHT = 0;
            this.awA_Value_Button2.ARROWTOOLSH = 1;
            this.awA_Value_Button2.ARRWIDTH = 20;
            this.awA_Value_Button2.BackColor = System.Drawing.Color.Transparent;
            this.awA_Value_Button2.BACKCOLOR = System.Drawing.Color.Transparent;
            this.awA_Value_Button2.BORDERCOLOR = System.Drawing.Color.Black;
            this.awA_Value_Button2.BORDERRADIUS = 5;
            this.awA_Value_Button2.BORDERWIDTH = 1;
            this.awA_Value_Button2.Image = null;
            this.awA_Value_Button2.Location = new System.Drawing.Point(88, 36);
            this.awA_Value_Button2.MaxValue = 32F;
            this.awA_Value_Button2.MinValue = 1F;
            this.awA_Value_Button2.Name = "awA_Value_Button2";
            this.awA_Value_Button2.Size = new System.Drawing.Size(60, 31);
            this.awA_Value_Button2.SVC = GUI_elements.AWA_Value_Button.SpeedOfValueChanging.Normal;
            this.awA_Value_Button2.TabIndex = 1;
            this.awA_Value_Button2.Text = "awA_Value_Button2";
            this.awA_Value_Button2.UseVisualStyleBackColor = false;
            this.awA_Value_Button2.VALUEV = 1F;
            // 
            // awA_Button1
            // 
            this.awA_Button1.BackColor = System.Drawing.Color.Transparent;
            this.awA_Button1.BACKCOLOR = System.Drawing.Color.Transparent;
            this.awA_Button1.BORDERCOLOR = System.Drawing.Color.Black;
            this.awA_Button1.BORDERRADIUS = 5;
            this.awA_Button1.BORDERWIDTH = 1;
            this.awA_Button1.Image = null;
            this.awA_Button1.Location = new System.Drawing.Point(31, 79);
            this.awA_Button1.Name = "awA_Button1";
            this.awA_Button1.PUSHEDCOLOR = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.awA_Button1.SCALEBORD = true;
            this.awA_Button1.Size = new System.Drawing.Size(107, 20);
            this.awA_Button1.TabIndex = 2;
            this.awA_Button1.Text = "create";
            this.awA_Button1.UseVisualStyleBackColor = false;
            this.awA_Button1.Click += new System.EventHandler(this.awA_Button1_Click);
            // 
            // AwaKinG_Redactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlRender);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "AwaKinG_Redactor";
            this.Text = "AwaKinG Redactor";
            this.Activated += new System.EventHandler(this.AwaKinG_Redactor_Activated);
            this.Deactivate += new System.EventHandler(this.AwaKinG_Redactor_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AwaKinG_Redactor_FormClosing);
            this.Load += new System.EventHandler(this.AwaKinG_Redactor_Load);
            this.SizeChanged += new System.EventHandler(this.AwaKinG_Redactor_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlRender;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeToolStripMenuItem1;
        private GUI_elements.AWA_Value_Button awA_Value_Button2;
        private GUI_elements.AWA_Value_Button awA_Value_Button1;
        private GUI_elements.AWA_Button awA_Button1;
    }
}

