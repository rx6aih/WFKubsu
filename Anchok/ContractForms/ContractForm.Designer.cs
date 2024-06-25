namespace Anchok.ContractForms
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
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            отргузитьToolStripMenuItem = new ToolStripMenuItem();
            отгрузитьПолностьюToolStripMenuItem = new ToolStripMenuItem();
            отгрузитьЧастичноToolStripMenuItem = new ToolStripMenuItem();
            экспортToolStripMenuItem = new ToolStripMenuItem();
            списокToolStripMenuItem = new ToolStripMenuItem();
            импортToolStripMenuItem = new ToolStripMenuItem();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(747, 150);
            dataGridView1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, удалитьToolStripMenuItem, отргузитьToolStripMenuItem, экспортToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(760, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(71, 20);
            добавитьToolStripMenuItem.Text = "Добавить";
            добавитьToolStripMenuItem.Click += добавитьToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(63, 20);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // отргузитьToolStripMenuItem
            // 
            отргузитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отгрузитьПолностьюToolStripMenuItem, отгрузитьЧастичноToolStripMenuItem });
            отргузитьToolStripMenuItem.Name = "отргузитьToolStripMenuItem";
            отргузитьToolStripMenuItem.Size = new Size(79, 20);
            отргузитьToolStripMenuItem.Text = "Отгргузить";
            // 
            // отгрузитьПолностьюToolStripMenuItem
            // 
            отгрузитьПолностьюToolStripMenuItem.Name = "отгрузитьПолностьюToolStripMenuItem";
            отгрузитьПолностьюToolStripMenuItem.Size = new Size(194, 22);
            отгрузитьПолностьюToolStripMenuItem.Text = "Отгрузить полностью";
            отгрузитьПолностьюToolStripMenuItem.Click += отгрузитьПолностьюToolStripMenuItem_Click;
            // 
            // отгрузитьЧастичноToolStripMenuItem
            // 
            отгрузитьЧастичноToolStripMenuItem.Name = "отгрузитьЧастичноToolStripMenuItem";
            отгрузитьЧастичноToolStripMenuItem.Size = new Size(194, 22);
            отгрузитьЧастичноToolStripMenuItem.Text = "Отгрузить частично";
            отгрузитьЧастичноToolStripMenuItem.Click += отгрузитьЧастичноToolStripMenuItem_Click;
            // 
            // экспортToolStripMenuItem
            // 
            экспортToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { списокToolStripMenuItem, импортToolStripMenuItem });
            экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            экспортToolStripMenuItem.Size = new Size(81, 20);
            экспортToolStripMenuItem.Text = "Накладные";
            // 
            // списокToolStripMenuItem
            // 
            списокToolStripMenuItem.Name = "списокToolStripMenuItem";
            списокToolStripMenuItem.Size = new Size(119, 22);
            списокToolStripMenuItem.Text = "Список";
            списокToolStripMenuItem.Click += списокToolStripMenuItem_Click;
            // 
            // импортToolStripMenuItem
            // 
            импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            импортToolStripMenuItem.Size = new Size(119, 22);
            импортToolStripMenuItem.Text = "Экспорт";
            импортToolStripMenuItem.Click += экспортToolStripMenuItem_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(1, 261);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(747, 150);
            dataGridView2.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(12, 232);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Отчёт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(219, 230);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(548, 232);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 236);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 12;
            label1.Text = "Начало";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(497, 236);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 13;
            label2.Text = "Конец";
            // 
            // ContractForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 438);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Name = "ContractForm";
            Text = "ContractForm";
            Load += ContractForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem отргузитьToolStripMenuItem;
        private ToolStripMenuItem отгрузитьПолностьюToolStripMenuItem;
        private ToolStripMenuItem отгрузитьЧастичноToolStripMenuItem;
        private ToolStripMenuItem экспортToolStripMenuItem;
        private DataGridView dataGridView2;
        private Button button1;
        private ToolStripMenuItem списокToolStripMenuItem;
        private ToolStripMenuItem импортToolStripMenuItem;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
    }
}