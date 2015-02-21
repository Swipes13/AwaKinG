﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwaKinG_Redactor
{
    public partial class RedactorForm : Form
    {
        public RedactorForm()
        {
            InitializeComponent();
            Application.Idle += Application_Idle;
        }
        void Application_Idle(object sender, EventArgs e)
        {
            while (!Engine.getInstance().done)
            {
                Engine.getInstance().update();
                Application.DoEvents();
            }
        }
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Engine.getInstance().done = true;
            Close();
        }
        private void redactorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Engine.getInstance().done = true;
        }
        private void pnlRender_SizeChanged(object sender, EventArgs e)
        {
            Engine.getInstance().resize(pnlRender.Size);
        }
    }
}
