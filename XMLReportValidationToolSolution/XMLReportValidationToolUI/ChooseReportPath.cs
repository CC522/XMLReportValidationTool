using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataHelper;

namespace XMLReportValidationToolUI
{
    public partial class ChooseReportPath : Form
    {
        public ChooseReportPath()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "Please Choose One File";
            //fileDialog.Filter = "所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                textBox1.Text = file;
            }
        }

        private void btnReportValidation_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null){
                ReadReport helper = new ReadReport();
                string statusValue = helper.CheckStatusByName("ReportRoot/Summary/OverallStatus", textBox1.Text);
                MessageBox.Show("Overall Status is :" + statusValue);                
            }
            
        }
    }
}
