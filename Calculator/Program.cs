// See https://aka.ms/new-console-template for more information
Sum();

static void Sum()
{
  Console.Clear();
  Console.WriteLine("Informe o primeiro valor:");
  float valueOne = float.Parse(Console.ReadLine());

  Console.WriteLine("Informe o segundo valor:");
  float valueTwo = float.Parse(Console.ReadLine());

  Console.WriteLine();

  float sum = valueOne + valueTwo;

  Console.WriteLine($"O resultado da soma de {valueOne} + {valueTwo} é: {sum}");
  Console.ReadKey();
}

static void Subtraction()
{
  Console.Clear();
  Console.WriteLine("Informe o primeiro valor:");
  float valueOne = float.Parse(Console.ReadLine());

  Console.WriteLine("Informe o segundo valor:");
  float valueTwo = float.Parse(Console.ReadLine());

  Console.WriteLine();

  float subtraction = valueOne - valueTwo;

  Console.WriteLine($"O resultado da subtração de {valueOne} - {valueTwo} é: {subtraction}");
  Console.ReadKey();
}

