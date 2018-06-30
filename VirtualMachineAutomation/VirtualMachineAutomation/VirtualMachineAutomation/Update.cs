using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualMachineAutomation
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            BindList();
        }
        public void BindList()
        {
            try
            {
                CallPowerShell.CallScript(@"C:\Users\parth\Desktop\PowerShellScritp\BindUpdateListBox.ps1");

                JArray objJson = JArray.Parse(File.ReadAllText(@"C:\Users\parth\Desktop\PowerShellScritp\BindUpdateList.json"));
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

        private void button1_Click(object sender, EventArgs e)
        {
            string SelectedVM = listBox1.Text.Trim();
            Int64 RAM = Convert.ToInt64(textBox1.Text.Trim());
            RAM = RAM * 1048576;
            string JSON = "{\"VMName\":\"" + SelectedVM + "\",\"RAM\":" + RAM + "}";
            System.IO.File.WriteAllText(@"C:\Users\parth\Desktop\PowerShellScritp\UpdateRAM.json", JSON);
            CallPowerShell.CallScript(@"C:\Users\parth\Desktop\PowerShellScritp\Update.ps1");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                Int64 RAM = 0;
                JArray objJson = JArray.Parse(File.ReadAllText(@"C:\Users\parth\Desktop\PowerShellScritp\BindUpdateList.json"));
                if (objJson != null)
                {
                    string str1 = objJson[index].ToString();
                    str1 = str1.Split(':')[2];
                    str1 = str1.Split('}')[0].Trim();
                    RAM = Convert.ToInt64(str1);
                    RAM = RAM / 1048576;
                    textBox1.Text = RAM+"";
                }
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }
        }
    }
}
