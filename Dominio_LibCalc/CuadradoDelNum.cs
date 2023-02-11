using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_LibCalc
{
    public class CuadradoDelNum : Operacion 
    {
        public CuadradoDelNum(double op1) : base(op1, new Double())
        {
            this.Ope1= op1;

        }
        public override double ejecutar()
        {
            return Math.Pow(Ope1, 2);
        }
    }
}
