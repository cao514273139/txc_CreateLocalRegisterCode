using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Entry.SoftRegister;

namespace CreateLocalRegisterCode
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnCreateRegisterCode_Click(object sender, EventArgs e)
        {
            string softName = txtSoftName.Text.Trim();
            if (softName=="")
            {
                MessageBox.Show("获取失败,请输入软件名称.");
                return;
            }
            LocalRegiter lr = new LocalRegiter(softName);
            string  licence= lr.GetLicence();
            this.txtLicence.Text = licence;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
