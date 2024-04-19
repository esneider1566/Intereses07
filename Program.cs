//Nombre del estudiante: Heiler Esneider Martinez Aguilar
//Grupo: 213022_195
//Programa: Ingenieria de sistemas
//Código Fuente: autoría propia
//17/04/2024


using System;

    Console.WriteLine("Bienvenido a su banco de confianza. ");
    Console.WriteLine();

    Console.WriteLine("Nuestro banco esta ofreciendo interes del 0.7% mes vencido a la cantidad de meses que usted desee. ");
    Console.WriteLine();

    Console.WriteLine("Si desea conocer cuanto dinero puede obtener al depositar dinero en nuestro banco ");

    Console.Write("Por favor, introduzca el capital inicial: ");

        double capital = Convert.ToDouble(Console.ReadLine());

        Console.Write("Por favor, introduzca el número de meses: ");
        int meses = Convert.ToInt32(Console.ReadLine());

        double tasaInteres = 0.007; // 0.7% de interés

        Console.WriteLine("\nMes\tCapital");
        for (int i = 1; i <= meses; i++)
        {
            capital += capital * tasaInteres;
            Console.WriteLine($"{i}\t{capital:F2}");
        }


Console.WriteLine(" ");
Console.WriteLine("Programa finalizado exitosamente ");
Console.WriteLine(" ");
Console.WriteLine("Presione la tecla Enter para continuar ");

while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }





