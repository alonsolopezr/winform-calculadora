using System;
namespace Dominio_LibCalc
{
	public class Tangente : Operacion
	{
		public Tangente(double op1) : base( op1, new Double() )
		{
			//inicializamos los operandos
			this.Ope1 = op1;
		}


		//override del met abstracto ejecutra
		public override double ejecutar()
		{
			return Math.Tan(this.Ope1);
		}
	}
}

