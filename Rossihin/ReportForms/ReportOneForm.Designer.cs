namespace Rossihin.ReportForms
{
    partial class ReportOneForm
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
            dataGridView1 = new DataGridView();
            btnYes = new Button();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(453, 150);
            dataGridView1.TabIndex = 54;
            // 
            // btnYes
            // 
            btnYes.Font = new Font("Segoe UI", 12F);
            btnYes.Location = new Point(336, 7);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(129, 36);
            btnYes.TabIndex = 53;
            btnYes.Text = "Обновить";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 50;
            label2.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Location = new Point(62, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(182, 29);
            dateTimePicker1.TabIndex = 49;
            // 
            // ReportOneForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 212);
            Controls.Add(dataGridView1);
            Controls.Add(btnYes);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Name = "ReportOneForm";
            Text = "ReportOneForm";
            Load += ReportOneForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnYes;
        private Label label2;
        private DateTimePicker dateTimePicker1;
    }
}