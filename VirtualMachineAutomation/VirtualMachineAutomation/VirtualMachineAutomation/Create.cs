using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JsonParser;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace VirtualMachineAutomation
{
    public partial class Create : Form
    {
        string vm_name { get; set; }
        double vm_ram { get; set; }
        double vm_vhd { get; set; }
        string vm_nic { get; set; }

        public Create()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                vm_name = textBox1.Text.Trim();
                vm_ram = Convert.ToDouble(textBox2.Text.Trim());
                vm_vhd = Convert.ToDouble(textBox3.Text.Trim());
                vm_nic = comboBox1.Text.Trim();

                string JSON = "{\"vm_name\":\"" + vm_name + "\",\"vm_ram\":" + vm_ram * 1048576 + ",\"vm_vhd\":" + vm_vhd * 1048576 + ",\"vm_nic\":\"" + vm_nic + "\"}";
                System.IO.File.WriteAllText(@"C:\Users\parth\Desktop\PowerShellScritp\Create.json", JSON);

                //MessageBox.Show("h");
                CallPowerShell.CallScript(@"C:\Users\parth\Desktop\PowerShellScritp\Create.ps1");
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }
        }
    }
}
