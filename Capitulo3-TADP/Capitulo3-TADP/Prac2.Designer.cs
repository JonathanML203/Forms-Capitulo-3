namespace Capitulo3_TADP
{
    partial class Prac2
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnGradosARadianes = new System.Windows.Forms.RadioButton();
            this.rbtnRadianesAGrados = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(376, 293);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(10, 16);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = " ";
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(336, 154);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(296, 27);
            this.txtValor.TabIndex = 6;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConvertir
            // 
            this.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConvertir.Location = new System.Drawing.Point(420, 212);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(121, 50);
            this.btnConvertir.TabIndex = 5;
            this.btnConvertir.Text = "Calcular";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(721, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hacer un programa que transforme de grados a radianes o de radianes a grados\r\n de" +
    "pendiendo de lo que necesite el usuario.\r\n";
            // 
            // rbtnGradosARadianes
            // 
            this.rbtnGradosARadianes.AutoSize = true;
            this.rbtnGradosARadianes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGradosARadianes.Location = new System.Drawing.Point(59, 154);
            this.rbtnGradosARadianes.Name = "rbtnGradosARadianes";
            this.rbtnGradosARadianes.Size = new System.Drawing.Size(202, 27);
            this.rbtnGradosARadianes.TabIndex = 8;
            this.rbtnGradosARadianes.TabStop = true;
            this.rbtnGradosARadianes.Text = "Grados a Radianes";
            this.rbtnGradosARadianes.UseVisualStyleBackColor = true;
            // 
            // rbtnRadianesAGrados
            // 
            this.rbtnRadianesAGrados.AutoSize = true;
            this.rbtnRadianesAGrados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRadianesAGrados.Location = new System.Drawing.Point(59, 212);
            this.rbtnRadianesAGrados.Name = "rbtnRadianesAGrados";
            this.rbtnRadianesAGrados.Size = new System.Drawing.Size(202, 27);
            this.rbtnRadianesAGrados.TabIndex = 9;
            this.rbtnRadianesAGrados.TabStop = true;
            this.rbtnRadianesAGrados.Text = "Radianes a Grados";
            this.rbtnRadianesAGrados.UseVisualStyleBackColor = true;
            // 
            // Prac2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtnRadianesAGrados);
            this.Controls.Add(this.rbtnGradosARadianes);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label1);
            this.Name = "Prac2";
            this.Text = "Prac2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnGradosARadianes;
        private System.Windows.Forms.RadioButton rbtnRadianesAGrados;
    }
}