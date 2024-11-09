internal class Program
{
    private static void Main(string[] args)
    {
        // 1) Diseñar un programa que solicite al usuario dos números y, si el primer número es más grande,
        // calcule y muestre su suma y resta. De lo contrario, calculará y mostrará su producto y cociente.
        Carculador();
    }

    private static void Carculador()
    {
        decimal num1;
        decimal num2;
        Console.WriteLine("ingrese dos numeros");
        num1 = decimal.Parse(Console.ReadLine());
        num2 = decimal.Parse(Console.ReadLine());

        if (num1>num2)
        {
            Console.WriteLine($"como el numero 1 es mayor, sumaremos y restaremos \n" +
                $"suma: {num1} + {num2} = {(num1+num2)}\n" +
                $"resta: {num1} - {num2} = {(num1 - num2)}\n");
        }
        else
        {
            Console.WriteLine($"como el numero 1 es menor, mostraremos su producto y cociente\n" +
                $"producto: {num1} * {num2} = {(num1 * num2)}\n" +
                $"cociente: {num1} / {num2} = {(num1 / num2)}\n");
        }
    }
}