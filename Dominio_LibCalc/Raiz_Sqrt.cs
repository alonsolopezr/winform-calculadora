using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_LibCalc
{
    public class Raiz_Sqrt : Operacion
    {
        public Raiz_Sqrt(double op1) : base(op1, new Double())
        {
            this.Ope1 = op1;
        }

        public override double ejecutar()
        {
            return Math.Sqrt(this.Ope1);
        }
    }
        
}
