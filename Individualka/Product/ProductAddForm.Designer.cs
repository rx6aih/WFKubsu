﻿namespace Individualka.Product
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
            button2 = new Button();
            button1 = new Button();
            tbName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(205, 204);
            button2.Name = "button2";
            button2.Size = new Size(89, 30);
            button2.TabIndex = 11;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(13, 79);
            button1.Name = "button1";
            button1.Size = new Size(121, 71);
            button1.TabIndex = 10;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(13, 43);
            tbName.Name = "tbName";
            tbName.Size = new Size(121, 23);
            tbName.TabIndex = 8;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(13, 19);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 6;
            label1.Text = "Название:";
            // 
            // ProductAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(306, 246);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbName);
            Controls.Add(label1);
            Name = "ProductAddForm";
            Text = "ProductAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox tbName;
        private Label label1;
    }
}