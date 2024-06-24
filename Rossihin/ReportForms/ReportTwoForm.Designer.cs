namespace Rossihin.ReportForms
{
    partial class ReportTwoForm
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
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(518, 150);
            dataGridView1.TabIndex = 58;
            // 
            // btnYes
            // 
            btnYes.Font = new Font("Segoe UI", 12F);
            btnYes.Location = new Point(400, 251);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(129, 36);
            btnYes.TabIndex = 57;
            btnYes.Text = "Добавить";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(11, 15);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 56;
            label2.Text = "Начало";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Location = new Point(80, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(182, 29);
            dateTimePicker1.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(286, 18);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 60;
            label1.Text = "Конец";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 12F);
            dateTimePicker2.Location = new Point(347, 15);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(182, 29);
            dateTimePicker2.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(11, 54);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 62;
            label3.Text = "Товары";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(11, 293);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(518, 150);
            dataGridView2.TabIndex = 63;
            // 
            // ReportTwoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 455);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dataGridView1);
            Controls.Add(btnYes);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Name = "ReportTwoForm";
            Text = "ReportTwoForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnYes;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private DataGridView dataGridView2;
    }
}