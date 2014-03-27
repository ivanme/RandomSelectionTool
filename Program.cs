// Copyright (c) 2014 Ivan Yu
// 
// This software is provided 'as-is', without any express or implied
// warranty. In no event will the authors be held liable for any damages
// arising from the use of this software.
// 
// Permission is granted to anyone to use this software for any purpose,
// including commercial applications, and to alter it and redistribute it
// freely, subject to the following restrictions:
// 
//    1. The origin of this software must not be misrepresented; you must not
//    claim that you wrote the original software. If you use this software
//    in a product, an acknowledgment in the product documentation would be
//    appreciated but is not required.
// 
//    2. Altered source versions must be plainly marked as such, and must not be
//    misrepresented as being the original software.
// 
//    3. This notice may not be removed or altered from any source
//    distribution.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Security.Principal;

namespace RandomSelectionTool
{
    static class Program
    {

        const string BINARY_NAME = "RSTbin.exe";
        const string BINARY_LOCATION = "C:\\Program Files\\Random Selection Tool v1.0\\" + BINARY_NAME + "";

        [STAThread]
        static void Main()
        {
            //Check for admin rights
            WindowsIdentity wid = WindowsIdentity.GetCurrent();
            WindowsPrincipal wpr = new WindowsPrincipal(wid);
            if (!wpr.IsInRole(WindowsBuiltInRole.Administrator))
            {
                MessageBox.Show("        Administrator privileges required. Please run as administrator.", "RandomSelectionTool");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
