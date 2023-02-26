using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_LibCalc
{
    public class elevarAlCuadrado : Operacion
    {
        public elevarAlCuadrado(double op1) : base(op1)
        {
        }

        public override double ejecutar()
        {
            return Ope1 * Ope1;
        }
    }

        
    
}
