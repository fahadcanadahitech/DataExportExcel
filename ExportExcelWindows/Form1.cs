using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using ClosedXML.Excel.CalcEngine.Functions;
using System.Data.Common.CommandTrees.ExpressionBuilder;

namespace ExportExcelWindows
{
    public partial class Form1 : Form
    {
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myfavouritemotorsDataSet.tbl_Buyer_Auction' table. You can move, or remove it, as needed.
            this.tbl_Buyer_AuctionTableAdapter.Fill(this.myfavouritemotorsDataSet.tbl_Buyer_Auction);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter="Excel Workbook|*.xlsx"})
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(dt.Copy(), "BuyerAuction");
                            workbook.SaveAs(saveFileDialog.FileName);
                        }
                        MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Creating DataTable.
            DataTable dt = new DataTable();

            //Adding the Columns.
            foreach (DataGridViewColumn column in dgvExcelExport.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows.
            foreach (DataGridViewRow row in dgvExcelExport.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != DBNull.Value)
                    {
                        dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                    }
                    else
                    {
                        dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = string.Empty;
                    }
                    
                }
            }
        }
    }
}
