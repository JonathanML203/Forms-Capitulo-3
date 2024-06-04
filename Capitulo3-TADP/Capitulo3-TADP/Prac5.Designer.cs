namespace Capitulo3_TADP
{
    partial class Prac5
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
            this.rbtnArea = new System.Windows.Forms.RadioButton();
            this.rbtnPerimetro = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNumLados = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLongitudLado = new System.Windows.Forms.TextBox();
            this.lblApotema = new System.Windows.Forms.Label();
            this.txtApotema = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbtnArea
            // 
            this.rbtnArea.AutoSize = true;
            this.rbtnArea.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnArea.Location = new System.Drawing.Point(63, 173);
            this.rbtnArea.Name = "rbtnArea";
            this.rbtnArea.Size = new System.Drawing.Size(73, 27);
            this.rbtnArea.TabIndex = 21;
            this.rbtnArea.TabStop = true;
            this.rbtnArea.Text = "Area";
            this.rbtnArea.UseVisualStyleBackColor = true;
            // 
            // rbtnPerimetro
            // 
            this.rbtnPerimetro.AutoSize = true;
            this.rbtnPerimetro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPerimetro.Location = new System.Drawing.Point(63, 115);
            this.rbtnPerimetro.Name = "rbtnPerimetro";
            this.rbtnPerimetro.Size = new System.Drawing.Size(117, 27);
            this.rbtnPerimetro.TabIndex = 20;
            this.rbtnPerimetro.TabStop = true;
            this.rbtnPerimetro.Text = "Perimetro";
            this.rbtnPerimetro.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(380, 356);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(10, 16);
            this.lblResultado.TabIndex = 19;
            this.lblResultado.Text = " ";
            // 
            // txtNumLados
            // 
            this.txtNumLados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumLados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumLados.Location = new System.Drawing.Point(338, 124);
            this.txtNumLados.Name = "txtNumLados";
            this.txtNumLados.Size = new System.Drawing.Size(296, 27);
            this.txtNumLados.TabIndex = 18;
            this.txtNumLados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcular.Location = new System.Drawing.Point(63, 242);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 50);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hacer un programa que pueda calcular el perímetro y el área de cualquier polígono" +
    "\r\n regular, pero que le pregunte al usuario qué desea calcular.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Entrada del número de lados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Entrada de la longitud de un lado:";
            // 
            // txtLongitudLado
            // 
            this.txtLongitudLado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLongitudLado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongitudLado.Location = new System.Drawing.Point(338, 205);
            this.txtLongitudLado.Name = "txtLongitudLado";
            this.txtLongitudLado.Size = new System.Drawing.Size(296, 27);
            this.txtLongitudLado.TabIndex = 23;
            this.txtLongitudLado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblApotema
            // 
            this.lblApotema.AutoSize = true;
            this.lblApotema.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApotema.Location = new System.Drawing.Point(346, 242);
            this.lblApotema.Name = "lblApotema";
            this.lblApotema.Size = new System.Drawing.Size(200, 23);
            this.lblApotema.TabIndex = 26;
            this.lblApotema.Text = "Entrada del apotema:";
            // 
            // txtApotema
            // 
            this.txtApotema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApotema.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApotema.Location = new System.Drawing.Point(338, 279);
            this.txtApotema.Name = "txtApotema";
            this.txtApotema.Size = new System.Drawing.Size(296, 27);
            this.txtApotema.TabIndex = 25;
            this.txtApotema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Prac5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblApotema);
            this.Controls.Add(this.txtApotema);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLongitudLado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnArea);
            this.Controls.Add(this.rbtnPerimetro);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumLados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Name = "Prac5";
            this.Text = "Prac5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnArea;
        private System.Windows.Forms.RadioButton rbtnPerimetro;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNumLados;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLongitudLado;
        private System.Windows.Forms.Label lblApotema;
        private System.Windows.Forms.TextBox txtApotema;
    }
}