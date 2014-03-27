using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace RandomSelectionTool
{
    public partial class Form1 : Form
    {
        private const string BINARY_NAME = "RSTbin.exe";
        private const string BINARY_LOCATION = "C:\\Program Files\\Random Selection Tool v1.0\\" + BINARY_NAME;
        private const string REG_KEY_FOLDER = "Directory\\background\\shell\\Select Random";
        private const string REG_KEY_LIBRARY = "LibraryFolder\\background\\shell\\Select Random";
        private const string SUB_KEY = "\\command";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (!File.Exists(BINARY_LOCATION))
            {
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(BINARY_LOCATION));
                    File.WriteAllBytes(BINARY_LOCATION, Resource1.RSTbin); //TODO: catch file write exceptions
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("      Error: Failed to copy files.", "RST");
                    return;
                }

            }
            
            try
            {
                RegistryKey regCmd;
                
                regCmd = Registry.ClassesRoot.CreateSubKey(REG_KEY_FOLDER + SUB_KEY);
                if (regCmd != null)
                {
                    regCmd.SetValue("", BINARY_LOCATION);
                }

                regCmd = Registry.ClassesRoot.CreateSubKey(REG_KEY_LIBRARY + SUB_KEY);
                if (regCmd != null)
                {
                    regCmd.SetValue("", BINARY_LOCATION);
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("      Error: Failed to add registry values.", "RST");
                return;
            }

            MessageBox.Show("        Operation completed successfully.", "RST");
        }


        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (File.Exists(BINARY_LOCATION))
            {
                try
                {
                    Directory.Delete(Path.GetDirectoryName(BINARY_LOCATION), true);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("      Error: Failed to remove files.", "RST");
                }

            }

            Registry.ClassesRoot.DeleteSubKeyTree(REG_KEY_FOLDER, false);
            Registry.ClassesRoot.DeleteSubKeyTree(REG_KEY_LIBRARY, false);

            MessageBox.Show("          Removed.", "RST");
            
        }
        
    }
}
