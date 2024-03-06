namespace APP_EJERCICIO_2
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
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Multiplicacion = new System.Windows.Forms.TextBox();
            this.txt_Resta = new System.Windows.Forms.TextBox();
            this.txt_Suma = new System.Windows.Forms.TextBox();
            this.txt_Division = new System.Windows.Forms.TextBox();
            this.txt_Valor1 = new System.Windows.Forms.TextBox();
            this.txt_Valor2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Calcular.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(130, 327);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(111, 43);
            this.btn_Calcular.TabIndex = 0;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Limpiar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(293, 327);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(111, 43);
            this.btn_Limpiar.TabIndex = 1;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Salir.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(459, 327);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(111, 43);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Suma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Multiplicacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Division";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(400, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Valor 1";
            // 
            // txt_Multiplicacion
            // 
            this.txt_Multiplicacion.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Multiplicacion.Location = new System.Drawing.Point(216, 183);
            this.txt_Multiplicacion.Name = "txt_Multiplicacion";
            this.txt_Multiplicacion.Size = new System.Drawing.Size(100, 26);
            this.txt_Multiplicacion.TabIndex = 10;
            // 
            // txt_Resta
            // 
            this.txt_Resta.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Resta.Location = new System.Drawing.Point(216, 141);
            this.txt_Resta.Name = "txt_Resta";
            this.txt_Resta.Size = new System.Drawing.Size(100, 26);
            this.txt_Resta.TabIndex = 11;
            // 
            // txt_Suma
            // 
            this.txt_Suma.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Suma.Location = new System.Drawing.Point(216, 100);
            this.txt_Suma.Name = "txt_Suma";
            this.txt_Suma.Size = new System.Drawing.Size(100, 26);
            this.txt_Suma.TabIndex = 12;
            // 
            // txt_Division
            // 
            this.txt_Division.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Division.Location = new System.Drawing.Point(216, 231);
            this.txt_Division.Name = "txt_Division";
            this.txt_Division.Size = new System.Drawing.Size(100, 26);
            this.txt_Division.TabIndex = 13;
            // 
            // txt_Valor1
            // 
            this.txt_Valor1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor1.Location = new System.Drawing.Point(470, 104);
            this.txt_Valor1.Name = "txt_Valor1";
            this.txt_Valor1.Size = new System.Drawing.Size(100, 26);
            this.txt_Valor1.TabIndex = 14;
            // 
            // txt_Valor2
            // 
            this.txt_Valor2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor2.Location = new System.Drawing.Point(470, 148);
            this.txt_Valor2.Name = "txt_Valor2";
            this.txt_Valor2.Size = new System.Drawing.Size(100, 26);
            this.txt_Valor2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Calculadora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(700, 404);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Valor2);
            this.Controls.Add(this.txt_Valor1);
            this.Controls.Add(this.txt_Division);
            this.Controls.Add(this.txt_Suma);
            this.Controls.Add(this.txt_Resta);
            this.Controls.Add(this.txt_Multiplicacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Multiplicacion;
        private System.Windows.Forms.TextBox txt_Resta;
        private System.Windows.Forms.TextBox txt_Suma;
        private System.Windows.Forms.TextBox txt_Division;
        private System.Windows.Forms.TextBox txt_Valor1;
        private System.Windows.Forms.TextBox txt_Valor2;
        private System.Windows.Forms.Label label6;
    }
}

