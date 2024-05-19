namespace ToysShop
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
			menuStrip1 = new MenuStrip();
			накладныеToolStripMenuItem = new ToolStripMenuItem();
			клиентыToolStripMenuItem = new ToolStripMenuItem();
			продуктыToolStripMenuItem = new ToolStripMenuItem();
			оборотToolStripMenuItem = new ToolStripMenuItem();
			отчётToolStripMenuItem = new ToolStripMenuItem();
			суммToolStripMenuItem = new ToolStripMenuItem();
			расходныеНакладныеToolStripMenuItem = new ToolStripMenuItem();
			приходныеНакладныеToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { накладныеToolStripMenuItem, клиентыToolStripMenuItem, продуктыToolStripMenuItem, оборотToolStripMenuItem, отчётToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(493, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// накладныеToolStripMenuItem
			// 
			накладныеToolStripMenuItem.Name = "накладныеToolStripMenuItem";
			накладныеToolStripMenuItem.Size = new Size(81, 20);
			накладныеToolStripMenuItem.Text = "Накладные";
			накладныеToolStripMenuItem.Click += накладныеToolStripMenuItem_Click;
			// 
			// клиентыToolStripMenuItem
			// 
			клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
			клиентыToolStripMenuItem.Size = new Size(67, 20);
			клиентыToolStripMenuItem.Text = "Клиенты";
			клиентыToolStripMenuItem.Click += клиентыToolStripMenuItem_Click;
			// 
			// продуктыToolStripMenuItem
			// 
			продуктыToolStripMenuItem.Name = "продуктыToolStripMenuItem";
			продуктыToolStripMenuItem.Size = new Size(74, 20);
			продуктыToolStripMenuItem.Text = "Продукты";
			продуктыToolStripMenuItem.Click += продуктыToolStripMenuItem_Click;
			// 
			// оборотToolStripMenuItem
			// 
			оборотToolStripMenuItem.Name = "оборотToolStripMenuItem";
			оборотToolStripMenuItem.Size = new Size(61, 20);
			оборотToolStripMenuItem.Text = "Оборот";
			оборотToolStripMenuItem.Click += оборотToolStripMenuItem_Click;
			// 
			// отчётToolStripMenuItem
			// 
			отчётToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { суммToolStripMenuItem, расходныеНакладныеToolStripMenuItem, приходныеНакладныеToolStripMenuItem });
			отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
			отчётToolStripMenuItem.Size = new Size(51, 20);
			отчётToolStripMenuItem.Text = "Отчёт";
			// 
			// суммToolStripMenuItem
			// 
			суммToolStripMenuItem.Name = "суммToolStripMenuItem";
			суммToolStripMenuItem.Size = new Size(201, 22);
			суммToolStripMenuItem.Text = "Сумм дебит/кредит";
			суммToolStripMenuItem.Click += суммToolStripMenuItem_Click;
			// 
			// расходныеНакладныеToolStripMenuItem
			// 
			расходныеНакладныеToolStripMenuItem.Name = "расходныеНакладныеToolStripMenuItem";
			расходныеНакладныеToolStripMenuItem.Size = new Size(201, 22);
			расходныеНакладныеToolStripMenuItem.Text = "Расходные накладные";
			расходныеНакладныеToolStripMenuItem.Click += расходныеНакладныеToolStripMenuItem_Click;
			// 
			// приходныеНакладныеToolStripMenuItem
			// 
			приходныеНакладныеToolStripMenuItem.Name = "приходныеНакладныеToolStripMenuItem";
			приходныеНакладныеToolStripMenuItem.Size = new Size(201, 22);
			приходныеНакладныеToolStripMenuItem.Text = "Приходные накладные";
			приходныеНакладныеToolStripMenuItem.Click += приходныеНакладныеToolStripMenuItem_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(493, 152);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "Form1";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem накладныеToolStripMenuItem;
		private ToolStripMenuItem клиентыToolStripMenuItem;
		private ToolStripMenuItem продуктыToolStripMenuItem;
		private ToolStripMenuItem оборотToolStripMenuItem;
		private ToolStripMenuItem отчётToolStripMenuItem;
		private ToolStripMenuItem суммToolStripMenuItem;
		private ToolStripMenuItem расходныеНакладныеToolStripMenuItem;
		private ToolStripMenuItem приходныеНакладныеToolStripMenuItem;
	}
}
