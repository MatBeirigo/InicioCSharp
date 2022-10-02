using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Classe - nome do objeto = new - nome do novo objeto()
            Pessoa p = new Pessoa();
            p.nome = "Beirigo";
            p.peso = 72;
            p.altura = 179;
            p.avaliar();
            p.avaliar(p.nome);
        }
    }
}
