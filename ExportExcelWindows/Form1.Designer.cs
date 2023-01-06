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
            this.btnExport = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.dgvExcelExport = new System.Windows.Forms.DataGridView();
            this.shahiraDBDataSet = new ExportExcelWindows.ShahiraDBDataSet();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_CategoryTableAdapter = new ExportExcelWindows.ShahiraDBDataSetTableAdapters.Product_CategoryTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listbannerimgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listbannerimgarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagebannerimgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagebannerimgarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryurlenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryurlarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logofileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryisenableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issystemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shahiraDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // dgvExcelExport
            // 
            this.dgvExcelExport.AutoGenerateColumns = false;
            this.dgvExcelExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcelExport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.parentidDataGridViewTextBoxColumn,
            this.categoryenDataGridViewTextBoxColumn,
            this.categoryarDataGridViewTextBoxColumn,
            this.descriptionenDataGridViewTextBoxColumn,
            this.descriptionarDataGridViewTextBoxColumn,
            this.listbannerimgenDataGridViewTextBoxColumn,
            this.listbannerimgarDataGridViewTextBoxColumn,
            this.pagebannerimgenDataGridViewTextBoxColumn,
            this.pagebannerimgarDataGridViewTextBoxColumn,
            this.categoryurlenDataGridViewTextBoxColumn,
            this.categoryurlarDataGridViewTextBoxColumn,
            this.logofileDataGridViewTextBoxColumn,
            this.categoryisenableDataGridViewTextBoxColumn,
            this.issystemDataGridViewTextBoxColumn});
            this.dgvExcelExport.DataSource = this.productCategoryBindingSource;
            this.dgvExcelExport.Location = new System.Drawing.Point(12, 12);
            this.dgvExcelExport.Name = "dgvExcelExport";
            this.dgvExcelExport.Size = new System.Drawing.Size(776, 386);
            this.dgvExcelExport.TabIndex = 3;
            // 
            // shahiraDBDataSet
            // 
            this.shahiraDBDataSet.DataSetName = "ShahiraDBDataSet";
            this.shahiraDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataMember = "Product_Category";
            this.productCategoryBindingSource.DataSource = this.shahiraDBDataSet;
            // 
            // product_CategoryTableAdapter
            // 
            this.product_CategoryTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // parentidDataGridViewTextBoxColumn
            // 
            this.parentidDataGridViewTextBoxColumn.DataPropertyName = "parent_id";
            this.parentidDataGridViewTextBoxColumn.HeaderText = "parent_id";
            this.parentidDataGridViewTextBoxColumn.Name = "parentidDataGridViewTextBoxColumn";
            // 
            // categoryenDataGridViewTextBoxColumn
            // 
            this.categoryenDataGridViewTextBoxColumn.DataPropertyName = "category_en";
            this.categoryenDataGridViewTextBoxColumn.HeaderText = "category_en";
            this.categoryenDataGridViewTextBoxColumn.Name = "categoryenDataGridViewTextBoxColumn";
            // 
            // categoryarDataGridViewTextBoxColumn
            // 
            this.categoryarDataGridViewTextBoxColumn.DataPropertyName = "category_ar";
            this.categoryarDataGridViewTextBoxColumn.HeaderText = "category_ar";
            this.categoryarDataGridViewTextBoxColumn.Name = "categoryarDataGridViewTextBoxColumn";
            // 
            // descriptionenDataGridViewTextBoxColumn
            // 
            this.descriptionenDataGridViewTextBoxColumn.DataPropertyName = "description_en";
            this.descriptionenDataGridViewTextBoxColumn.HeaderText = "description_en";
            this.descriptionenDataGridViewTextBoxColumn.Name = "descriptionenDataGridViewTextBoxColumn";
            // 
            // descriptionarDataGridViewTextBoxColumn
            // 
            this.descriptionarDataGridViewTextBoxColumn.DataPropertyName = "description_ar";
            this.descriptionarDataGridViewTextBoxColumn.HeaderText = "description_ar";
            this.descriptionarDataGridViewTextBoxColumn.Name = "descriptionarDataGridViewTextBoxColumn";
            // 
            // listbannerimgenDataGridViewTextBoxColumn
            // 
            this.listbannerimgenDataGridViewTextBoxColumn.DataPropertyName = "list_banner_img_en";
            this.listbannerimgenDataGridViewTextBoxColumn.HeaderText = "list_banner_img_en";
            this.listbannerimgenDataGridViewTextBoxColumn.Name = "listbannerimgenDataGridViewTextBoxColumn";
            // 
            // listbannerimgarDataGridViewTextBoxColumn
            // 
            this.listbannerimgarDataGridViewTextBoxColumn.DataPropertyName = "list_banner_img_ar";
            this.listbannerimgarDataGridViewTextBoxColumn.HeaderText = "list_banner_img_ar";
            this.listbannerimgarDataGridViewTextBoxColumn.Name = "listbannerimgarDataGridViewTextBoxColumn";
            // 
            // pagebannerimgenDataGridViewTextBoxColumn
            // 
            this.pagebannerimgenDataGridViewTextBoxColumn.DataPropertyName = "page_banner_img_en";
            this.pagebannerimgenDataGridViewTextBoxColumn.HeaderText = "page_banner_img_en";
            this.pagebannerimgenDataGridViewTextBoxColumn.Name = "pagebannerimgenDataGridViewTextBoxColumn";
            // 
            // pagebannerimgarDataGridViewTextBoxColumn
            // 
            this.pagebannerimgarDataGridViewTextBoxColumn.DataPropertyName = "page_banner_img_ar";
            this.pagebannerimgarDataGridViewTextBoxColumn.HeaderText = "page_banner_img_ar";
            this.pagebannerimgarDataGridViewTextBoxColumn.Name = "pagebannerimgarDataGridViewTextBoxColumn";
            // 
            // categoryurlenDataGridViewTextBoxColumn
            // 
            this.categoryurlenDataGridViewTextBoxColumn.DataPropertyName = "categoryurl_en";
            this.categoryurlenDataGridViewTextBoxColumn.HeaderText = "categoryurl_en";
            this.categoryurlenDataGridViewTextBoxColumn.Name = "categoryurlenDataGridViewTextBoxColumn";
            // 
            // categoryurlarDataGridViewTextBoxColumn
            // 
            this.categoryurlarDataGridViewTextBoxColumn.DataPropertyName = "categoryurl_ar";
            this.categoryurlarDataGridViewTextBoxColumn.HeaderText = "categoryurl_ar";
            this.categoryurlarDataGridViewTextBoxColumn.Name = "categoryurlarDataGridViewTextBoxColumn";
            // 
            // logofileDataGridViewTextBoxColumn
            // 
            this.logofileDataGridViewTextBoxColumn.DataPropertyName = "logo_file";
            this.logofileDataGridViewTextBoxColumn.HeaderText = "logo_file";
            this.logofileDataGridViewTextBoxColumn.Name = "logofileDataGridViewTextBoxColumn";
            // 
            // categoryisenableDataGridViewTextBoxColumn
            // 
            this.categoryisenableDataGridViewTextBoxColumn.DataPropertyName = "category_is_enable";
            this.categoryisenableDataGridViewTextBoxColumn.HeaderText = "category_is_enable";
            this.categoryisenableDataGridViewTextBoxColumn.Name = "categoryisenableDataGridViewTextBoxColumn";
            // 
            // issystemDataGridViewTextBoxColumn
            // 
            this.issystemDataGridViewTextBoxColumn.DataPropertyName = "is_system";
            this.issystemDataGridViewTextBoxColumn.HeaderText = "is_system";
            this.issystemDataGridViewTextBoxColumn.Name = "issystemDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvExcelExport);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnExport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shahiraDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.DataGridView dgvExcelExport;
        private ShahiraDBDataSet shahiraDBDataSet;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private ShahiraDBDataSetTableAdapters.Product_CategoryTableAdapter product_CategoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listbannerimgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listbannerimgarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagebannerimgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagebannerimgarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryurlenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryurlarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logofileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryisenableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issystemDataGridViewTextBoxColumn;
    }
}

