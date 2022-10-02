using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioIMC
{
    internal class Pessoa
    {
        //Atributos
        public string nome;
        public double peso, altura, imc;

        //Métodos
        //Cálculo do IMC
        public double calculoIMC(double peso, double altura)
        {
            imc = (peso / (peso * altura));
            return imc;
        }

        //Avaliar a situação do IMC 
        public void avaliar()
        {
            if(calculoIMC(peso, altura) < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso.");
            }
            if (calculoIMC(peso, altura) > 18.5 && calculoIMC(peso, altura) < 25)
            {
                Console.WriteLine("Você está no peso ideal.");
            }
            if (calculoIMC(peso, altura) > 25 && calculoIMC(peso, altura) < 30)
            {
                Console.WriteLine("Você está acima do peso.");
            }
            if (calculoIMC(peso, altura) > 30 && calculoIMC(peso, altura) < 35)
            {
                Console.WriteLine("Você está com obesidade tipo I.");
            }
            if (calculoIMC(peso, altura) > 35 && calculoIMC(peso, altura) < 40)
            {
                Console.WriteLine("Você está com obesidade tipo II.");
            }
            if (calculoIMC(peso, altura) >= 40)
            {
                Console.WriteLine("Você está com obesidade tipo III.");
            }
        }

        public void avaliar(string nome)
        {
            if (calculoIMC(peso, altura) < 18.5)
            {
                Console.WriteLine(nome + ",você está abaixo do peso.");
            }
            if (calculoIMC(peso, altura) > 18.5 && calculoIMC(peso, altura) < 25)
            {
                Console.WriteLine(nome + ",você está no peso ideal.");
            }
            if (calculoIMC(peso, altura) > 25 && calculoIMC(peso, altura) < 30)
            {
                Console.WriteLine(nome + ",você está acima do peso.");
            }
            if (calculoIMC(peso, altura) > 30 && calculoIMC(peso, altura) < 35)
            {
                Console.WriteLine(nome + ",você está com obesidade tipo I.");
            }
            if (calculoIMC(peso, altura) > 35 && calculoIMC(peso, altura) < 40)
            {
                Console.WriteLine(nome + ",você está com obesidade tipo II.");
            }
            if (calculoIMC(peso, altura) >= 40)
            {
                Console.WriteLine(nome + ",você está com obesidade tipo III.");
            }
        }
    }
}
