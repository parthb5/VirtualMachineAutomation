using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualMachineAutomation
{
    public partial class MdiForm : Form
    {
        public MdiForm()
        {
            InitializeComponent();
        }

        private void menuNewVirtualMachine_Click(object sender, EventArgs e)
        {
            Create objCreate = new Create();
            objCreate.MdiParent = this;
            objCreate.StartPosition = FormStartPosition.CenterParent;
            objCreate.Show();
        }
        private void menuUpgradeVirtualMachine_Click(object sender, EventArgs e)
        {
            Update objUpdate = new Update();
            objUpdate.MdiParent = this;
            objUpdate.StartPosition = FormStartPosition.CenterParent;
            objUpdate.Show();
        }
        private void menuRemoveVirtualMachine_Click(object sender, EventArgs e)
        {
            Remove objRemove = new Remove();
            objRemove.MdiParent = this;
            objRemove.StartPosition = FormStartPosition.CenterParent;
            objRemove.Show();
        }
        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("help");
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
