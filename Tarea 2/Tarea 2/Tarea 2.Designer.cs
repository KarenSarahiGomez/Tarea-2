namespace Tarea_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.calcularPromediobutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Nota1textBox = new System.Windows.Forms.TextBox();
            this.Nota2textBox = new System.Windows.Forms.TextBox();
            this.Nota3textBox = new System.Windows.Forms.TextBox();
            this.Nota4textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calcularPromediobutton
            // 
            this.calcularPromediobutton.BackColor = System.Drawing.Color.Silver;
            this.calcularPromediobutton.Location = new System.Drawing.Point(309, 336);
            this.calcularPromediobutton.Name = "calcularPromediobutton";
            this.calcularPromediobutton.Size = new System.Drawing.Size(173, 40);
            this.calcularPromediobutton.TabIndex = 0;
            this.calcularPromediobutton.Text = "Calcular Promedio";
            this.calcularPromediobutton.UseVisualStyleBackColor = false;
            this.calcularPromediobutton.Click += new System.EventHandler(this.calcularPromediobutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Promedio final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese lo que a continuación se le solicita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota I Parcial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota II Parcial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nota III Parcial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nota IV Parcial:";
            // 
            // Nota1textBox
            // 
            this.Nota1textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Nota1textBox.Location = new System.Drawing.Point(309, 106);
            this.Nota1textBox.Name = "Nota1textBox";
            this.Nota1textBox.Size = new System.Drawing.Size(100, 26);
            this.Nota1textBox.TabIndex = 7;
            // 
            // Nota2textBox
            // 
            this.Nota2textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Nota2textBox.Location = new System.Drawing.Point(309, 161);
            this.Nota2textBox.Name = "Nota2textBox";
            this.Nota2textBox.Size = new System.Drawing.Size(100, 26);
            this.Nota2textBox.TabIndex = 8;
            // 
            // Nota3textBox
            // 
            this.Nota3textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Nota3textBox.Location = new System.Drawing.Point(309, 218);
            this.Nota3textBox.Name = "Nota3textBox";
            this.Nota3textBox.Size = new System.Drawing.Size(100, 26);
            this.Nota3textBox.TabIndex = 9;
            // 
            // Nota4textBox
            // 
            this.Nota4textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Nota4textBox.Location = new System.Drawing.Point(309, 275);
            this.Nota4textBox.Name = "Nota4textBox";
            this.Nota4textBox.Size = new System.Drawing.Size(100, 26);
            this.Nota4textBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(592, 395);
            this.Controls.Add(this.Nota4textBox);
            this.Controls.Add(this.Nota3textBox);
            this.Controls.Add(this.Nota2textBox);
            this.Controls.Add(this.Nota1textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcularPromediobutton);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Tarea 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcularPromediobutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Nota1textBox;
        private System.Windows.Forms.TextBox Nota2textBox;
        private System.Windows.Forms.TextBox Nota3textBox;
        private System.Windows.Forms.TextBox Nota4textBox;
    }
}

