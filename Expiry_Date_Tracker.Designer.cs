namespace Expiry_Date_Tracker_Program
{
    partial class Expiry_Date_Tracker
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productDataDataSet2 = new Expiry_Date_Tracker_Program.ProductDataDataSet2();
            this.tblProductBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblProductTableAdapter1 = new Expiry_Date_Tracker_Program.ProductDataDataSet2TableAdapters.tblProductTableAdapter();
            this.pBarcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pBarcodeDataGridViewTextBoxColumn,
            this.pNumberDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.pDateDataGridViewTextBoxColumn,
            this.pAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblProductBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(92, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // productDataDataSet2
            // 
            this.productDataDataSet2.DataSetName = "ProductDataDataSet2";
            this.productDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductBindingSource1
            // 
            this.tblProductBindingSource1.DataMember = "tblProduct";
            this.tblProductBindingSource1.DataSource = this.productDataDataSet2;
            // 
            // tblProductTableAdapter1
            // 
            this.tblProductTableAdapter1.ClearBeforeFill = true;
            // 
            // pBarcodeDataGridViewTextBoxColumn
            // 
            this.pBarcodeDataGridViewTextBoxColumn.DataPropertyName = "pBarcode";
            this.pBarcodeDataGridViewTextBoxColumn.HeaderText = "pBarcode";
            this.pBarcodeDataGridViewTextBoxColumn.Name = "pBarcodeDataGridViewTextBoxColumn";
            // 
            // pNumberDataGridViewTextBoxColumn
            // 
            this.pNumberDataGridViewTextBoxColumn.DataPropertyName = "pNumber";
            this.pNumberDataGridViewTextBoxColumn.HeaderText = "pNumber";
            this.pNumberDataGridViewTextBoxColumn.Name = "pNumberDataGridViewTextBoxColumn";
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "pName";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "pName";
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            // 
            // pDateDataGridViewTextBoxColumn
            // 
            this.pDateDataGridViewTextBoxColumn.DataPropertyName = "pDate";
            this.pDateDataGridViewTextBoxColumn.HeaderText = "pDate";
            this.pDateDataGridViewTextBoxColumn.Name = "pDateDataGridViewTextBoxColumn";
            // 
            // pAmountDataGridViewTextBoxColumn
            // 
            this.pAmountDataGridViewTextBoxColumn.DataPropertyName = "pAmount";
            this.pAmountDataGridViewTextBoxColumn.HeaderText = "pAmount";
            this.pAmountDataGridViewTextBoxColumn.Name = "pAmountDataGridViewTextBoxColumn";
            // 
            // Expiry_Date_Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 598);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Expiry_Date_Tracker";
            this.Text = "Expiry Date Tracker v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProductDataDataSet2 productDataDataSet2;
        private System.Windows.Forms.BindingSource tblProductBindingSource1;
        private ProductDataDataSet2TableAdapters.tblProductTableAdapter tblProductTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAmountDataGridViewTextBoxColumn;
    }
}

