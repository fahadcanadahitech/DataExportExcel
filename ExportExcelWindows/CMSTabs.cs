using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExportExcelWindows
{
    public partial class CMSTabs : Form
    {
        Loading frm = new Loading();
        DataTable dtProducts;
        DataTable dtInventory;

        public CMSTabs()
        {
            InitializeComponent();
        }

        void savedata() 
        {
            //for (int i = 0; i <= 500; i++)
                        Thread.Sleep(100000000);
        }

        private void CMSTabs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shahiraDBDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.shahiraDBDataSet1.Products);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (product_inventory_tabs.SelectedTab == tabone)//your specific tabname
            {
                // your stuff
            }
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (product_inventory_tabs.SelectedTab == tabone)//your specific tabname
                    {
                        try
                        {
                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                frm.Show(this);
                                DtProducts();
                                workbook.Worksheets.Add(dtProducts, "Products");
                                workbook.SaveAs(saveFileDialog.FileName);
                            }
                            
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        finally 
                        {
                            frm.Close();
                            MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (product_inventory_tabs.SelectedTab == tabtwo)
                    {
                        try
                        {
                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                frm.Show();
                                DtProducts();
                                workbook.Worksheets.Add(dtProducts, "Products");
                                workbook.SaveAs(saveFileDialog.FileName);
                            }
                          
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        finally
                        {
                            frm.Close();
                            MessageBox.Show("Excel file is ready to use...", "File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("There is no tab is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }


        }

        void DtProducts()
        {
            try
            {
                //Creating DataTable.
                dtProducts = new DataTable();

                //Adding the Columns.
                foreach (DataGridViewColumn column in dgvProducts.Columns)
                {
                    dtProducts.Columns.Add(column.HeaderText, column.ValueType);
                }

                //Adding the Rows.
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    dtProducts.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value != DBNull.Value)
                            {
                                dtProducts.Rows[dtProducts.Rows.Count - 1][cell.ColumnIndex] = cell.Value;
                            }
                            //else
                            //{
                            //    dtProducts.Rows[dtProducts.Rows.Count - 1][cell.ColumnIndex] = ;
                            //}
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        void DtInventory()
        {
            try
            {
                //Creating DataTable.
                dtInventory = new DataTable();

                //Adding the Columns.
                foreach (DataGridViewColumn column in dgvProducts.Columns)
                {
                    dtProducts.Columns.Add(column.HeaderText, column.ValueType);
                }

                //Adding the Rows.
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    dtProducts.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value != DBNull.Value)
                            {
                                dtProducts.Rows[dtProducts.Rows.Count - 1][cell.ColumnIndex] = cell.Value;
                            }
                            //else
                            //{
                            //    dtProducts.Rows[dtProducts.Rows.Count - 1][cell.ColumnIndex] = ;
                            //}
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
