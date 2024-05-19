namespace ToysShop.InfoForms
{
	partial class TurnoverForm
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
			dateTimePicker2 = new DateTimePicker();
			label1 = new Label();
			label2 = new Label();
			dateTimePicker1 = new DateTimePicker();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(219, 12);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(430, 150);
			dataGridView1.TabIndex = 48;
			// 
			// btnYes
			// 
			btnYes.Font = new Font("Segoe UI", 12F);
			btnYes.Location = new Point(520, 168);
			btnYes.Name = "btnYes";
			btnYes.Size = new Size(129, 36);
			btnYes.TabIndex = 45;
			btnYes.Text = "Обновить";
			btnYes.UseVisualStyleBackColor = true;
			btnYes.Click += btnYes_Click;
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.Font = new Font("Segoe UI", 12F);
			dateTimePicker2.Location = new Point(12, 133);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(182, 29);
			dateTimePicker2.TabIndex = 44;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(12, 109);
			label1.Name = "label1";
			label1.Size = new Size(58, 21);
			label1.TabIndex = 43;
			label1.Text = "Конец:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(12, 9);
			label2.Name = "label2";
			label2.Size = new Size(66, 21);
			label2.TabIndex = 42;
			label2.Text = "Начало:";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Font = new Font("Segoe UI", 12F);
			dateTimePicker1.Location = new Point(12, 33);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(182, 29);
			dateTimePicker1.TabIndex = 41;
			// 
			// TurnoverForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(657, 213);
			Controls.Add(dataGridView1);
			Controls.Add(btnYes);
			Controls.Add(dateTimePicker2);
			Controls.Add(label1);
			Controls.Add(label2);
			Controls.Add(dateTimePicker1);
			Name = "TurnoverForm";
			Text = "TurnoverForm";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Button btnYes;
		private DateTimePicker dateTimePicker2;
		private Label label1;
		private Label label2;
		private DateTimePicker dateTimePicker1;
	}
}