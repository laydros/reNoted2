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
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace reNoted
{
    public class reNotedHandler
    {
        #region Global Variables
        public string currentFileName = null;       // should always contain the selected and displayed filename
        public int sortColumn = -1;

        // these should at least be internal
        #region Settings Variables
        public string filePath;
        public string externalEditor;
        public bool autoSaveOn;
        public int autoSaveTime;
        public bool autoSaveBackup;
        public bool tabInEditBox;
        public int panel1Height;
        public bool useCreatedDateColumn;
        public bool useModifiedDateColumn;
        #endregion
        #endregion

        reNotedMainWindow callerWindow;
        public reNotedHandler(reNotedMainWindow inWin)
        {
            callerWindow = inWin;
            grabSettings();
            implementSettings();
            callerWindow.reNotedListView1.loadFileList(filePath);
        }

        void grabSettings()
        {
            filePath = Properties.Settings.Default.dirPath;
            externalEditor = Properties.Settings.Default.externalEditorPath;
            autoSaveOn = Properties.Settings.Default.autoSaveOn;
            autoSaveTime = Properties.Settings.Default.autoSaveTime;
            autoSaveBackup = Properties.Settings.Default.autoSaveBackup;
            tabInEditBox = Properties.Settings.Default.tabInEditBox;
            panel1Height = Properties.Settings.Default.splitterHeight;
            useCreatedDateColumn = Properties.Settings.Default.useCreationDateColumn;
            useModifiedDateColumn = Properties.Settings.Default.useModifiedDateColumn;
        }

        void implementSettings()
        {
            // no file path set, need to get this from the user to carry on
            if (filePath.Length == 0)
            {
                bool result = getNotesDirectoryFromUser();
                if (result == false)
                {
                    callerWindow.Close();
                }
                else
                {
                    Properties.Settings.Default.dirPath = filePath;
                    Properties.Settings.Default.Save();
                }
            }
            callerWindow.reNotedListView1.Columns.Add("Title", -2);
            if (useCreatedDateColumn)
            {
                callerWindow.reNotedListView1.Columns.Add("Created", -2);
            }
            if (useModifiedDateColumn)
            {
                callerWindow.reNotedListView1.Columns.Add("Modified", -2);
            }
        }

        public void saveOutSettings()
        {
            Properties.Settings.Default.reNotedMainWinHeight = callerWindow.Height;
            Properties.Settings.Default.reNotedMainWinWidth = callerWindow.Width;
            Properties.Settings.Default.Save();
        }

        public void callPreferenceWindow()
        {
            Preferences myPerfsWindow = new Preferences();
            myPerfsWindow.ShowDialog();
        }

        public void callAboutWindow()
        {
            AboutBox myAboutBox = new AboutBox();
            myAboutBox.ShowDialog();
        }

        public void deleteSelectedItem()
        {

        }

        public void renameSelectedItem()
        {

        }

        public void moveSelectionUp()
        {

        }

        public void moveSelectionDown()
        {

        }

        public void clearAll()
        {

        }

        public void giveSearchBoxFocus()
        {
            callerWindow.searchAndTitleBox1.Focus();
        }

        private bool getNotesDirectoryFromUser()
        {
            MessageBox.Show("Folder for notes not found, please select" + " a directory for your notes");
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult dirChoose = folderBrowserDialog1.ShowDialog();
            if (dirChoose == DialogResult.OK)
            {
                filePath = folderBrowserDialog1.SelectedPath;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
