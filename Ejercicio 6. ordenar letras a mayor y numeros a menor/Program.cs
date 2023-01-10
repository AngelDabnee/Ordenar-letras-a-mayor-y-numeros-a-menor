// See/* https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Mediante un ciclo, pedir 10 letras y 10 números, ordenar ascendentemente las letras,
//descendentemente los números. Imprimirlos.
Console.WriteLine("En este programa ordenaremos 10 letras de mayor a menor y los números de menor a mayor");
//De
char[] letras = new char[10];
double[] numeros = new double[10];
//Proceso
for (int i = 0; i < letras.Length; i++)
{
    Console.WriteLine("Captura 10 letras, letra No. " + (i + 1));
    letras[i] = Convert.ToChar(Console.ReadLine());
    Console.WriteLine(Convert.ToInt32(letras));
}
