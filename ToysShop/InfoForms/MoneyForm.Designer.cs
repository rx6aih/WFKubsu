namespace ToysShop.InfoForms
{
	partial class MoneyForm
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
			label2 = new Label();
			dateTimePicker1 = new DateTimePicker();
			dateTimePicker2 = new DateTimePicker();
			label1 = new Label();
			btnYes = new Button();
			comboBox1 = new ComboBox();
			label3 = new Label();
			dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(13, 64);
			label2.Name = "label2";
			label2.Size = new Size(66, 21);
			label2.TabIndex = 33;
			label2.Text = "Начало:";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Font = new Font("Segoe UI", 12F);
			dateTimePicker1.Location = new Point(13, 88);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(182, 29);
			dateTimePicker1.TabIndex = 32;
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.Font = new Font("Segoe UI", 12F);
			dateTimePicker2.Location = new Point(13, 149);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(182, 29);
			dateTimePicker2.TabIndex = 35;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(13, 120);
			label1.Name = "label1";
			label1.Size = new Size(58, 21);
			label1.TabIndex = 34;
			label1.Text = "Конец:";
			// 
			// btnYes
			// 
			btnYes.Font = new Font("Segoe UI", 12F);
			btnYes.Location = new Point(436, 182);
			btnYes.Name = "btnYes";
			btnYes.Size = new Size(129, 36);
			btnYes.TabIndex = 36;
			btnYes.Text = "Обновить";
			btnYes.UseVisualStyleBackColor = true;
			btnYes.Click += btnYes_Click;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(82, 28);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(121, 23);
			comboBox1.TabIndex = 38;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F);
			label3.Location = new Point(12, 26);
			label3.Name = "label3";
			label3.Size = new Size(64, 21);
			label3.TabIndex = 39;
			label3.Text = "Группа:";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(222, 28);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(343, 150);
			dataGridView1.TabIndex = 40;
			// 
			// MoneyForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(577, 230);
			Controls.Add(dataGridView1);
			Controls.Add(label3);
			Controls.Add(comboBox1);
			Controls.Add(btnYes);
			Controls.Add(dateTimePicker2);
			Controls.Add(label1);
			Controls.Add(label2);
			Controls.Add(dateTimePicker1);
			Name = "MoneyForm";
			Text = "MoneyForm";
			Load += MoneyForm_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label2;
		private DateTimePicker dateTimePicker1;
		private DateTimePicker dateTimePicker2;
		private Label label1;
		private Button btnYes;
		private ComboBox comboBox1;
		private Label label3;
		private DataGridView dataGridView1;
	}
}