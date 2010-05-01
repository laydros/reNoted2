// Copyright 2010, Jason Hamilton
// http://www.laydros.net
// All Rights Reserved
//
// This file is part of reNoted.
//
// reNoted is free software: you can redistribute it and/or modify it under the 
// terms of the GNU General Public License as published by the Free Software 
// Foundation, either version 3 of the License, or (at your option) any later version.
//
// reNoted is distributed in the hope that it will be useful, but WITHOUT ANY 
// WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS 
// FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License along with 
// reNoted. If not, see http://www.gnu.org/licenses/.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reNoted
{
    public partial class reNotedMainWindow : Form
    {
        internal reNotedHandler handler;
        public reNotedMainWindow()
        {
            InitializeComponent();
            // set to false by default incase nothing is selected
            // search string text is filled after this if present, in which case
            // box will become enabled
            editTextBox1.Enabled = false;
            handler = new reNotedHandler(this);
        }

        private void reNotedMainWindow_Load(object sender, EventArgs e)
        {
            editTextBox1.setCallerWindow(this);
            reNotedListView1.setCallerWindow(this);
            searchAndTitleBox1.setCallerWindow(this);
            // used for shortcut keys implemented in reNotedMainWindow_ShortCutKeys
            this.KeyPreview = true;
        }





        #region Menu Functions
        // ########################### Menu Functions ##############################
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handler.callAboutWindow();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handler.deleteSelectedItem();
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handler.renameSelectedItem();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handler.giveSearchBoxFocus();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editTextBox1.SelectAll();
        }

        private void nextNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handler.moveSelectionDown();
        }

        private void previousNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handler.moveSelectionUp();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handler.callPreferenceWindow();
        }

        #endregion

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            handler.clearAll();
        }

        private void reNotedMainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            reNotedMainWindow_ShortCutKeys(sender, e);
        }
        
        private void reNotedMainWindow_Resize(object sender, EventArgs e)
        {
            //int columnCount = vailosListView1.Columns.Count - 1;
            //vailosListView1.Columns[0].Width = vailosListView1.Width 
            //    - vailosListView1.Columns[columnCount].Width;
        }

        private void reNotedMainWindow_ShortCutKeys(object sender, KeyEventArgs e)
        {
            {
                // Ctrl-J - previous item
                if (e.Control == true && e.KeyCode == Keys.J)
                {
                    handler.moveSelectionDown();
                    e.Handled = true;
                }
                // Ctrl-K - next item
                else if (e.Control == true && e.KeyCode == Keys.K)
                {
                    handler.moveSelectionUp();
                    e.Handled = true;
                }
                // Escape - clear all
                else if (e.KeyCode == Keys.Escape)
                {
                    handler.clearAll();
                }
            }
        }

        private void reNotedListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // save prior and show it below
        }

        private void reNotedMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            handler.saveOutSettings();
        }


    }
}
