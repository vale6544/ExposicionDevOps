using System;

class Program
{
    static void Main()
    {
        // función principal
        Func<int, int, int> sumar = (a, b) => a + b;

        // prueba automática
        int resultado = sumar(2, 3);

        if (resultado != 5)
        {
            // si falla, excepción para detener automatización
            throw new Exception("La prueba falló porque esperábamos un 5, pero obtuvimos un " + resultado);
        }

        Console.WriteLine("Prueba exitosa. El código está validado.");
    }
}