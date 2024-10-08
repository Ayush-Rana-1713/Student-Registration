namespace studentreg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtFee = new TextBox();
            txtCourse = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(396, 41);
            label1.Name = "label1";
            label1.Size = new Size(436, 60);
            label1.TabIndex = 0;
            label1.Text = "Student Registation";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFee);
            groupBox1.Controls.Add(txtCourse);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 160);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 286);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Registation";
            // 
            // txtFee
            // 
            txtFee.Location = new Point(203, 202);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(265, 30);
            txtFee.TabIndex = 7;
            txtFee.TextChanged += txtName_TextChanged;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(203, 133);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(265, 30);
            txtCourse.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(203, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 30);
            txtName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 202);
            label4.Name = "label4";
            label4.Size = new Size(36, 23);
            label4.TabIndex = 4;
            label4.Text = "Fee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 65);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 2;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 133);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 3;
            label3.Text = "Course";
            // 
            // button1
            // 
            button1.Location = new Point(21, 474);
            button1.Name = "button1";
            button1.Size = new Size(133, 101);
            button1.TabIndex = 8;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(191, 474);
            button2.Name = "button2";
            button2.Size = new Size(135, 101);
            button2.TabIndex = 9;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Edit, Delete });
            dataGridView1.Location = new Point(551, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(801, 336);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Student Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Course";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Fee";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Edit
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Edit.DefaultCellStyle = dataGridViewCellStyle1;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 125;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.DefaultCellStyle = dataGridViewCellStyle2;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 125;
            // 
            // button3
            // 
            button3.Location = new Point(551, 511);
            button3.Name = "button3";
            button3.Size = new Size(154, 64);
            button3.TabIndex = 11;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 690);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtFee;
        private TextBox txtCourse;
        private TextBox txtName;
        private Label label4;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button button3;
    }
}
