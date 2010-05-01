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
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reNoted
{
    /// <summary>
    /// Basically a normal text box, just adds some manual handling for the tab key.
    /// When tab mode is insert tab in text, still move to search box if in the first position of the box.
    /// </summary>
    class editTextBox : TextBox
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

        public void setAcceptsTab(bool inAcceptTab)
        {
            this.AcceptsTab = inAcceptTab;
        }

        // grabs key when it comes in so OnKeyPress can do something with it
        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                return true;
            }
            else
            {
                return base.IsInputKey(keyData);
            }
        }

        // handle incoming keys
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            // if user hits tab when cursor is in the first position of the edit
            // text box, jump back up to search box
            if (e.KeyChar == (char)Keys.Tab 
                && (this.SelectionStart == 0 
                || this.AcceptsTab == false))
            {
                callerWindow.handler.giveSearchBoxFocus();
                e.Handled = true;
            }
            // I don't care about this key, use the default handler
            else
            {
                base.OnKeyPress(e);
            }
        }

    }
}
