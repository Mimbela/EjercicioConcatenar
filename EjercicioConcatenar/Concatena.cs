using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConcatenar
{
    public class Concatena
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        //constructor
        public Concatena(string nomb, string apel)
        {
            Nombre = nomb;
            Apellido = apel;
        }
        //método devuelve un return 
        public string Concatenar()
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendFormat("{0} {1}",Nombre, Apellido).ToString();
            
        }

    }
}


//(3.6). Crear un programa que contenga la clase ‘Concatena.cs’ con dos atributos 
//“nombre” y “apellido”. Tendrá un constructor que recibirá esos dos parámetros y un 
//    método “concatenar” que devolverá(return) el nombre correctamente concatenado al 
//    apellido”. Crear, asi mismo, una clase program.cs cuyo Main pedirá el nombre y el 
//        apellido del usuario e imprimirá por pantalla el nombre concatenado.
