namespace ToysShop.InvoiceForms
{
	partial class InvoiceForm
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
			button1 = new Button();
			dataGridView1 = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			dataGridView2 = new DataGridView();
			button2 = new Button();
			button3 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(12, 12);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 0;
			button1.Text = "Добавить";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 71);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(949, 150);
			dataGridView1.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(12, 47);
			label1.Name = "label1";
			label1.Size = new Size(92, 21);
			label1.TabIndex = 3;
			label1.Text = "Приходные";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(12, 232);
			label2.Name = "label2";
			label2.Size = new Size(87, 21);
			label2.TabIndex = 5;
			label2.Text = "Расходные";
			// 
			// dataGridView2
			// 
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Location = new Point(12, 256);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.Size = new Size(949, 150);
			dataGridView2.TabIndex = 4;
			// 
			// button2
			// 
			button2.Location = new Point(886, 227);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 6;
			button2.Text = "Оплата";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(886, 412);
			button3.Name = "button3";
			button3.Size = new Size(75, 23);
			button3.TabIndex = 7;
			button3.Text = "Оплата";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// InvoiceForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(973, 450);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(label2);
			Controls.Add(dataGridView2);
			Controls.Add(label1);
			Controls.Add(dataGridView1);
			Controls.Add(button1);
			Name = "InvoiceForm";
			Text = "InvoiceForm";
			Load += InvoiceForm_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private DataGridView dataGridView1;
		private Label label1;
		private Label label2;
		private DataGridView dataGridView2;
		private Button button2;
		private Button button3;
	}
}