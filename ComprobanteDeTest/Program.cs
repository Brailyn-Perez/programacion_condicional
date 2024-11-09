internal class Program
{
    private static void Main(string[] args)
    {
        /*
         3) Desarrollar un programa que calcule el nivel de un postulante a partir de los resultados de un test. 
            El programa recibirá como entrada el número total de preguntas y las respuestas correctas, 
            y devolverá un nivel según el porcentaje de aciertos.

            Nivel máximo: Porcentaje>=90%.

            Nivel medio: Porcentaje>=75% y <90%.

            Nivel regular: Porcentaje>=50% y <75%.

            Fuera de nivel: Porcentaje<50%.
         */
        CalcularNivelPostulante();

    }
    private static void CalcularNivelPostulante()
    {
        decimal numeroTotalDePreguntas = 0;
        decimal numeroDePreguntasCorrectas = 0;
        decimal porcentaje = 0;

        Console.WriteLine("ingrese el numero de preguntas realizadas");
        numeroTotalDePreguntas = int.Parse(Console.ReadLine());

        Console.WriteLine("ingrese el numero de preguntas realizadas");
        numeroDePreguntasCorrectas = int.Parse(Console.ReadLine());

        porcentaje = (numeroDePreguntasCorrectas / numeroTotalDePreguntas) *(100);

        if (porcentaje >=90)
        {
            Console.WriteLine($"Nivel Maximo,{porcentaje}%");
            return;
        }
        else if(porcentaje >=75 &&  porcentaje < 90)
        {
            Console.WriteLine($"Nivel Medio,{porcentaje}%");
            return;
        }
        else if (porcentaje >= 50 && porcentaje < 75)
        {
            Console.WriteLine($"Nivel Regular, {porcentaje}%");
            return;
        }
        else
        {
            Console.WriteLine($"Fuera de nivel, {porcentaje}%");
        }




    }

}