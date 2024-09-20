using System;
    public class Program
    {
        public static void Main(string[] args)
        {

        //Declaración de variables y entrada de primeros datos
        int cantidadEstudiantes;
        int ubicacion=0;

        Console.Write("Digite la cantidad de estudiantes: ");
        cantidadEstudiantes = int.Parse(Console.ReadLine());

        //Declaración de matrices y arreglos
        string[] nombres = new string[cantidadEstudiantes];
        double[,] notas = new double[cantidadEstudiantes, 3];
        double[] promedio = new double[cantidadEstudiantes];
        double mayorNota = promedio[0];

        //Bifurcación principal
        if (cantidadEstudiantes < 3)
        {
            Console.WriteLine("Cantidad insuficiente de estudiantes, debe ser mayor a 3.");
            Console.WriteLine("Pulse cualquier tecla para salir del programa.");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("LECTURA DE NOMBRES DE ESTUDIANTES");

            //Bucle para entrada de datos, haciendo uso de un arreglo
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.Write("Digite el nombre del estudiante #" + (i+1) + ": ");
                nombres[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("LECTURA DE NOTAS DE ESTUDIANTES");

            //Bucle para entrada de datos, haciendo uso de una matriz
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Digite la nota #" + (j + 1) + " del estudiante " + nombres[i] + ": ");
                    notas[i, j] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            //Cálculo de promedios
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                promedio[i] = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;
            }

            Console.WriteLine("TABLA DE NOTAS");

            //Salida de datos en forma de tabla
            Console.WriteLine("Estudiantes\tExamen #1\tExamen #2\tExamen #3\tPromedio\tEstado");
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.Write(nombres[i] + "\t\t");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(notas[i, j] + "\t\t");
                }
                Console.Write(promedio[i]);
                if (promedio[i] >= 70)
                {
                    Console.Write("\t\t" + "Aprobado");
                }
                else
                {
                    Console.Write("\t\t" + "No Aprobado");
                }
                Console.WriteLine();
            }

            //Identificación de mayor nota final
            Console.WriteLine();
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                if (promedio[i] > mayorNota)
                {
                    mayorNota = promedio[i];
                    ubicacion = i;
                }
            }

            //Impresión de mayor nota final
            Console.WriteLine("El estudiante con mayor nota final es " + nombres[ubicacion] + ", con " + mayorNota + ". ");

            Console.WriteLine();
            Console.WriteLine("Pulse cualquier tecla para salir del programa.");
            Console.ReadKey();
        }
    }
}