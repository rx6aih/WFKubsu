namespace Individualka.ContractForms
{
    partial class ContractAddForm
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
            comboBox2 = new ComboBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            tbAmount = new TextBox();
            label1 = new Label();
            btnNo = new Button();
            btnYes = new Button();
            label2 = new Label();
            tbPrice = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 83);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(129, 23);
            comboBox2.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 59);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 30;
            label6.Text = "Клиент";
            label6.Click += label6_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 28;
            label5.Text = "Продукт";
            // 
            // tbAmount
            // 
            tbAmount.Font = new Font("Segoe UI", 12F);
            tbAmount.Location = new Point(13, 138);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(129, 29);
            tbAmount.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 114);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 24;
            label1.Text = "Количество";
            // 
            // btnNo
            // 
            btnNo.Location = new Point(13, 291);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(142, 47);
            btnNo.TabIndex = 33;
            btnNo.Text = "Отмена";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // btnYes
            // 
            btnYes.Location = new Point(12, 229);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(143, 56);
            btnYes.TabIndex = 32;
            btnYes.Text = "Добавить";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 170);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 25;
            label2.Text = "Цена";
            // 
            // tbPrice
            // 
            tbPrice.Font = new Font("Segoe UI", 12F);
            tbPrice.Location = new Point(13, 194);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(129, 29);
            tbPrice.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(276, 9);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 35;
            label3.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(276, 33);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 34;
            // 
            // ContractAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(536, 350);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(tbPrice);
            Controls.Add(tbAmount);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ContractAddForm";
            Text = "ContractAddForm";
            Load += ContractAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox2;
        private Label label6;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox tbAmount;
        private Label label1;
        private Button btnNo;
        private Button btnYes;
        private Label label2;
        private TextBox tbPrice;
        private Label label3;
        private DateTimePicker dateTimePicker1;
    }
}