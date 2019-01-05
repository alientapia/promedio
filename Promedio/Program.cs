using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double nota3;
            double nota4;
            double promedio;
            Console.WriteLine("Entre la nota1:  ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre la nota2:  ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre la nota3:  ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre la nota4:  ");
            nota4 = Convert.ToDouble(Console.ReadLine());
            Notas nota = new Notas();
            nota.Nota1 = nota1;
            nota.Nota2 = nota2;
            nota.Nota3 = nota3;
            nota.Nota4 = nota4;
            promedio = Convert.ToDouble( nota.Promedio());
            Console.WriteLine("Su promedio es: " + promedio);
            Console.ReadKey();
        }
    }
}
