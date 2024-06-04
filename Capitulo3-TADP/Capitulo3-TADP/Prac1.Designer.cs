namespace Capitulo3_TADP
{
    partial class Prac1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TbNum = new System.Windows.Forms.TextBox();
            this.lbNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hacer un programa que le pida al usuario un número y la computadora responda\r\n si" +
    " es par o impar.";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(372, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TbNum
            // 
            this.TbNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNum.Location = new System.Drawing.Point(288, 149);
            this.TbNum.Name = "TbNum";
            this.TbNum.Size = new System.Drawing.Size(296, 27);
            this.TbNum.TabIndex = 2;
            this.TbNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(328, 288);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(10, 16);
            this.lbNum.TabIndex = 3;
            this.lbNum.Text = " ";
            // 
            // Prac1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.TbNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Prac1";
            this.Text = "Prac1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TbNum;
        private System.Windows.Forms.Label lbNum;
    }
}