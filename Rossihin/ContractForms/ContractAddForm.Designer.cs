namespace Rossihin.ContractForms
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
            button1 = new Button();
            button2 = new Button();
            comboBoxClient = new ComboBox();
            label1 = new Label();
            comboBoxProd = new ComboBox();
            label2 = new Label();
            tbAmount = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(283, 106);
            button1.Name = "button1";
            button1.Size = new Size(93, 43);
            button1.TabIndex = 53;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnNo_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(13, 106);
            button2.Name = "button2";
            button2.Size = new Size(93, 43);
            button2.TabIndex = 52;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnYes_Click;
            // 
            // comboBoxClient
            // 
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(197, 42);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(179, 23);
            comboBoxClient.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(13, 40);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 50;
            label1.Text = "Клиент";
            // 
            // comboBoxProd
            // 
            comboBoxProd.FormattingEnabled = true;
            comboBoxProd.Location = new Point(197, 12);
            comboBoxProd.Name = "comboBoxProd";
            comboBoxProd.Size = new Size(179, 23);
            comboBoxProd.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(13, 10);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 48;
            label2.Text = "Продукт";
            // 
            // tbAmount
            // 
            tbAmount.Font = new Font("Segoe UI", 12F);
            tbAmount.Location = new Point(197, 71);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(179, 29);
            tbAmount.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(13, 74);
            label7.Name = "label7";
            label7.Size = new Size(93, 21);
            label7.TabIndex = 46;
            label7.Text = "Количество";
            // 
            // ContractAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 409);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(comboBoxClient);
            Controls.Add(label1);
            Controls.Add(comboBoxProd);
            Controls.Add(label2);
            Controls.Add(tbAmount);
            Controls.Add(label7);
            Name = "ContractAddForm";
            Text = "ContractAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private ComboBox comboBoxClient;
        private Label label1;
        private ComboBox comboBoxProd;
        private Label label2;
        private TextBox tbAmount;
        private Label label7;
    }
}