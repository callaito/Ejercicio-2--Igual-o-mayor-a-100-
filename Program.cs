// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 2");
Console.WriteLine();



int numero, sumatoria =0;

numero = Convert.ToInt32(Console.ReadLine());
//Inicializar siempre antes del bucle




while (sumatoria <= 100)
{

   
    sumatoria += numero;

}


//Calcular el sumatoria

if (sumatoria <= 100 )
{
    Console.WriteLine("El numero es igual o mayor a 100: " + sumatoria );
}

else
{
    Console.WriteLine("El numero es menor");
}
