using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio_LibCalc;

namespace WinFormCalculadora
{
    public partial class FrmCalculadora : Form
    {
        //var de class abrstract para aceder a OTDAS las operaciones
        Operacion oper = null;

        string operador = "";
        //opoerandos
        private double _op1 = 0;
        private double _op2 = 0;
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //activar una bandera
            this.operador = "+";
            //tomamos ope1
            this._op1 = double.Parse(txtDisplay.Text);
            //limpiar el display
            txtDisplay.Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text=="0")
                txtDisplay.Text = "1";
            else
                txtDisplay.Text += "1"; 
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text="2";
            else
                txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "3";
            else
                txtDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "4";
            else
                txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "5";
            else
                txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "6";
            else
                txtDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "7";
            else
                txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "8";
            else
                txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "9";
            else
                txtDisplay.Text += "9";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //capturamos el op2
            this._op2 = double.Parse(txtDisplay.Text);
            //instanciamos la clase de la ioperacion seleccionada
            switch (this.operador)
            {
                case "+":
                    oper = new Suma(this._op1, this._op2); 
                    break;
                case "-":
                    oper = new Resta(this._op1, this._op2);
                    break;
                case "*":
                    oper = new Multiplicacion(this._op1, this._op2);
                    break;
                case "/":
                    oper = new Division(this._op1, this._op2);
                    break;
                default:
                    operador = "";
                    break;
            }
            //ejecutamos la operacion
            txtDisplay.Text = oper.ejecutar().ToString();
            
                
                //limpiar la operador =
                this.operador = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //activar una bandera
            this.operador = "-" + this._op1;
            //tomamos ope1
            this._op1 = double.Parse(txtDisplay.Text);
            //limpiar el display
            txtDisplay.Clear();
            
        }

        private void btn0_Click(object sender, EventArgs e)
        {

            if (txtDisplay.Text == "0")
                txtDisplay.Text = "0";
            else
                txtDisplay.Text += "0";
        
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            //agregamos el punto 
            txtDisplay.Text += ".";
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            //txtDisplay.Text += "-";
            txtDisplay.Text = "-" + txtDisplay.Text; //23.54 +/- = -23.54
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //limpiamos
            txtDisplay.Text = "0";
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                //hay algo alo qu le calcularemos la tan
                oper = new Tangente(double.Parse(txtDisplay.Text));
                //calculmos la tngente, y ponemos el res en el display
                double res = oper.ejecutar();
                txtDisplay.Text = res.ToString();
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
                if (txtDisplay.Text != "")
                {
                    oper = new Raiz_Sqrt(double.Parse(txtDisplay.Text));
                    double res = oper.ejecutar();
                    txtDisplay.Text = res.ToString();
                }
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
