﻿
namespace FormsAppEvoX
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cenaTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Корзина = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(833, 22);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(67, 56);
            this.searchButton.TabIndex = 19;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(555, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 22);
            this.textBox1.TabIndex = 20;
            // 
            // cenaTB
            // 
            this.cenaTB.Location = new System.Drawing.Point(555, 70);
            this.cenaTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cenaTB.Name = "cenaTB";
            this.cenaTB.Size = new System.Drawing.Size(202, 22);
            this.cenaTB.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(496, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Цена";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Корзина
            // 
            this.Корзина.Location = new System.Drawing.Point(917, 22);
            this.Корзина.Name = "Корзина";
            this.Корзина.Size = new System.Drawing.Size(94, 56);
            this.Корзина.TabIndex = 23;
            this.Корзина.Text = "Корзина";
            this.Корзина.UseVisualStyleBackColor = true;
            this.Корзина.Click += new System.EventHandler(this.Корзина_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1023, 478);
            this.Controls.Add(this.Корзина);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cenaTB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Главная страница";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox cenaTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Корзина;
    }
}

