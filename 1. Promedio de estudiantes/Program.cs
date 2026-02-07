namespace Promedio_de_estudiantes
{
    /*
     1.Promedio de estudiantes
    Una escuela registra las calificaciones de 4 estudiantes en 3 asignaturas.

    • Calcula el promedio de cada estudiante

    • Calcula el promedio de cada asignatura 
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int[,] Calificaciones = new int[4,3];
            string[] Estudiantes = new string[4];
            string[] Asignaturas= new string [3];
            double [] promedio = new double[3];
            double [] promedioEstudiante = new double[4];
            int [] sumaEstudiante = new int[4];
            int[] sumaAsignatura = new int[3];
            

            //Agregar asignatura
            for (int i = 0; i < Asignaturas.Length; i++) 
            {
                Console.WriteLine($"Ingrese el nombre de la asignatura {i + 1}");
                Asignaturas[i] = Console.ReadLine()!;
            }

            //Agregar Estudiantes y Calificaciones

            for (int i = 0; i < Estudiantes.Length; i++)
            {
                Console.WriteLine($"Ingrese el estudiante {i + 1}");
                Estudiantes[i] = Console.ReadLine()!;

                for (int j = 0; j < Asignaturas.Length; j++)
                {
                    Console.WriteLine($"Ingrese las calificaciones del estudiante {Estudiantes[i]} en la asignatura {Asignaturas[j]}");
                    try
                    {
                        Calificaciones[i, j] = int.Parse(Console.ReadLine()!);
                    }
                    catch (Exception e)
                    {
                        {
                            Console.WriteLine("Ingrese un número entero...");
                            Console.WriteLine($"Ingrese las calificaciones del estudiante {Estudiantes[i]} en la asignatura {Asignaturas[j]}");
                            Calificaciones[i, j] = int.Parse(Console.ReadLine()!);
                        }

                    }
                    //Suma de caliificaciones por estudiante
                    sumaEstudiante[i] += Calificaciones[i, j];

                }

            }

            //Suma de las notas por asignatura
            for (int i = 0; i < Asignaturas.Length; i++) 
            {
                for (int j = 0; j < Estudiantes.Length; j++) 
                {
                    if (i < 3)
                    {
                        sumaAsignatura[i] += Calificaciones[j, i];
                    }
                }

            }

            Console.WriteLine("Promedio de los estudiantes");
            //A.Calcula el promedio de cada estudiante
            for (int i = 0; i < sumaEstudiante.Length; i++)
            {
                promedioEstudiante[i] = sumaEstudiante [i] / 3;
                Console.WriteLine($"Promedio del estudiante {Estudiantes[i]}: {promedioEstudiante[i]}");

            }
            Console.WriteLine("");
            Console.WriteLine("Promedio de las asignaturas");
            //B.Calcula el promedio de cada asignatura 
            for (int i = 0; i < sumaAsignatura.Length; i++) 
            {
                promedio[i] = sumaAsignatura [i] / 4;
                Console.WriteLine($"Promedio de los estudiantes en la asignatura {Asignaturas[i]}: {promedio[i]}");
            }
         
        }
    }
}
