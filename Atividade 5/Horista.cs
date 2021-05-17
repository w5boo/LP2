using System;
using System.Collections.Generic;
using System.Text;

namespace Pclasses
{
    class Horista : Empregado
        //não podemos fazer herança multipla. Somente de uma classe.
    {
        public int SalarioHora { get; set; }

        public int NumeroHora { get; set; }

        public int DiasFalta { get; set; }

        public override double SalarioBruto()
        {
            return (SalarioHora * NumeroHora);
        }

        public override int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (Convert.ToInt32(span.Days) - DiasFalta);
        }
    }
}
