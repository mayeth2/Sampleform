namespace Chapter3
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxPosition = new System.Windows.Forms.ListBox();
            this.dateTimeHireDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLongPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrossPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalDeduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNetPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLast = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(25, 166);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add Personnel";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.Location = new System.Drawing.Point(25, 65);
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirst.TabIndex = 2;
            this.textBoxFirst.Click += new System.EventHandler(this.textBoxFirst_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // listBoxPosition
            // 
            this.listBoxPosition.FormattingEnabled = true;
            this.listBoxPosition.Items.AddRange(new object[] {
            "PO1",
            "PO2",
            "PO3",
            "SPO1",
            "SPO2",
            "SPO3",
            "SPO4",
            "INSP"});
            this.listBoxPosition.Location = new System.Drawing.Point(393, 65);
            this.listBoxPosition.Name = "listBoxPosition";
            this.listBoxPosition.Size = new System.Drawing.Size(120, 121);
            this.listBoxPosition.TabIndex = 4;
            // 
            // dateTimeHireDate
            // 
            this.dateTimeHireDate.Location = new System.Drawing.Point(580, 62);
            this.dateTimeHireDate.Name = "dateTimeHireDate";
            this.dateTimeHireDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimeHireDate.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFirst,
            this.ColumnLast,
            this.ColumnPosition,
            this.ColumnHireDate,
            this.ColumnLongPay,
            this.ColumnGrossPay,
            this.ColumnTotalSalary,
            this.ColumnTotalDeduction,
            this.ColumnNetPay});
            this.dataGridView1.Location = new System.Drawing.Point(12, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(961, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // ColumnFirst
            // 
            this.ColumnFirst.DataPropertyName = "FirstName";
            this.ColumnFirst.HeaderText = "First Name";
            this.ColumnFirst.Name = "ColumnFirst";
            // 
            // ColumnLast
            // 
            this.ColumnLast.DataPropertyName = "LastName";
            this.ColumnLast.HeaderText = "Last Name";
            this.ColumnLast.Name = "ColumnLast";
            // 
            // ColumnPosition
            // 
            this.ColumnPosition.DataPropertyName = "Position";
            this.ColumnPosition.HeaderText = "Position";
            this.ColumnPosition.Name = "ColumnPosition";
            // 
            // ColumnHireDate
            // 
            this.ColumnHireDate.DataPropertyName = "HireDate";
            this.ColumnHireDate.HeaderText = "Hire Date";
            this.ColumnHireDate.Name = "ColumnHireDate";
            // 
            // ColumnLongPay
            // 
            this.ColumnLongPay.DataPropertyName = "LongPay";
            this.ColumnLongPay.HeaderText = "Long Pay";
            this.ColumnLongPay.Name = "ColumnLongPay";
            // 
            // ColumnGrossPay
            // 
            this.ColumnGrossPay.DataPropertyName = "GrossPay";
            this.ColumnGrossPay.HeaderText = "Base Pay";
            this.ColumnGrossPay.Name = "ColumnGrossPay";
            // 
            // ColumnTotalSalary
            // 
            this.ColumnTotalSalary.DataPropertyName = "TotalSalary";
            this.ColumnTotalSalary.HeaderText = "Total Salary";
            this.ColumnTotalSalary.Name = "ColumnTotalSalary";
            // 
            // ColumnTotalDeduction
            // 
            this.ColumnTotalDeduction.DataPropertyName = "TotalDeductions";
            this.ColumnTotalDeduction.HeaderText = "Total Deductions";
            this.ColumnTotalDeduction.Name = "ColumnTotalDeduction";
            // 
            // ColumnNetPay
            // 
            this.ColumnNetPay.DataPropertyName = "NetPay";
            this.ColumnNetPay.HeaderText = "Net Pay";
            this.ColumnNetPay.Name = "ColumnNetPay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(577, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hire Date";
            // 
            // textBoxLast
            // 
            this.textBoxLast.Location = new System.Drawing.Point(174, 65);
            this.textBoxLast.Name = "textBoxLast";
            this.textBoxLast.Size = new System.Drawing.Size(100, 20);
            this.textBoxLast.TabIndex = 9;
            this.textBoxLast.Click += new System.EventHandler(this.textBoxLast_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(121, 402);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 10;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(25, 402);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 453);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxLast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimeHireDate);
            this.Controls.Add(this.listBoxPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFirst);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxPosition;
        private System.Windows.Forms.DateTimePicker dateTimeHireDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLongPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrossPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalDeduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNetPay;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
    }
}

