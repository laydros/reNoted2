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
    class SearchAndTitleBox : TextBox
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
    }
}
