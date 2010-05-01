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
using System.Text;
using System.Windows.Forms;

namespace reNoted
{
    public partial class Preferences : Form
    {
#region Global Variables
        bool autoSaveEnabled;
        bool autoSaveBackup;
        int autoSaveIntervalInt;
        bool confirmNoteDelete;
        bool tabInEditBox;
        string dirPath;
        string userEditor;
#endregion


        /// <summary>
        /// Constructor for Preferences
        /// </summary>
        public Preferences()
        {
            InitializeComponent();
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            readPerfs();
            setUpWindow();
        }

        private void setUpWindow()
        {
            fileDirNameLabel.Text = dirPath;
            userEditorNameLabel.Text = userEditor;
            deleteConfirmCheck.Checked = confirmNoteDelete;
            autoSaveEnabledCheck.Checked = autoSaveEnabled;
            autoSaveBackupCheck.Checked = autoSaveBackup;
            autoSaveInterval.Value = autoSaveIntervalInt;
            if (tabInEditBox)
            {
                insertTabRadioButton.Checked = true;
                navigateTabRadioButton.Checked = false;
            }
            else if (tabInEditBox == false)
            {
                insertTabRadioButton.Checked = false;
                navigateTabRadioButton.Checked = true;
            }
        }

        private void readPerfs()
        {
            autoSaveEnabled = Properties.Settings.Default.autoSaveOn;
            autoSaveBackup = Properties.Settings.Default.autoSaveBackup;
            autoSaveIntervalInt = Properties.Settings.Default.autoSaveTime;
            confirmNoteDelete = Properties.Settings.Default.confirmNoteDeletion;
            tabInEditBox = Properties.Settings.Default.tabInEditBox;
            dirPath = Properties.Settings.Default.dirPath;
            userEditor = Properties.Settings.Default.externalEditorPath;
        }

        private void writePerfs()
        {
            Properties.Settings.Default.autoSaveOn = autoSaveEnabledCheck.Checked;
            Properties.Settings.Default.autoSaveBackup = autoSaveBackupCheck.Checked;
            Properties.Settings.Default.autoSaveTime = (int)autoSaveInterval.Value;
            Properties.Settings.Default.confirmNoteDeletion = deleteConfirmCheck.Checked;
            Properties.Settings.Default.tabInEditBox = insertTabRadioButton.Checked;
            Properties.Settings.Default.dirPath = dirPath;
            Properties.Settings.Default.externalEditorPath = userEditor;
        }

        private void prefsCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void prefsSaveButton_Click(object sender, EventArgs e)
        {
            writePerfs();
            Close();
        }

        private void autoSaveEnabledCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (autoSaveEnabledCheck.Checked == true)
            {
                autoSaveBackupCheck.Enabled = true;
                autoSaveInterval.Enabled = true;
                autoSaveIntervalLabel.Enabled = true;
            }
            else if (autoSaveEnabledCheck.Checked == false)
            {
                autoSaveBackupCheck.Enabled = false;
                autoSaveInterval.Enabled = false;
                autoSaveIntervalLabel.Enabled = false;
            }
        }

        private void dirChooseButton_Click(object sender, EventArgs e)
        {
            DialogResult dirChooserResult = folderBrowserDialog1.ShowDialog();
            if (dirChooserResult == DialogResult.OK)
            {
                dirPath = folderBrowserDialog1.SelectedPath + "\\";
                fileDirNameLabel.Text = dirPath;
            }
        }

        private void userEditorChooseButton_Click(object sender, EventArgs e)
        {
            DialogResult extEditorChooserResult = userEditorDialog.ShowDialog();
            if (extEditorChooserResult == DialogResult.OK)
            {
                userEditor = userEditorDialog.FileName;
                userEditorNameLabel.Text = userEditor;
            }
        }
    }
}
