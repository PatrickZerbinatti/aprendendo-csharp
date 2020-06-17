using System;
using System.Collections.Generic;
using System.Text;

namespace ExList
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario (double porcent)
        {
            porcent /= 100;
            Salario = (porcent * Salario) + Salario;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2");
        }
    }
}
