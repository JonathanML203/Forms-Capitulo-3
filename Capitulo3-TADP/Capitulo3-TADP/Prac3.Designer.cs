namespace Capitulo3_TADP
{
    partial class Prac3
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
            this.rbtnOtro = new System.Windows.Forms.RadioButton();
            this.rbtnMedicina = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtnOtro
            // 
            this.rbtnOtro.AutoSize = true;
            this.rbtnOtro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOtro.Location = new System.Drawing.Point(61, 210);
            this.rbtnOtro.Name = "rbtnOtro";
            this.rbtnOtro.Size = new System.Drawing.Size(71, 27);
            this.rbtnOtro.TabIndex = 15;
            this.rbtnOtro.TabStop = true;
            this.rbtnOtro.Text = "Otro";
            this.rbtnOtro.UseVisualStyleBackColor = true;
            // 
            // rbtnMedicina
            // 
            this.rbtnMedicina.AutoSize = true;
            this.rbtnMedicina.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMedicina.Location = new System.Drawing.Point(61, 152);
            this.rbtnMedicina.Name = "rbtnMedicina";
            this.rbtnMedicina.Size = new System.Drawing.Size(109, 27);
            this.rbtnMedicina.TabIndex = 14;
            this.rbtnMedicina.TabStop = true;
            this.rbtnMedicina.Text = "Medicina";
            this.rbtnMedicina.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(378, 291);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(10, 16);
            this.lblResultado.TabIndex = 13;
            this.lblResultado.Text = " ";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(338, 152);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(296, 27);
            this.txtPrecio.TabIndex = 12;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcular.Location = new System.Drawing.Point(422, 210);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 50);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(721, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hacer un programa que transforme de grados a radianes o de radianes a grados\r\n de" +
    "pendiendo de lo que necesite el usuario.\r\n";
            // 
            // Prac3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtnOtro);
            this.Controls.Add(this.rbtnMedicina);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Name = "Prac3";
            this.Text = "Prac3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnOtro;
        private System.Windows.Forms.RadioButton rbtnMedicina;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
    }
}