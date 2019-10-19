using System;


namespace DustinBriones3A
{
    abstract class PRINCIPAL
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio numero 1: Programa que lea una serie de números por teclado e indique cuál es el mayor.");
            Console.WriteLine();
            numero_mayor();
            Console.WriteLine();
            Console.WriteLine("Ejercicio numero 2: Crear un programa que lea un número entero y a partir de él cree un cuadrado de asteriscos con ese tamaño.");
            Console.WriteLine();
            cuadrado_bordeado();
            Console.WriteLine();
            Console.WriteLine("Ejercicio numero 3: Crear un programa que lea cantidades y precios y al final indique el total de la factura. ");
            Console.WriteLine();
            facturacion();
            Console.WriteLine();
            Console.WriteLine("Ejercicio numero 4: Crear un programa para calcular el salario semanal de unos empleados. ");
            Console.WriteLine();
            salario_empleado();
            Console.WriteLine();
            Console.WriteLine("Ejercicio numero 5: Crear un programa  en el que se introduce un número entero y se crea una pirámide de asteriscos en base al número. ");
            Console.WriteLine();
            piramide();
            Console.WriteLine();
            Console.WriteLine("Aprete alguna tecla para continuar con el siguiente ejercicio.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Ejercicio numero 6: Modificar el ejercicio anterior para que aparezca un rombo. ");
            Console.WriteLine();
            rombo();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ejercicio numero 7: Crear un programa que escriba dos columnas de números, en la primera se colocan los números del 1 al 100, en la segunda los números del 100 al 1. ");
            Console.WriteLine();
            Console.WriteLine("Aprete alguna tecla para ver las columnas");
            Console.ReadKey();
            Console.WriteLine();
            columnas_de_numeros();
            Console.WriteLine();

        }



        private static void numero_mayor()
        {
            Int16 Numero0;
            Int16 Limite = 5;
            Int16 Mayor = 0;
            for (Int16 i = 0; i < Limite; i++)
            {
                Console.WriteLine("Ingrese un número:");
                Numero0 = Int16.Parse(Console.ReadLine());
                if (Numero0 > Mayor)
                {
                    Mayor = Numero0;
                }


            }
            Console.WriteLine("El mayor valor es " + Mayor + ".");
        }

        private static void cuadrado_bordeado()
        {


            {
                Console.WriteLine("Ingrese el número correspondiente al tamaño del cuadrado.");
                Int16 Tamaño = Int16.Parse(Console.ReadLine());
                for (Int16 i = 0; i < Tamaño; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                for (Int16 i = 0; i < Tamaño - 2; i++)
                {
                    Console.Write("*");

                    for (Int16 k = 0; k < Tamaño - 2; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }


                for (Int16 i = 0; i < Tamaño; i++)
                {
                    Console.Write("*");
                }

            }
        }
        private static void facturacion()
        {
            Int16 cantidad = 1;
            float precio = 0;
            float precio_final = 0;
            float precio_total = 0;
            while (cantidad > 0)
            {
                Console.WriteLine("Introduzca la cantidad vendida del producto.");
                cantidad = Int16.Parse(Console.ReadLine());
                if (cantidad > 0)
                {
                    Console.WriteLine("Introduzca el precio del producto.");
                    precio = float.Parse(Console.ReadLine());
                    precio_final = precio * cantidad;
                    precio_total = precio_total + precio_final;
                }
            }
            Console.WriteLine("El total de su factura es: " + precio_total + ".");
        }
        private static void salario_empleado()
        {

            Int16 activador = 1;
            Int16 horas = 0;
            Int32 extras = 0;
            Int32 salario_extra = 0;
            Int32 salario_sin_extra = 35 * 15;
            Int32 salario = 0;
            while (activador == 1)
            {
                Console.WriteLine("Introduzca las horas realizadas por el empleado.");
                horas = Int16.Parse(Console.ReadLine());
                if (horas <= 35 && horas > 0)
                {
                    salario = horas * 15;
                    Console.WriteLine("El salario del empleado es de: " + salario + ".");

                }
                else
                {
                    extras = horas - 35;
                    salario_extra = extras * 22;
                    salario = salario_sin_extra + salario_extra;
                    Console.WriteLine("El salario del empleado es de: " + salario + ".");
                }
                Console.WriteLine("Ubicar 1 si desea calcular el salario de otro empleado.");
                activador = Int16.Parse(Console.ReadLine());

            }
        }
        private static void piramide()
        {

            Int16 i = 0, j = 0, k = 0;
            Console.WriteLine("Introduzca número para la piramide");
            Int16 piramide = Int16.Parse(Console.ReadLine());
            for (i = 1; i <= piramide; i++)
            {
                for (j = 0; j < piramide - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 0; k < (i * 2) - 1; k++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();


            }

        }
        private static void rombo()
        {
            {
                Int32 i = 0, n0 = 0, n1 = 0, j = 0;
                string linea = "", pe, pa;
                for (i = 1; i <= 7; i = i + 1)
                {
                    if (i <= 4)
                    {
                        n0 = 4 - i;
                        n1 = 2 * i - 1;
                    }
                    else
                    {
                        n0 = i - 4;
                        n1 = 15 - 2 * i;
                    }
                    pe = "";
                    for (j = 1; j <= n0; j = j + 1)
                    { pe = pe + " "; }
                    pa = "";
                    for (j = 1; j <= n1; j = j + 1)
                    { pa = pa + "*"; }
                    linea = pe + pa;

                    Console.WriteLine(linea);
                }
            }
        }
        private static void columnas_de_numeros()
        {
            Int16 cont0 = 0;
            Int16 cont1 = 101;

            while (cont0 <= 100 && cont1 >= 1)
            {
                cont0++;
                cont1--;

                Console.WriteLine(cont0 + "     " + cont1);

            }
        }
    }

}

