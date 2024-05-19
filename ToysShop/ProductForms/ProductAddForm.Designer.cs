namespace ToysShop.ProductForms
{
	partial class ProductAddForm
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
			label1 = new Label();
			label2 = new Label();
			tbName = new TextBox();
			comboBox1 = new ComboBox();
			button1 = new Button();
			button2 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(12, 33);
			label1.Name = "label1";
			label1.Size = new Size(81, 21);
			label1.TabIndex = 0;
			label1.Text = "Название:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(12, 76);
			label2.Name = "label2";
			label2.Size = new Size(64, 21);
			label2.TabIndex = 1;
			label2.Text = "Группа:";
			// 
			// tbName
			// 
			tbName.Location = new Point(99, 35);
			tbName.Name = "tbName";
			tbName.Size = new Size(121, 23);
			tbName.TabIndex = 2;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(99, 78);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(121, 23);
			comboBox1.TabIndex = 3;
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 12F);
			button1.Location = new Point(12, 133);
			button1.Name = "button1";
			button1.Size = new Size(89, 30);
			button1.TabIndex = 4;
			button1.Text = "Добавить";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Font = new Font("Segoe UI", 12F);
			button2.Location = new Point(131, 133);
			button2.Name = "button2";
			button2.Size = new Size(89, 30);
			button2.TabIndex = 5;
			button2.Text = "Отмена";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// ProductAddForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(234, 186);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(comboBox1);
			Controls.Add(tbName);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "ProductAddForm";
			Text = "ProductAddForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox tbName;
		private ComboBox comboBox1;
		private Button button1;
		private Button button2;
	}
}