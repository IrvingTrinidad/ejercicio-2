using System;

class Program
{
    static double GradosARadianes(double grados)
    {
        return grados * (Math.PI / 180);
    }

    static double RadianesAGrados(double radianes)
    {
        return radianes * (180 / Math.PI);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("¿Qué desea convertir? Escriba 'grados' o 'radianes': ");
        string opcion = Console.ReadLine().ToLower();

        if (opcion == "grados")
        {
            Console.WriteLine("Ingresar los grados a convertir: ");
            double grados = Convert.ToDouble(Console.ReadLine());
            double radianes = GradosARadianes(grados);
            Console.WriteLine("{0} grados son aproximadamente {1} radianes.", grados, radianes);
        }
        else if (opcion == "radianes")
        {
            Console.WriteLine("Ingresar los radianes a convertir: ");
            double radianes = Convert.ToDouble(Console.ReadLine());
            double grados = RadianesAGrados(radianes);
            Console.WriteLine("{0} radianes son aproximadamente {1} grados.", radianes, grados);
        }
        else
        {
            Console.WriteLine("Opción no válida. Por favor, escriba 'grados' o 'radianes'.");
        }
    }
}
