using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_source.Text))
            {
                MessageBox.Show("请输入来源文件路径");
                return;
            }
            else if (!File.Exists(txt_source.Text)) {
                MessageBox.Show("来源文件不存在;");
                return;
            }
            if (string.IsNullOrEmpty(txt_result.Text))
            {
                MessageBox.Show("请输入目标文件路径");
            }
            string caculateType = "";
            if (rad_caculate1.Checked)
            { caculateType = "1"; }
            else { caculateType = "2"; }
            EcxelOperation eo = new EcxelOperation(caculateType,txt_source.Text,txt_result.Text);
            eo.exportExcel();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
