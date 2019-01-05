using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Notas
    {
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;

        public Notas()
        {
        }

        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }
        public double Nota4 { get => nota4; set => nota4 = value; }
        public double Promedio()
        {
            double promedio;
            promedio = (this.nota1 + this.nota2 + this.nota3 + this.nota4) / 4;
            return promedio;
        }

    }
}
