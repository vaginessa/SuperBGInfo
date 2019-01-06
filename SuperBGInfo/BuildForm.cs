﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperBGInfo
{
    public partial class BuildForm : Form
    {
        public BuildForm()
        {
            InitializeComponent();
        }

        private void fontBtn_Click(object sender, EventArgs e)
        {
            fontDialog.Font = editorRTB.SelectionFont;
            fontDialog.ShowDialog();
            editorRTB.SelectionFont = fontDialog.Font;
        }

        private void varList_DoubleClick(object sender, EventArgs e)
        {
            //editorRTB.SelectionStart;
            //editorRTB.SelectionLength;
            //varList.
            editorRTB.SelectedText = varList.SelectedItem.ToString();
        }
    }
}
