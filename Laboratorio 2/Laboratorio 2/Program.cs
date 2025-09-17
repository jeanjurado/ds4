using System;

namespace Laboratorio22
{


    public class Program
    {

        public static void Main()
        {
            //asignando valor a variable estatica
            MyClass.Valor = 1;
            Console.WriteLine(MyClass.Valor);
        }
    }
    public class Myclass
    {

        //Declarando varibales estatica 
        public static int Valor;
    }



}
                
            