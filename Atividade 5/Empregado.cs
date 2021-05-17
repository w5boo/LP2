using System;
using System.Collections.Generic;
using System.Text;

namespace Pclasses
{
    abstract class Empregado
    {
        private int matricula; // atributo
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;

        public int Matricula // propriedade
        {
        get { return matricula; }
        set { matricula = value; }
        }

        public string NomeEmpregado
        {
         get { return nomeEmpregado; }
         set { nomeEmpregado = value; }
        }
        public DateTime DataEntradaEmpresa
        {
        get { return dataEntradaEmpresa; }
        set { dataEntradaEmpresa = value; }
        }

        // virtual significa que pode ser sobreescrito
        public virtual int TempoTrabalho()
        {
         TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
         return (span.Days);
        }

        // deve ser implementado
        public abstract double SalarioBruto();
    }
}
