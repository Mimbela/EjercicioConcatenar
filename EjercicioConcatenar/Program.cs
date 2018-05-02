using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConcatenar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime tu nombre");
            string n = Console.ReadLine();

            Console.WriteLine("Dime tu apellido");
            string a = Console.ReadLine();

            Concatena resultado = new Concatena(n , a);
            Console.WriteLine(resultado.Concatenar());

            Console.Read();
        }
    }
}
//Crear, asi mismo, una clase program.cs cuyo Main pedirá el nombre y el
//        apellido del usuario e imprimirá por pantalla el nombre concatenado.