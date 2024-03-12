// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja");
Console.WriteLine("Modyfikacja 2");

static double GetAverage(int[] tablica)
{
 int suma = 0;
 foreach (var number in tablica)
 {
  suma += number;
 }
 return (double) suma / tablica.Length;
}

int[] tablica = {1, 2, 3, 4, 5};
var average = GetAverage(tablica);
Console.WriteLine(average);