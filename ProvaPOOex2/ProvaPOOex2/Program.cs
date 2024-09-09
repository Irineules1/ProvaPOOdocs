using System;

namespace Questao2
{
    static class Questao2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a parte real de z1:");
            double real1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a parte imaginária de z1:");
            double imaginario1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Digite a parte real de z2:");
            double real2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a parte imaginária de z2:");
            double imaginario2 = Convert.ToDouble(Console.ReadLine());


            NumComplexo z1 = new NumComplexo(real1, imaginario1);
            NumComplexo z2 = new NumComplexo(real2, imaginario2);


            Console.WriteLine($"O módulo de z1 ({real1} + {imaginario1}i) é: {z1.Modulo()}");


            Console.WriteLine($"O módulo de z2 ({real2} + {imaginario2}i) é: {z2.Modulo()}");


            NumComplexo soma = z1.Soma(z2);
            Console.WriteLine("Forma polar da soma:");
            soma.ImprimeFormaPolar();


            NumComplexo produto = z1.Vezes(z2);
            Console.WriteLine("Forma polar do produto:");
            produto.ImprimeFormaPolar();


            Console.ReadKey();
        }
    }
}