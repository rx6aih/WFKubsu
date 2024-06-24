namespace Rossihin.ContractForms
{
    partial class ContractForm
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
            menuStrip1 = new MenuStrip();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            buttonPay = new Button();
            buttonDeliv = new Button();
            dataGridView1 = new DataGridView();
            экспортToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, удалитьToolStripMenuItem, экспортToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(665, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(91, 25);
            добавитьToolStripMenuItem.Text = "Добавить";
            добавитьToolStripMenuItem.Click += добавитьToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(80, 25);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // buttonPay
            // 
            buttonPay.Font = new Font("Segoe UI", 12F);
            buttonPay.Location = new Point(474, 203);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(88, 44);
            buttonPay.TabIndex = 1;
            buttonPay.Text = "Оплатить";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += buttonPay_Click;
            // 
            // buttonDeliv
            // 
            buttonDeliv.Font = new Font("Segoe UI", 12F);
            buttonDeliv.Location = new Point(568, 203);
            buttonDeliv.Name = "buttonDeliv";
            buttonDeliv.Size = new Size(88, 44);
            buttonDeliv.TabIndex = 2;
            buttonDeliv.Text = "Доставка";
            buttonDeliv.UseVisualStyleBackColor = true;
            buttonDeliv.Click += buttonDeliv_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 150);
            dataGridView1.TabIndex = 3;
            // 
            // экспортToolStripMenuItem
            // 
            экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            экспортToolStripMenuItem.Size = new Size(81, 25);
            экспортToolStripMenuItem.Text = "Экспорт";
            экспортToolStripMenuItem.Click += экспортToolStripMenuItem_Click;
            // 
            // ContractForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 261);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDeliv);
            Controls.Add(buttonPay);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ContractForm";
            Text = "ContractForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private Button buttonPay;
        private Button buttonDeliv;
        private DataGridView dataGridView1;
        private ToolStripMenuItem экспортToolStripMenuItem;
    }
}