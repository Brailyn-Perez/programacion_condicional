internal class Program
{
    private static void Main(string[] args)
    {
        //2) Leer tres calificaciones y calcular el promedio.
        //Si el promedio es igual o superior a siete, imprimir un mensaje indicando que el alumno ha aprobado.
        Calificaciones();
    }

    private static void Calificaciones()
    {
        decimal nota1 = 0;
        decimal nota2 = 0;
        decimal nota3 = 0;
        decimal cantidadDeNotas = 3;
        decimal promedio = 0;

        Console.WriteLine("Ingrese 3 notas para calcular su promedio");
        nota1 = decimal.Parse(Console.ReadLine());
        nota2 = decimal.Parse(Console.ReadLine());
        nota3 = decimal.Parse(Console.ReadLine());
        //calculamos el promedio
        promedio = (nota1 + nota2 + nota3) / cantidadDeNotas;


        if (promedio>=7)
        {
            Console.WriteLine($"Promovido-Aprobado su promedio fue de: {promedio}");
        }else
        {
            Console.WriteLine($"Reprobado, su promedio fue de: {promedio}");
        }

    }
}