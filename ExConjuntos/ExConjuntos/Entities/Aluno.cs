using System;
using System.Collections.Generic;
using System.Text;

namespace ExConjuntos.Entities
{
    class Aluno
    {
        public int CodigoAluno { get; set; }

        public Aluno(int codigoAluno)
        {
            CodigoAluno = codigoAluno;
        }

        public override int GetHashCode()
        {
            return CodigoAluno.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Aluno))
            {
                return false;
            }
            Aluno other = obj as Aluno;

            return CodigoAluno.Equals(other.CodigoAluno);
        }
    }
}
