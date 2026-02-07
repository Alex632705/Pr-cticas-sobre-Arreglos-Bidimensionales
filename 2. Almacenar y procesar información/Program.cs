namespace Almacenar_y_procesar_información
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int filas, columnas;
            int valorMaximo, valorMinimo;
            int filaMaximo = 0, columnaMaximo = 0;
            int filaMinimo = 0, columnaMinimo = 0;

            // Solicitar dimensiones de la matriz

            Console.Write("Ingrese el número de filas de la matriz: ");
            filas = int.Parse(Console.ReadLine()!);

            Console.Write("Ingrese el número de columnas de la matriz: ");
            columnas = int.Parse(Console.ReadLine()!);

            // Crear la matriz con las dimensiones indicadas
            int[,] matriz = new int[filas, columnas];

            Console.WriteLine();
            Console.WriteLine(" Ingreso de Valores ");

            // Ingresar valores manualmente por teclado
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese el valor para la posición [{i},{j}]: ");
                    try
                    {
                        matriz[i, j] = int.Parse(Console.ReadLine()!);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error: Debe ingresar un número entero válido.");
                        Console.Write($"Ingrese nuevamente el valor para la posición [{i},{j}]: ");
                        matriz[i, j] = int.Parse(Console.ReadLine()!);
                    }
                }
            }

            // Mostrar la matriz completa en forma tabular
            Console.WriteLine();
            Console.WriteLine(" Matriz Completa ");
            Console.WriteLine();

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j],6}");
                }
                Console.WriteLine();
            }

            // Inicializar valores máximo y mínimo con el primer elemento
            valorMaximo = matriz[0, 0];
            valorMinimo = matriz[0, 0];

            // Recorrer la matriz para encontrar valor máximo y mínimo
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    // Determinar valor máximo y su posición
                    if (matriz[i, j] > valorMaximo)
                    {
                        valorMaximo = matriz[i, j];
                        filaMaximo = i;
                        columnaMaximo = j;
                    }

                    // Determinar valor mínimo y su posición
                    if (matriz[i, j] < valorMinimo)
                    {
                        valorMinimo = matriz[i, j];
                        filaMinimo = i;
                        columnaMinimo = j;
                    }
                }
            }

            // Imprimir resultados
            Console.WriteLine();
            Console.WriteLine("Resultados");
            Console.WriteLine();
            Console.WriteLine($"Valor MÁXIMO: {valorMaximo}");
            Console.WriteLine($"Posición: Fila {filaMaximo}, Columna {columnaMaximo}");
            Console.WriteLine($"Índice en la matriz: [{filaMaximo},{columnaMaximo}]");
            Console.WriteLine();
            Console.WriteLine($"Valor MÍNIMO: {valorMinimo}");
            Console.WriteLine($"Posición: Fila {filaMinimo}, Columna {columnaMinimo}");
            Console.WriteLine($"Índice en la matriz: [{filaMinimo},{columnaMinimo}]");
            Console.WriteLine();
          

            Console.ReadKey();
        }
    }
}
