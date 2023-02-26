using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_LibCalc
{
    public class Tangente : Operacion
    {
        public Tangente(double op1) : base(op1, new Double()) 
        {
            //Iniciamos los operandos
            this.Ope1 = op1;
            this.esTrigonometrica = true; 
        }
        public override double ejecutar()
        {
            return Math.Tan(this.Ope1*(Math.PI/180));
        }
    }
}
