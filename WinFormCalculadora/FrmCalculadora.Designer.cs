
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
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSigno = new System.Windows.Forms.Button();
            this.btnTangente = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
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
            this.btnAC = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSen = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDisplay.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(14, 4);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDisplay.Size = new System.Drawing.Size(310, 31);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSen);
            this.panel1.Controls.Add(this.btnCos);
            this.panel1.Controls.Add(this.btnTangente);
            this.panel1.Controls.Add(this.btnPunto);
            this.panel1.Controls.Add(this.btnSigno);
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
            this.panel1.Location = new System.Drawing.Point(14, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 187);
            this.panel1.TabIndex = 1;
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(235, 79);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(41, 28);
            this.btnSqrt.TabIndex = 9;
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            // 
            // btnSigno
            // 
            this.btnSigno.Location = new System.Drawing.Point(112, 155);
            this.btnSigno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSigno.Name = "btnSigno";
            this.btnSigno.Size = new System.Drawing.Size(45, 28);
            this.btnSigno.TabIndex = 13;
            this.btnSigno.Text = "+/-";
            this.btnSigno.UseVisualStyleBackColor = true;
            this.btnSigno.Click += new System.EventHandler(this.btnSigno_Click);
            // 
            // btnTangente
            // 
            this.btnTangente.Location = new System.Drawing.Point(3, 12);
            this.btnTangente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTangente.Name = "btnTangente";
            this.btnTangente.Size = new System.Drawing.Size(41, 28);
            this.btnTangente.TabIndex = 8;
            this.btnTangente.Text = "Tan";
            this.btnTangente.UseVisualStyleBackColor = true;
            this.btnTangente.Click += new System.EventHandler(this.btnTangente_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(57, 155);
            this.btnPunto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(46, 28);
            this.btnPunto.TabIndex = 12;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(3, 155);
            this.btn0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(46, 28);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(112, 119);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(46, 28);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(57, 119);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(46, 28);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(282, 151);
            this.btnIgual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(41, 64);
            this.btnIgual.TabIndex = 6;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(3, 119);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(46, 28);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(111, 84);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(46, 28);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(57, 84);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(46, 28);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(3, 84);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(46, 28);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(112, 48);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(46, 28);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(57, 48);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(46, 28);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(3, 48);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(46, 28);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(183, 151);
            this.btnResta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(36, 28);
            this.btnResta.TabIndex = 2;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(183, 115);
            this.btnMultiplicacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(36, 28);
            this.btnMultiplicacion.TabIndex = 3;
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(183, 79);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(36, 28);
            this.btnDivision.TabIndex = 4;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(183, 185);
            this.btnSuma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(36, 28);
            this.btnSuma.TabIndex = 5;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnAC
            // 
            this.btnAC.BackColor = System.Drawing.Color.MediumBlue;
            this.btnAC.ForeColor = System.Drawing.Color.White;
            this.btnAC.Location = new System.Drawing.Point(183, 43);
            this.btnAC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(36, 28);
            this.btnAC.TabIndex = 7;
            this.btnAC.Text = "AC";
            this.btnAC.UseVisualStyleBackColor = false;
            this.btnAC.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOn
            // 
            this.btnOn.BackColor = System.Drawing.Color.SlateGray;
            this.btnOn.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOn.ForeColor = System.Drawing.Color.White;
            this.btnOn.Location = new System.Drawing.Point(235, 44);
            this.btnOn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(41, 28);
            this.btnOn.TabIndex = 14;
            this.btnOn.Text = "ON";
            this.btnOn.UseVisualStyleBackColor = false;
            this.btnOn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(57, 12);
            this.btnCos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(46, 28);
            this.btnCos.TabIndex = 13;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            // 
            // btnSen
            // 
            this.btnSen.Location = new System.Drawing.Point(112, 12);
            this.btnSen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSen.Name = "btnSen";
            this.btnSen.Size = new System.Drawing.Size(46, 28);
            this.btnSen.TabIndex = 14;
            this.btnSen.Text = "Sen";
            this.btnSen.UseVisualStyleBackColor = true;
            // 
            // btnPow
            // 
            this.btnPow.Location = new System.Drawing.Point(235, 115);
            this.btnPow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(41, 28);
            this.btnPow.TabIndex = 15;
            this.btnPow.Text = "^";
            this.btnPow.UseVisualStyleBackColor = true;
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.Location = new System.Drawing.Point(287, 79);
            this.btnPorcentaje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(36, 28);
            this.btnPorcentaje.TabIndex = 16;
            this.btnPorcentaje.Text = "%";
            this.btnPorcentaje.UseVisualStyleBackColor = true;
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.Color.SlateGray;
            this.btnOff.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.ForeColor = System.Drawing.Color.White;
            this.btnOff.Location = new System.Drawing.Point(283, 44);
            this.btnOff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(41, 28);
            this.btnOff.TabIndex = 17;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = false;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(336, 248);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDisplay);
            this.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button btnSigno;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnTangente;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnSen;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.Button btnOff;
    }
}

