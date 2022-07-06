using System;

namespace Calculadora {
    public class Calculadora {
        public class Operaciones {
            public double suma(double a, double b) {
                return a+b;
            }
            public double resta(double a, double b)
            {
                return a - b;
            }
            public double multiplicacion(double a, double b)
            {
                return a * b;
            }
            public double division(double a, double b)
            {
                return a / b;
            }
        }

        static void Main() {
            //iniciar variables
            int option;
            double a, b;
            var resultados = new Operaciones();

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
                        Console.WriteLine("El resultado es:" + resultados.suma(a,b));
                        Main();
                        break;

                    case 2:
                        Console.WriteLine("El resultado es:" + resultados.resta(a, b));
                        Main();
                        break;

                    case 3:
                        Console.WriteLine("El resultado es:" + resultados.multiplicacion(a,b));
                        Main();
                        break;

                    case 4:
                        Console.WriteLine("El resultado es:" + resultados.division(a,b));
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