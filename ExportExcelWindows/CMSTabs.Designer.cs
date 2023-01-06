namespace ExportExcelWindows
{
    partial class CMSTabs
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
            this.product_inventory_tabs = new System.Windows.Forms.TabControl();
            this.tabone = new System.Windows.Forms.TabPage();
            this.tabtwo = new System.Windows.Forms.TabPage();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.shahiraDBDataSet1 = new ExportExcelWindows.ShahiraDBDataSet1();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new ExportExcelWindows.ShahiraDBDataSet1TableAdapters.ProductsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnamearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desctextenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desctextarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgfileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isoptionsavailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ismenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iswomenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_inventory_tabs.SuspendLayout();
            this.tabone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shahiraDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // product_inventory_tabs
            // 
            this.product_inventory_tabs.Controls.Add(this.tabone);
            this.product_inventory_tabs.Controls.Add(this.tabtwo);
            this.product_inventory_tabs.Location = new System.Drawing.Point(12, 12);
            this.product_inventory_tabs.Name = "product_inventory_tabs";
            this.product_inventory_tabs.SelectedIndex = 0;
            this.product_inventory_tabs.Size = new System.Drawing.Size(1327, 658);
            this.product_inventory_tabs.TabIndex = 0;
            this.product_inventory_tabs.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabone
            // 
            this.tabone.Controls.Add(this.dgvProducts);
            this.tabone.ForeColor = System.Drawing.Color.Black;
            this.tabone.Location = new System.Drawing.Point(4, 22);
            this.tabone.Name = "tabone";
            this.tabone.Padding = new System.Windows.Forms.Padding(3);
            this.tabone.Size = new System.Drawing.Size(1319, 632);
            this.tabone.TabIndex = 0;
            this.tabone.Text = "Products";
            this.tabone.UseVisualStyleBackColor = true;
            // 
            // tabtwo
            // 
            this.tabtwo.Location = new System.Drawing.Point(4, 22);
            this.tabtwo.Name = "tabtwo";
            this.tabtwo.Padding = new System.Windows.Forms.Padding(3);
            this.tabtwo.Size = new System.Drawing.Size(1319, 632);
            this.tabtwo.TabIndex = 1;
            this.tabtwo.Text = "Inventory";
            this.tabtwo.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sidDataGridViewTextBoxColumn,
            this.categoryidDataGridViewTextBoxColumn,
            this.productnameenDataGridViewTextBoxColumn,
            this.productnamearDataGridViewTextBoxColumn,
            this.descriptionenDataGridViewTextBoxColumn,
            this.desctextenDataGridViewTextBoxColumn,
            this.descriptionarDataGridViewTextBoxColumn,
            this.desctextarDataGridViewTextBoxColumn,
            this.imgfileDataGridViewTextBoxColumn,
            this.brandidDataGridViewTextBoxColumn,
            this.isoptionsavailableDataGridViewTextBoxColumn,
            this.ismenDataGridViewTextBoxColumn,
            this.iswomenDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.productsBindingSource;
            this.dgvProducts.Location = new System.Drawing.Point(6, 6);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(1307, 620);
            this.dgvProducts.TabIndex = 0;
            // 
            // shahiraDBDataSet1
            // 
            this.shahiraDBDataSet1.DataSetName = "ShahiraDBDataSet1";
            this.shahiraDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.shahiraDBDataSet1;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1129, 672);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "sid";
            this.sidDataGridViewTextBoxColumn.HeaderText = "sid";
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "category_id";
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            // 
            // productnameenDataGridViewTextBoxColumn
            // 
            this.productnameenDataGridViewTextBoxColumn.DataPropertyName = "product_name_en";
            this.productnameenDataGridViewTextBoxColumn.HeaderText = "product_name_en";
            this.productnameenDataGridViewTextBoxColumn.Name = "productnameenDataGridViewTextBoxColumn";
            // 
            // productnamearDataGridViewTextBoxColumn
            // 
            this.productnamearDataGridViewTextBoxColumn.DataPropertyName = "product_name_ar";
            this.productnamearDataGridViewTextBoxColumn.HeaderText = "product_name_ar";
            this.productnamearDataGridViewTextBoxColumn.Name = "productnamearDataGridViewTextBoxColumn";
            // 
            // descriptionenDataGridViewTextBoxColumn
            // 
            this.descriptionenDataGridViewTextBoxColumn.DataPropertyName = "description_en";
            this.descriptionenDataGridViewTextBoxColumn.HeaderText = "description_en";
            this.descriptionenDataGridViewTextBoxColumn.Name = "descriptionenDataGridViewTextBoxColumn";
            // 
            // desctextenDataGridViewTextBoxColumn
            // 
            this.desctextenDataGridViewTextBoxColumn.DataPropertyName = "desctext_en";
            this.desctextenDataGridViewTextBoxColumn.HeaderText = "desctext_en";
            this.desctextenDataGridViewTextBoxColumn.Name = "desctextenDataGridViewTextBoxColumn";
            // 
            // descriptionarDataGridViewTextBoxColumn
            // 
            this.descriptionarDataGridViewTextBoxColumn.DataPropertyName = "description_ar";
            this.descriptionarDataGridViewTextBoxColumn.HeaderText = "description_ar";
            this.descriptionarDataGridViewTextBoxColumn.Name = "descriptionarDataGridViewTextBoxColumn";
            // 
            // desctextarDataGridViewTextBoxColumn
            // 
            this.desctextarDataGridViewTextBoxColumn.DataPropertyName = "desctext_ar";
            this.desctextarDataGridViewTextBoxColumn.HeaderText = "desctext_ar";
            this.desctextarDataGridViewTextBoxColumn.Name = "desctextarDataGridViewTextBoxColumn";
            // 
            // imgfileDataGridViewTextBoxColumn
            // 
            this.imgfileDataGridViewTextBoxColumn.DataPropertyName = "img_file";
            this.imgfileDataGridViewTextBoxColumn.HeaderText = "img_file";
            this.imgfileDataGridViewTextBoxColumn.Name = "imgfileDataGridViewTextBoxColumn";
            // 
            // brandidDataGridViewTextBoxColumn
            // 
            this.brandidDataGridViewTextBoxColumn.DataPropertyName = "brand_id";
            this.brandidDataGridViewTextBoxColumn.HeaderText = "brand_id";
            this.brandidDataGridViewTextBoxColumn.Name = "brandidDataGridViewTextBoxColumn";
            // 
            // isoptionsavailableDataGridViewTextBoxColumn
            // 
            this.isoptionsavailableDataGridViewTextBoxColumn.DataPropertyName = "is_options_available";
            this.isoptionsavailableDataGridViewTextBoxColumn.HeaderText = "is_options_available";
            this.isoptionsavailableDataGridViewTextBoxColumn.Name = "isoptionsavailableDataGridViewTextBoxColumn";
            // 
            // ismenDataGridViewTextBoxColumn
            // 
            this.ismenDataGridViewTextBoxColumn.DataPropertyName = "is_men";
            this.ismenDataGridViewTextBoxColumn.HeaderText = "is_men";
            this.ismenDataGridViewTextBoxColumn.Name = "ismenDataGridViewTextBoxColumn";
            // 
            // iswomenDataGridViewTextBoxColumn
            // 
            this.iswomenDataGridViewTextBoxColumn.DataPropertyName = "is_women";
            this.iswomenDataGridViewTextBoxColumn.HeaderText = "is_women";
            this.iswomenDataGridViewTextBoxColumn.Name = "iswomenDataGridViewTextBoxColumn";
            // 
            // CMSTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 728);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.product_inventory_tabs);
            this.Name = "CMSTabs";
            this.Text = "CMSTabs";
            this.Load += new System.EventHandler(this.CMSTabs_Load);
            this.product_inventory_tabs.ResumeLayout(false);
            this.tabone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shahiraDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl product_inventory_tabs;
        private System.Windows.Forms.TabPage tabone;
        private System.Windows.Forms.TabPage tabtwo;
        private System.Windows.Forms.DataGridView dgvProducts;
        private ShahiraDBDataSet1 shahiraDBDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ShahiraDBDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnamearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desctextenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desctextarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgfileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isoptionsavailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ismenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iswomenDataGridViewTextBoxColumn;
    }
}