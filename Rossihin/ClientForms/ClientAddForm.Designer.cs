namespace Rossihin.ClientForms
{
    partial class ClientAddForm
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
            textBox1 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            tbName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 22;
            label2.Text = "Фамилия:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(148, 107);
            button2.Name = "button2";
            button2.Size = new Size(106, 30);
            button2.TabIndex = 21;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(12, 107);
            button1.Name = "button1";
            button1.Size = new Size(95, 30);
            button1.TabIndex = 20;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(103, 21);
            tbName.Name = "tbName";
            tbName.Size = new Size(151, 23);
            tbName.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 18;
            label1.Text = "Имя:";
            // 
            // ClientAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 158);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbName);
            Controls.Add(label1);
            Name = "ClientAddForm";
            Text = "ClientAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox tbName;
        private Label label1;
    }
}