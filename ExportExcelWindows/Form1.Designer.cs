namespace ExportExcelWindows
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tblBuyerAuctionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myfavouritemotorsDataSet = new ExportExcelWindows.myfavouritemotorsDataSet();
            this.tbl_Buyer_AuctionTableAdapter = new ExportExcelWindows.myfavouritemotorsDataSetTableAdapters.tbl_Buyer_AuctionTableAdapter();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblBuyerAuctionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myfavouritemotorsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblBuyerAuctionBindingSource
            // 
            this.tblBuyerAuctionBindingSource.DataMember = "tbl_Buyer_Auction";
            this.tblBuyerAuctionBindingSource.DataSource = this.myfavouritemotorsDataSet;
            // 
            // myfavouritemotorsDataSet
            // 
            this.myfavouritemotorsDataSet.DataSetName = "myfavouritemotorsDataSet";
            this.myfavouritemotorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Buyer_AuctionTableAdapter
            // 
            this.tbl_Buyer_AuctionTableAdapter.ClearBeforeFill = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(640, 404);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(148, 34);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(492, 404);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(134, 33);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 386);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnExport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBuyerAuctionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myfavouritemotorsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private myfavouritemotorsDataSet myfavouritemotorsDataSet;
        private System.Windows.Forms.BindingSource tblBuyerAuctionBindingSource;
        private myfavouritemotorsDataSetTableAdapters.tbl_Buyer_AuctionTableAdapter tbl_Buyer_AuctionTableAdapter;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

