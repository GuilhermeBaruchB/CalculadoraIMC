using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o seu peso:");
            double Peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua altura em metros:");
            double Altura = double.Parse(Console.ReadLine());

            double IMC = Peso / (Altura * Altura);





            if (IMC <= 16.9)
            {
                Console.WriteLine("O seu IMC é de: " + IMC, " Você está muito abaixo do peso");
            }
            else if (IMC <= 18.4)
            {
                Console.WriteLine("O seu IMC é de: " + IMC, " Você está abaixo do peso");
            } 
            else if (IMC <= 24.9)
            {
                Console.WriteLine("O seu IMC é de: " + IMC, " Você está com um peso ideal");
            }
            else if (IMC <= 29.9)
            {
                Console.WriteLine("O seu IMC é de: " + IMC, " Você está acima do peso");
            }
            else if (IMC <= 34.9)
            {
                Console.WriteLine("O seu IMC é de: " + IMC, " Você está com obesidadde grau I");
            }
            else if (IMC <= 40)
            {
                Console.WriteLine("O seu IMC é de: " + IMC, " Você está com obesidade grau II");
            }
            else if (IMC > 40)
            {
                Console.WriteLine("O seu IMC é de: " + IMC, " Você está com obesidade grau III");
            }

            Console.ReadKey();
        }
    }
}
