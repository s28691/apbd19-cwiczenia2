// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja");
Console.WriteLine("Modyfikacja 2");

static double GetAverage(int[] tablica)
{
 int suma = 0;
 foreach (var number987 in tablica)
 {
  suma += number987;
 }
 return (double) suma / tablica.Length;
}

int[] tablica = {1, 2, 3, 4, 5};
var average = GetAverage(tablica);
Console.WriteLine(average);

static int GetMax(int[] tablica)
{
 int max = 0;
 for (int a = 0; a < tablica.Length; a++)
 {
  if (tablica[a] > max)
  {
   max = tablica[a];
  }
 }
 return max;
}
var najwieksza = GetMax(tablica);
Console.WriteLine(najwieksza);