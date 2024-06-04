namespace Capitulo3_TADP
{
    partial class Prac4
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnObtenerDia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(334, 290);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(10, 16);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = " ";
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(294, 151);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(296, 27);
            this.txtNumero.TabIndex = 6;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnObtenerDia
            // 
            this.btnObtenerDia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnObtenerDia.Location = new System.Drawing.Point(378, 209);
            this.btnObtenerDia.Name = "btnObtenerDia";
            this.btnObtenerDia.Size = new System.Drawing.Size(121, 50);
            this.btnObtenerDia.TabIndex = 5;
            this.btnObtenerDia.Text = "Calcular";
            this.btnObtenerDia.UseVisualStyleBackColor = true;
            this.btnObtenerDia.Click += new System.EventHandler(this.btnObtenerDia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hacer un programa que le pida al usuario un número del 1 al 7 y escriba el nombre" +
    "\r\n del día que corresponde ese número en la semana.";
            // 
            // Prac4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnObtenerDia);
            this.Controls.Add(this.label1);
            this.Name = "Prac4";
            this.Text = "Prac4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnObtenerDia;
        private System.Windows.Forms.Label label1;
    }
}