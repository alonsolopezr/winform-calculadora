using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_LibCalc
{
    public class Seno : Operacion
    {
        public Seno(double op1) : base(op1, new Double()) 
        {
            this.Ope1 = op1;
            this.esTrigonometricaSeno = true;
        }
        public override double ejecutar()
        {
            return Math.Sin(this.Ope1 * (Math.PI / 180));
        }
    }
}
