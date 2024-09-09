using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
    internal class NumComplexo
    {
        public double Real { get; private set; }
        public double Imaginario { get; private set; }


        public NumComplexo(double real, double imaginario)
        {
            Real = real;
            Imaginario = imaginario;
        }


        public NumComplexo Soma(NumComplexo outro)
        {
            return new NumComplexo(this.Real + outro.Real, this.Imaginario + outro.Imaginario);
        }


        public NumComplexo Vezes(NumComplexo outro)
        {
            double realParte = (this.Real * outro.Real) - (this.Imaginario * outro.Imaginario);
            double imaginarioParte = (this.Real * outro.Imaginario) + (this.Imaginario * outro.Real);
            return new NumComplexo(realParte, imaginarioParte);
        }


        public double Modulo()
        {
            return Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginario, 2));
        }


        public double Argumento()
        {
            return Math.Atan2(Imaginario, Real);
        }


        public void ImprimeFormaPolar()
        {
            double modulo = Modulo();
            double argumento = Argumento();
            Console.WriteLine($"{modulo} (cos({argumento}) + i*sin({argumento}))");
        }
    }
}