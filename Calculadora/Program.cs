using System;

namespace Calculadora {
    class Program {
        static void Main() {
            //iniciar variables
            int option;
            double a, b;
            double resultado;

            Console.WriteLine("Introduce el numero de la operacion a realizar:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Salir");


            option = Convert.ToInt16(Console.ReadLine());
            if (option > 0 && option < 5)
            {
                Console.WriteLine("Introduce el primer valor");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Introduce el segundo valor");
                b = Convert.ToDouble(Console.ReadLine());

                Console.Clear();

                switch (option)
                {
                    case 1:
                        resultado = a + b;
                        Console.WriteLine("El resultado es:" + resultado);
                        Main();
                        break;

                    case 2:
                        resultado = a - b;
                        Console.WriteLine("El resultado es:" + resultado);
                        Main();
                        break;

                    case 3:
                        resultado = a * b;
                        Console.WriteLine("El resultado es:" + resultado);
                        Main();
                        break;

                    case 4:
                        resultado = a / b;
                        Console.WriteLine("El resultado es:" + resultado);
                        Main();
                        break;

                    default:
                        Console.WriteLine("Hubo algun error");
                        break;

                }
            }
        }
    }
}