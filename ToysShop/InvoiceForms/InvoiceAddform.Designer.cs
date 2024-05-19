namespace ToysShop.InvoiceForms
{
	partial class InvoiceAddform
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
			btnNo = new Button();
			btnYes = new Button();
			label4 = new Label();
			comboBox3 = new ComboBox();
			tbFirstPayment = new TextBox();
			tbPrice = new TextBox();
			tbAmount = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			label5 = new Label();
			comboBox1 = new ComboBox();
			comboBox2 = new ComboBox();
			label6 = new Label();
			SuspendLayout();
			// 
			// btnNo
			// 
			btnNo.Location = new Point(250, 231);
			btnNo.Name = "btnNo";
			btnNo.Size = new Size(75, 23);
			btnNo.TabIndex = 19;
			btnNo.Text = "Отмена";
			btnNo.UseVisualStyleBackColor = true;
			btnNo.Click += btnNo_Click;
			// 
			// btnYes
			// 
			btnYes.Location = new Point(12, 231);
			btnYes.Name = "btnYes";
			btnYes.Size = new Size(75, 23);
			btnYes.TabIndex = 18;
			btnYes.Text = "Добавить";
			btnYes.UseVisualStyleBackColor = true;
			btnYes.Click += btnYes_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F);
			label4.Location = new Point(12, 181);
			label4.Name = "label4";
			label4.Size = new Size(117, 21);
			label4.TabIndex = 17;
			label4.Text = "Тип накладной";
			// 
			// comboBox3
			// 
			comboBox3.Font = new Font("Segoe UI", 12F);
			comboBox3.FormattingEnabled = true;
			comboBox3.Items.AddRange(new object[] { "Приходная", "Расходная" });
			comboBox3.Location = new Point(196, 178);
			comboBox3.Name = "comboBox3";
			comboBox3.Size = new Size(129, 29);
			comboBox3.TabIndex = 16;
			// 
			// tbFirstPayment
			// 
			tbFirstPayment.Font = new Font("Segoe UI", 12F);
			tbFirstPayment.Location = new Point(196, 144);
			tbFirstPayment.Name = "tbFirstPayment";
			tbFirstPayment.Size = new Size(129, 29);
			tbFirstPayment.TabIndex = 15;
			tbFirstPayment.Text = "0";
			// 
			// tbPrice
			// 
			tbPrice.Font = new Font("Segoe UI", 12F);
			tbPrice.Location = new Point(196, 109);
			tbPrice.Name = "tbPrice";
			tbPrice.Size = new Size(129, 29);
			tbPrice.TabIndex = 14;
			// 
			// tbAmount
			// 
			tbAmount.Font = new Font("Segoe UI", 12F);
			tbAmount.Location = new Point(196, 74);
			tbAmount.Name = "tbAmount";
			tbAmount.Size = new Size(129, 29);
			tbAmount.TabIndex = 13;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F);
			label3.Location = new Point(12, 147);
			label3.Name = "label3";
			label3.Size = new Size(178, 21);
			label3.TabIndex = 12;
			label3.Text = "Первоначальный взнос";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(12, 109);
			label2.Name = "label2";
			label2.Size = new Size(47, 21);
			label2.TabIndex = 11;
			label2.Text = "Цена";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(12, 77);
			label1.Name = "label1";
			label1.Size = new Size(93, 21);
			label1.TabIndex = 10;
			label1.Text = "Количество";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F);
			label5.Location = new Point(12, 13);
			label5.Name = "label5";
			label5.Size = new Size(71, 21);
			label5.TabIndex = 20;
			label5.Text = "Продукт";
			label5.Click += label5_Click;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(196, 15);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(129, 23);
			comboBox1.TabIndex = 21;
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(196, 45);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(129, 23);
			comboBox2.TabIndex = 23;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F);
			label6.Location = new Point(12, 43);
			label6.Name = "label6";
			label6.Size = new Size(60, 21);
			label6.TabIndex = 22;
			label6.Text = "Клиент";
			// 
			// InvoiceAddform
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(345, 266);
			Controls.Add(comboBox2);
			Controls.Add(label6);
			Controls.Add(comboBox1);
			Controls.Add(label5);
			Controls.Add(btnNo);
			Controls.Add(btnYes);
			Controls.Add(label4);
			Controls.Add(comboBox3);
			Controls.Add(tbFirstPayment);
			Controls.Add(tbPrice);
			Controls.Add(tbAmount);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "InvoiceAddform";
			Text = "InvoiceAddform";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnNo;
		private Button btnYes;
		private Label label4;
		private ComboBox comboBox3;
		private TextBox tbFirstPayment;
		private TextBox tbPrice;
		private TextBox tbAmount;
		private Label label3;
		private Label label2;
		private Label label1;
		private Label label5;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private Label label6;
	}
}