namespace Rossihin
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
            клиентыToolStripMenuItem = new ToolStripMenuItem();
            товарыToolStripMenuItem = new ToolStripMenuItem();
            заказыToolStripMenuItem = new ToolStripMenuItem();
            приходныеНакладныеToolStripMenuItem = new ToolStripMenuItem();
            отчётToolStripMenuItem = new ToolStripMenuItem();
            неОплаченныеToolStripMenuItem = new ToolStripMenuItem();
            соотношениеToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { клиентыToolStripMenuItem, товарыToolStripMenuItem, заказыToolStripMenuItem, приходныеНакладныеToolStripMenuItem, отчётToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // клиентыToolStripMenuItem
            // 
            клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            клиентыToolStripMenuItem.Size = new Size(83, 25);
            клиентыToolStripMenuItem.Text = "Клиенты";
            клиентыToolStripMenuItem.Click += клиентыToolStripMenuItem_Click;
            // 
            // товарыToolStripMenuItem
            // 
            товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            товарыToolStripMenuItem.Size = new Size(75, 25);
            товарыToolStripMenuItem.Text = "Товары";
            товарыToolStripMenuItem.Click += товарыToolStripMenuItem_Click;
            // 
            // заказыToolStripMenuItem
            // 
            заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            заказыToolStripMenuItem.Size = new Size(73, 25);
            заказыToolStripMenuItem.Text = "Заказы";
            заказыToolStripMenuItem.Click += заказыToolStripMenuItem_Click;
            // 
            // приходныеНакладныеToolStripMenuItem
            // 
            приходныеНакладныеToolStripMenuItem.Name = "приходныеНакладныеToolStripMenuItem";
            приходныеНакладныеToolStripMenuItem.Size = new Size(186, 25);
            приходныеНакладныеToolStripMenuItem.Text = "Приходные накладные";
            приходныеНакладныеToolStripMenuItem.Click += приходныеНакладныеToolStripMenuItem_Click;
            // 
            // отчётToolStripMenuItem
            // 
            отчётToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { неОплаченныеToolStripMenuItem, соотношениеToolStripMenuItem });
            отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
            отчётToolStripMenuItem.Size = new Size(65, 25);
            отчётToolStripMenuItem.Text = "Отчёт";
            // 
            // неОплаченныеToolStripMenuItem
            // 
            неОплаченныеToolStripMenuItem.Name = "неОплаченныеToolStripMenuItem";
            неОплаченныеToolStripMenuItem.Size = new Size(191, 26);
            неОплаченныеToolStripMenuItem.Text = "Не оплаченные";
            неОплаченныеToolStripMenuItem.Click += неОплаченныеToolStripMenuItem_Click;
            // 
            // соотношениеToolStripMenuItem
            // 
            соотношениеToolStripMenuItem.Name = "соотношениеToolStripMenuItem";
            соотношениеToolStripMenuItem.Size = new Size(191, 26);
            соотношениеToolStripMenuItem.Text = "Соотношение";
            соотношениеToolStripMenuItem.Click += соотношениеToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem товарыToolStripMenuItem;
        private ToolStripMenuItem заказыToolStripMenuItem;
        private ToolStripMenuItem приходныеНакладныеToolStripMenuItem;
        private ToolStripMenuItem отчётToolStripMenuItem;
        private ToolStripMenuItem неОплаченныеToolStripMenuItem;
        private ToolStripMenuItem соотношениеToolStripMenuItem;
    }
}
