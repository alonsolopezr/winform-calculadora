using System;
using System.CodeDom.Compiler;
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
            //Habilitamos el boton igual. 
            btnIgual.Enabled = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "1";
            else
                txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "2";
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
            //Se desabilitará de nuevo el boton igual, esto ocurre en los casos de operaciones binarias (que necesiten dos operando)
            btnIgual.Enabled = false;
            //limpiar la operador =
            this.operador = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //activar una bandera
            this.operador = "-";
            //tomamos ope1
            this._op1 = double.Parse(txtDisplay.Text);
            //limpiar el display
            txtDisplay.Clear();
            //Habilitamos el boton igual. 
            btnIgual.Enabled = true;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            //agregamos el punto 
            if (!txtDisplay.Text.Contains("."))//Con esto estamos diciendo que si no tiene el punto se lo "agregamos"
            {
                txtDisplay.Text += ".";//Si lo tiene, no le pondremos más puntos, o sea solo estará uno 
            }

        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            double signo;
            signo = double.Parse(txtDisplay.Text);
            signo = signo - (signo * 2);
            txtDisplay.Text = signo.ToString();

            //txtDisplay.Text =txtDisplay.Text; //23.54 +/- = -23.54
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //limpiamos
            txtDisplay.Text = "0";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            //Activamos el operador
            this.operador = "*";
            //Tomamos el op1 
            this._op1 = double.Parse(txtDisplay.Text);
            //Limpiamos el boton
            txtDisplay.Clear();
            //Habilitamos el boton igual. 
            btnIgual.Enabled = true;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            //Activamos el operador
            this.operador = "/";
            //Tomamos el op1
            this._op1 = double.Parse(txtDisplay.Text);
            //Limpiamos el boton 
            txtDisplay.Clear();//Con esto, lo que hace, es que cuando le damos al boton, se limpie para poner los siquientes operadores. 
            //Habilitamos el boton igual. 
            btnIgual.Enabled = true;
        }

        private void clic_Tangente_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                //hay algo alo qu le calcularemos la tan
                oper = new Tangente(double.Parse(txtDisplay.Text));
                //calculmos la tngente, y ponemos el res en el display
                double res = oper.ejecutar();
                //res = res * -1; //Aquí cambiamos el signo de la operación, ya que nos da negativo al momento de meterle la función tangente. 
                txtDisplay.Text = res.ToString();
            }
        }

        private void clic_Seno_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "") 
            {
                //Instanciamos el método
                oper = new Seno(double.Parse(txtDisplay.Text));
                double res = oper.ejecutar();//Realizamos el método para ejecutar
                txtDisplay.Text = res.ToString();
            }
        }

        private void click_Coseno_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "") 
            {
                //Instanciamos el método
                oper = new Coseno(double.Parse(txtDisplay.Text));
                double res = oper.ejecutar();
                txtDisplay.Text = res.ToString();
            }
        }

        private void click_elevarCuadrado_Click(object sender, EventArgs e)
        {
            oper = new CuadradoDelNum(double.Parse(txtDisplay.Text));//Esto también nos ayuda a obtener si queremos usarlo en el segundo numero
            double res = oper.ejecutar();
            txtDisplay.Text = res.ToString();
        }

        private void click_Raiz_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "") 
            {
                oper = new Raiz(double.Parse(txtDisplay.Text));
                double res = oper.ejecutar();
                txtDisplay.Text = res.ToString();
            }
        }

        private void click_Borrar_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1) //Aquí estamos indicando, que si el texto es mayor que uno (tiene un numero), eliminé ese numero
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);//Aquí, haremos que se mida la longitud de los numeros, y que eliminmemos de uno en uno, 
            }
            else
            {
                txtDisplay.Text = "0";//Este indica, que si tiene solo un numero, al eliminarlo, que nos de un 0
            }
        }

        private void clic_PI_Click(object sender, EventArgs e)
        {   //Programamos que nos de el valor de PI y que con él hagamos las operaciones si así lo deseamos. 
            if (txtDisplay.Text != "") 
            {
                oper = new PI(double.Parse(txtDisplay.Text));
                double res = oper.ejecutar();
                txtDisplay.Text = res.ToString();

            }
        }
    }
}
