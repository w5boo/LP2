using System;
using System.Collections.Generic;
using System.Text;

namespace Pclasses
{
    class Mensalista : Empregado
    {
        public double SalarioMensal { get; set; }

        public override double SalarioBruto()
        {
            return SalarioMensal;
        }
    }
}
