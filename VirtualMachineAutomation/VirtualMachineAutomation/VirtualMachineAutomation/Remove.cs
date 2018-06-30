using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JsonParser;
using Newtonsoft.Json.Linq;
using System.IO;

namespace VirtualMachineAutomation
{
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
        }

        private void Remove_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            BindList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedVM = listBox1.Text.Trim();
                string JSON = "{\"vm_name\":\"" + SelectedVM + "\"}";
                System.IO.File.WriteAllText(@"C:\Users\parth\Desktop\PowerShellScritp\remove.json", JSON);
                CallPowerShell.CallScript(@"C:\Users\parth\Desktop\PowerShellScritp\Remove.ps1");
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void BindList()
        {
            try
            {
                CallPowerShell.CallScript(@"C:\Users\parth\Desktop\PowerShellScritp\BindListBox.ps1");

                JArray objJson = JArray.Parse(File.ReadAllText(@"C:\Users\parth\Desktop\PowerShellScritp\BindList.json"));
                if (objJson != null)
                {
                    for (int i = 0; i < objJson.Count; i++)
                    {
                        string str1 = objJson[i].ToString();
                        str1 = str1.Split(':')[1];
                        str1 = str1.Split('"')[1];
                        listBox1.Items.Add(str1.Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }
        }
    }
}
