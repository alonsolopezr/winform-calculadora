using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_LibCalc
{
    public abstract class Operacion
    {
        public string nombre = "Clase BASE";
        public double Ope1 { get; set; }
        public double Ope2 { get; set; }
        //Nueva propiedad para determinar si la operacion es TRIGONOMETRICA
        protected bool esTrigonometrica = false;
        protected bool esTrigonometricaSeno = false;//Función Trigonométrica Seno
        protected bool esTrigonometricaCoseno = false; //Fución Coseno.  
        protected double cuadrado;
        protected double raiz;
        protected double pi; 
        //Hacemos publica las funciones. 
        public bool EsTrigonometrica
        {
            get { return this.esTrigonometrica; }//Devolvemos el valor. 
        }
        //Definimos el método publico para función seno. 
        public bool EsTrigonometricaSeno
        {
            get { return this.esTrigonometricaSeno; }//Devolvemos el valor para el valor de seno. 
        }
        //Definimos el método publico para función Coseno. 
        public bool EstrigonometricaCoseno
        {
            get { return this.EstrigonometricaCoseno; }
        }
        public double Cuadrado //Para obtener la raiz de un numero y devolver.
        {
            get { return this.cuadrado; }
            set { this.cuadrado = value;}
        }
        public double Raiz //Vamos a realizar publico la propiedad raiz. 
        {
            get { return this.raiz; }
            set { this.raiz = value; }
        }
        public double PI 
        {
            get { return this.pi; }
        }
        public Operacion(double op1, double op2)
        {
            this.Ope1 = op1;
            this.Ope2 = op2;
        }
             public abstract double ejecutar();

    }
}
