using System;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace ExcelReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                readExcel();
            }
            catch(Exception ex)
            {
                
            }
        }

        private void readExcel()
        {
            string filePath = textBox3.Text;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;
            int Sheet = Convert.ToInt32(textBox0.Text);   //
            int row = Convert.ToInt32(textBox1.Text);   //
            int col = Convert.ToInt32(textBox2.Text);   //

            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[Sheet];                      //  Read Data from Excel
            
            MessageBox.Show(Convert.ToString(ws.Cells[row,col].Value));
            
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strFileName = openFileDialog.FileName;
                textBox3.Text = strFileName;
            }
              
        }
    }
}
