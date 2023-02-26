using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_LibCalc
{
    public class Coseno : Operacion
    {
        public Coseno(double op1) : base(op1, new Double()) 
        {
            this.Ope1 = op1;
            this.esTrigonometricaCoseno = true;
        }
        public override double ejecutar()
        {
            return Math.Cos(this.Ope1 * (Math.PI / 180));
        }
    }
}
