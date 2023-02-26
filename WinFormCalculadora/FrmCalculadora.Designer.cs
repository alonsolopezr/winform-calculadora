
namespace WinFormCalculadora
{
    partial class FrmCalculadora
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSigno = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.clic_Tangente = new System.Windows.Forms.Button();
            this.clic_Seno = new System.Windows.Forms.Button();
            this.click_Coseno = new System.Windows.Forms.Button();
            this.click_elevarCuadrado = new System.Windows.Forms.Button();
            this.click_Raiz = new System.Windows.Forms.Button();
            this.click_Borrar = new System.Windows.Forms.Button();
            this.clic_PI = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(36, 20);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(8);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDisplay.Size = new System.Drawing.Size(240, 22);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSigno);
            this.panel1.Controls.Add(this.btnPunto);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Location = new System.Drawing.Point(7, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 132);
            this.panel1.TabIndex = 1;
            // 
            // btnSigno
            // 
            this.btnSigno.Location = new System.Drawing.Point(6, 96);
            this.btnSigno.Margin = new System.Windows.Forms.Padding(4);
            this.btnSigno.Name = "btnSigno";
            this.btnSigno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSigno.Size = new System.Drawing.Size(73, 28);
            this.btnSigno.TabIndex = 13;
            this.btnSigno.Text = "+/-";
            this.btnSigno.UseVisualStyleBackColor = true;
            this.btnSigno.Click += new System.EventHandler(this.btnSigno_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(164, 96);
            this.btnPunto.Margin = new System.Windows.Forms.Padding(4);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(67, 28);
            this.btnPunto.TabIndex = 12;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(87, 96);
            this.btn0.Margin = new System.Windows.Forms.Padding(4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(69, 28);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(164, 65);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(67, 28);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(87, 65);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(69, 28);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(6, 65);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(73, 28);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(164, 34);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(67, 28);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(87, 34);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(69, 28);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(6, 34);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(73, 28);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(164, 4);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(67, 28);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(87, 4);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(69, 28);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(6, 4);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(73, 28);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(250, 144);
            this.btnResta.Margin = new System.Windows.Forms.Padding(4);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(53, 28);
            this.btnResta.TabIndex = 2;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(250, 175);
            this.btnMultiplicacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(53, 28);
            this.btnMultiplicacion.TabIndex = 3;
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(250, 84);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(4);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(53, 28);
            this.btnDivision.TabIndex = 4;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(250, 116);
            this.btnSuma.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(53, 28);
            this.btnSuma.TabIndex = 5;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Enabled = false;
            this.btnIgual.Location = new System.Drawing.Point(250, 244);
            this.btnIgual.Margin = new System.Windows.Forms.Padding(4);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(53, 28);
            this.btnIgual.TabIndex = 6;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnAC
            // 
            this.btnAC.BackColor = System.Drawing.Color.MediumBlue;
            this.btnAC.ForeColor = System.Drawing.Color.White;
            this.btnAC.Location = new System.Drawing.Point(12, 84);
            this.btnAC.Margin = new System.Windows.Forms.Padding(4);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(53, 28);
            this.btnAC.TabIndex = 7;
            this.btnAC.Text = "AC";
            this.btnAC.UseVisualStyleBackColor = false;
            this.btnAC.Click += new System.EventHandler(this.button1_Click);
            // 
            // clic_Tangente
            // 
            this.clic_Tangente.Location = new System.Drawing.Point(179, 244);
            this.clic_Tangente.Margin = new System.Windows.Forms.Padding(4);
            this.clic_Tangente.Name = "clic_Tangente";
            this.clic_Tangente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clic_Tangente.Size = new System.Drawing.Size(53, 28);
            this.clic_Tangente.TabIndex = 14;
            this.clic_Tangente.Text = "TAN";
            this.clic_Tangente.UseVisualStyleBackColor = true;
            this.clic_Tangente.Click += new System.EventHandler(this.clic_Tangente_Click);
            // 
            // clic_Seno
            // 
            this.clic_Seno.Location = new System.Drawing.Point(104, 244);
            this.clic_Seno.Margin = new System.Windows.Forms.Padding(4);
            this.clic_Seno.Name = "clic_Seno";
            this.clic_Seno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clic_Seno.Size = new System.Drawing.Size(53, 28);
            this.clic_Seno.TabIndex = 15;
            this.clic_Seno.Text = "SEN";
            this.clic_Seno.UseVisualStyleBackColor = true;
            this.clic_Seno.Click += new System.EventHandler(this.clic_Seno_Click);
            // 
            // click_Coseno
            // 
            this.click_Coseno.Location = new System.Drawing.Point(27, 244);
            this.click_Coseno.Margin = new System.Windows.Forms.Padding(4);
            this.click_Coseno.Name = "click_Coseno";
            this.click_Coseno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.click_Coseno.Size = new System.Drawing.Size(53, 28);
            this.click_Coseno.TabIndex = 16;
            this.click_Coseno.Text = "COS";
            this.click_Coseno.UseVisualStyleBackColor = true;
            this.click_Coseno.Click += new System.EventHandler(this.click_Coseno_Click);
            // 
            // click_elevarCuadrado
            // 
            this.click_elevarCuadrado.Location = new System.Drawing.Point(250, 208);
            this.click_elevarCuadrado.Margin = new System.Windows.Forms.Padding(4);
            this.click_elevarCuadrado.Name = "click_elevarCuadrado";
            this.click_elevarCuadrado.Size = new System.Drawing.Size(53, 28);
            this.click_elevarCuadrado.TabIndex = 17;
            this.click_elevarCuadrado.Text = "^2";
            this.click_elevarCuadrado.UseVisualStyleBackColor = true;
            this.click_elevarCuadrado.Click += new System.EventHandler(this.click_elevarCuadrado_Click);
            // 
            // click_Raiz
            // 
            this.click_Raiz.Location = new System.Drawing.Point(131, 84);
            this.click_Raiz.Margin = new System.Windows.Forms.Padding(4);
            this.click_Raiz.Name = "click_Raiz";
            this.click_Raiz.Size = new System.Drawing.Size(53, 28);
            this.click_Raiz.TabIndex = 18;
            this.click_Raiz.Text = "√x";
            this.click_Raiz.UseVisualStyleBackColor = true;
            this.click_Raiz.Click += new System.EventHandler(this.click_Raiz_Click);
            // 
            // click_Borrar
            // 
            this.click_Borrar.Location = new System.Drawing.Point(71, 84);
            this.click_Borrar.Margin = new System.Windows.Forms.Padding(4);
            this.click_Borrar.Name = "click_Borrar";
            this.click_Borrar.Size = new System.Drawing.Size(53, 28);
            this.click_Borrar.TabIndex = 19;
            this.click_Borrar.Text = "<--";
            this.click_Borrar.UseVisualStyleBackColor = true;
            this.click_Borrar.Click += new System.EventHandler(this.click_Borrar_Click);
            // 
            // clic_PI
            // 
            this.clic_PI.Location = new System.Drawing.Point(191, 84);
            this.clic_PI.Margin = new System.Windows.Forms.Padding(4);
            this.clic_PI.Name = "clic_PI";
            this.clic_PI.Size = new System.Drawing.Size(53, 28);
            this.clic_PI.TabIndex = 20;
            this.clic_PI.Text = "PI";
            this.clic_PI.UseVisualStyleBackColor = true;
            this.clic_PI.Click += new System.EventHandler(this.clic_PI_Click);
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(89)))), ((int)(((byte)(250)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(315, 291);
            this.Controls.Add(this.clic_PI);
            this.Controls.Add(this.click_Borrar);
            this.Controls.Add(this.click_Raiz);
            this.Controls.Add(this.click_elevarCuadrado);
            this.Controls.Add(this.click_Coseno);
            this.Controls.Add(this.clic_Seno);
            this.Controls.Add(this.clic_Tangente);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDisplay);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculadora";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnSigno;
        private System.Windows.Forms.Button clic_Tangente;
        private System.Windows.Forms.Button clic_Seno;
        private System.Windows.Forms.Button click_Coseno;
        private System.Windows.Forms.Button click_elevarCuadrado;
        private System.Windows.Forms.Button click_Raiz;
        private System.Windows.Forms.Button click_Borrar;
        private System.Windows.Forms.Button clic_PI;
    }
}

