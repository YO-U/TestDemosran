namespace TestDemosran
{
    partial class ManagerForm
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
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeTechTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeTechModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemDescryptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairPartsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDemoDataSet = new TestDemosran.TestDemoDataSet();
            this.requestsTableAdapter = new TestDemosran.TestDemoDataSetTableAdapters.RequestsTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.requestsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSaveDate = new System.Windows.Forms.Button();
            this.labelCountReq = new System.Windows.Forms.Label();
            this.labelAvgDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.homeTechTypeDataGridViewTextBoxColumn,
            this.homeTechModelDataGridViewTextBoxColumn,
            this.problemDescryptionDataGridViewTextBoxColumn,
            this.requestStatusDataGridViewTextBoxColumn,
            this.completionDateDataGridViewTextBoxColumn,
            this.repairPartsDataGridViewTextBoxColumn,
            this.masterIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.requestsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1133, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // requestIDDataGridViewTextBoxColumn
            // 
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "requestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "requestID";
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            this.requestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // homeTechTypeDataGridViewTextBoxColumn
            // 
            this.homeTechTypeDataGridViewTextBoxColumn.DataPropertyName = "homeTechType";
            this.homeTechTypeDataGridViewTextBoxColumn.HeaderText = "homeTechType";
            this.homeTechTypeDataGridViewTextBoxColumn.Name = "homeTechTypeDataGridViewTextBoxColumn";
            // 
            // homeTechModelDataGridViewTextBoxColumn
            // 
            this.homeTechModelDataGridViewTextBoxColumn.DataPropertyName = "homeTechModel";
            this.homeTechModelDataGridViewTextBoxColumn.HeaderText = "homeTechModel";
            this.homeTechModelDataGridViewTextBoxColumn.Name = "homeTechModelDataGridViewTextBoxColumn";
            // 
            // problemDescryptionDataGridViewTextBoxColumn
            // 
            this.problemDescryptionDataGridViewTextBoxColumn.DataPropertyName = "problemDescryption";
            this.problemDescryptionDataGridViewTextBoxColumn.HeaderText = "problemDescryption";
            this.problemDescryptionDataGridViewTextBoxColumn.Name = "problemDescryptionDataGridViewTextBoxColumn";
            // 
            // requestStatusDataGridViewTextBoxColumn
            // 
            this.requestStatusDataGridViewTextBoxColumn.DataPropertyName = "requestStatus";
            this.requestStatusDataGridViewTextBoxColumn.HeaderText = "requestStatus";
            this.requestStatusDataGridViewTextBoxColumn.Name = "requestStatusDataGridViewTextBoxColumn";
            // 
            // completionDateDataGridViewTextBoxColumn
            // 
            this.completionDateDataGridViewTextBoxColumn.DataPropertyName = "completionDate";
            this.completionDateDataGridViewTextBoxColumn.HeaderText = "completionDate";
            this.completionDateDataGridViewTextBoxColumn.Name = "completionDateDataGridViewTextBoxColumn";
            // 
            // repairPartsDataGridViewTextBoxColumn
            // 
            this.repairPartsDataGridViewTextBoxColumn.DataPropertyName = "repairParts";
            this.repairPartsDataGridViewTextBoxColumn.HeaderText = "repairParts";
            this.repairPartsDataGridViewTextBoxColumn.Name = "repairPartsDataGridViewTextBoxColumn";
            // 
            // masterIDDataGridViewTextBoxColumn
            // 
            this.masterIDDataGridViewTextBoxColumn.DataPropertyName = "masterID";
            this.masterIDDataGridViewTextBoxColumn.HeaderText = "masterID";
            this.masterIDDataGridViewTextBoxColumn.Name = "masterIDDataGridViewTextBoxColumn";
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "clientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "clientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataMember = "Requests";
            this.requestsBindingSource.DataSource = this.testDemoDataSet;
            // 
            // testDemoDataSet
            // 
            this.testDemoDataSet.DataSetName = "TestDemoDataSet";
            this.testDemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestsTableAdapter
            // 
            this.requestsTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1182, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // requestsBindingSource1
            // 
            this.requestsBindingSource1.DataMember = "Requests";
            this.requestsBindingSource1.DataSource = this.testDemoDataSet;
            // 
            // buttonSaveDate
            // 
            this.buttonSaveDate.Location = new System.Drawing.Point(1252, 388);
            this.buttonSaveDate.Name = "buttonSaveDate";
            this.buttonSaveDate.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveDate.TabIndex = 2;
            this.buttonSaveDate.Text = "button1";
            this.buttonSaveDate.UseVisualStyleBackColor = true;
            this.buttonSaveDate.Click += new System.EventHandler(this.buttonSaveDate_Click);
            // 
            // labelCountReq
            // 
            this.labelCountReq.AutoSize = true;
            this.labelCountReq.Location = new System.Drawing.Point(144, 412);
            this.labelCountReq.Name = "labelCountReq";
            this.labelCountReq.Size = new System.Drawing.Size(35, 13);
            this.labelCountReq.TabIndex = 3;
            this.labelCountReq.Text = "label1";
            this.labelCountReq.Click += new System.EventHandler(this.labelCountReq_Click);
            // 
            // labelAvgDate
            // 
            this.labelAvgDate.AutoSize = true;
            this.labelAvgDate.Location = new System.Drawing.Point(328, 412);
            this.labelAvgDate.Name = "labelAvgDate";
            this.labelAvgDate.Size = new System.Drawing.Size(35, 13);
            this.labelAvgDate.TabIndex = 4;
            this.labelAvgDate.Text = "label1";
            this.labelAvgDate.Click += new System.EventHandler(this.labelAvgDate_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 496);
            this.Controls.Add(this.labelAvgDate);
            this.Controls.Add(this.labelCountReq);
            this.Controls.Add(this.buttonSaveDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TestDemoDataSet testDemoDataSet;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private TestDemoDataSetTableAdapters.RequestsTableAdapter requestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeTechTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeTechModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemDescryptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairPartsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource requestsBindingSource1;
        private System.Windows.Forms.Button buttonSaveDate;
        private System.Windows.Forms.Label labelCountReq;
        private System.Windows.Forms.Label labelAvgDate;
    }
}