namespace ToysShop.InvoiceForms
{
	partial class InvoicePayForm
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
			tbAmount = new TextBox();
			label1 = new Label();
			btnNo = new Button();
			btnYes = new Button();
			SuspendLayout();
			// 
			// tbAmount
			// 
			tbAmount.Font = new Font("Segoe UI", 12F);
			tbAmount.Location = new Point(92, 19);
			tbAmount.Name = "tbAmount";
			tbAmount.Size = new Size(129, 29);
			tbAmount.TabIndex = 15;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(19, 22);
			label1.Name = "label1";
			label1.Size = new Size(58, 21);
			label1.TabIndex = 14;
			label1.Text = "Сумма";
			// 
			// btnNo
			// 
			btnNo.Location = new Point(146, 81);
			btnNo.Name = "btnNo";
			btnNo.Size = new Size(75, 23);
			btnNo.TabIndex = 21;
			btnNo.Text = "Отмена";
			btnNo.UseVisualStyleBackColor = true;
			btnNo.Click += btnNo_Click;
			// 
			// btnYes
			// 
			btnYes.Location = new Point(19, 81);
			btnYes.Name = "btnYes";
			btnYes.Size = new Size(75, 23);
			btnYes.TabIndex = 20;
			btnYes.Text = "Оплата";
			btnYes.UseVisualStyleBackColor = true;
			btnYes.Click += btnYes_Click;
			// 
			// InvoicePayForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(233, 121);
			Controls.Add(btnNo);
			Controls.Add(btnYes);
			Controls.Add(tbAmount);
			Controls.Add(label1);
			Name = "InvoicePayForm";
			Text = "InvoicePayForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbAmount;
		private Label label1;
		private Button btnNo;
		private Button btnYes;
	}
}