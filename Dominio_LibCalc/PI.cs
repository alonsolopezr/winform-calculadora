using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_LibCalc
{
    public class PI : Operacion
    {
        public PI(double op1) : base (op1, new double()) 
        {
            this.Ope1= op1;
        }
        public override double ejecutar()
        {
            return Math.PI;//Esto lo hacemos para que me de el número de PI. 
        }
    }
}
