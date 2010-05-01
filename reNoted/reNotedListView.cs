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
    class reNotedListView : ListView
    {
        reNotedMainWindow callerWindow;
        /// <summary>
        /// Grab main window to call methods in it. Call this when initializing.
        /// </summary>
        /// <param name="inWin">Calling Form</param>
        public void setCallerWindow(reNotedMainWindow inWin)
        {
            callerWindow = inWin;
        }

        public bool itemSelected()
        {
            bool returnCode = true;
            if (this.SelectedItems.Count == 0)
            {
                returnCode = false;
            }
            else if (this.SelectedItems.Count == 1)
            {
                returnCode = true;
            }
            else
            {
                // we should never get here
                returnCode = false;
            }
            return returnCode;
        }

        public ListViewItem getSelectedItem()
        {
            if (itemSelected())
            {
                return this.SelectedItems[0];
            }
            else
            {
                return null;
            }
        }

        public bool renameSelectedFile(string newFileName, string filePath)
        {
            bool returnCode = true;         // should return false if an error, not yet implemented



            return returnCode;
        }

        // list view items descriptions
        //      main: filename
        //      subitem[1]: created date
        //      subitem[2]: last modified date
        //      subitem[3]: full path name
        public ListViewItem addNewItem(string filePath, string newFileName)
        {
            string fullPathName = filePath + newFileName;
            reNotedTimeHandler th = new reNotedTimeHandler();
            FileInfo thisFilesInfo = new FileInfo(fullPathName);
            DateTime dtCreationDate = thisFilesInfo.CreationTime;
            DateTime dtLastModified = thisFilesInfo.LastWriteTime;
            string creationString = th.convertDateTimeToSortableString(dtCreationDate, "yes");
            string modifiedString = th.convertDateTimeToSortableString(dtLastModified, "yes");

            // create actual list itme
            ListViewItem lvItem = new ListViewItem(newFileName);
            lvItem.SubItems.Add(creationString);
            lvItem.SubItems.Add(modifiedString);
            lvItem.SubItems.Add(fullPathName);
            // stick newly created list item into listview array
            this.Items.Add(lvItem);
            // return newly created item so it can be selected, etc. if needed
            return lvItem;
        }

        public bool loadFileList(string filePath)
        {
            bool returnCode = true;         // should return false if an error, not yet implemented
            // if the directory doesn't exist, create it
            if (!Directory.Exists(@filePath))
            {
                Directory.CreateDirectory(@filePath);
            }
            // load all the text files into txtFilePaths array
            string[] txtFilePaths = Directory.GetFiles(@filePath, "*.txt");
            // tell list view to hang on while we update
            this.BeginUpdate();
            // add each file to list view
            foreach (string stringFile in txtFilePaths)
            {
                addNewItem(filePath, Path.GetFileName(stringFile));
            }
            // tell listview we are done, carry on
            this.EndUpdate();
            
            return returnCode;
        }
    }
}
