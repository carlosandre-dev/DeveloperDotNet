// See https://aka.ms/new-console-template for more information
Menu();

static void Menu()
{
  Console.Clear();
  Console.WriteLine("Bem vindo a Calculadora Digital");
  Console.WriteLine("===============================");
  Console.WriteLine("1 -> Somar");
  Console.WriteLine("2 -> Subtrair");
  Console.WriteLine("3 -> Multiplicar");
  Console.WriteLine("4 -> Dividir");
  Console.WriteLine("5 -> Sair");
  Console.WriteLine("--------------------------------");
  Console.WriteLine("Qual operação deseja realizar?");
  short result = short.Parse(Console.ReadLine());

  switch (result)
  {
    case 1: Sum(); break;
    case 2: Subtraction(); break;
    case 3: Multiplication(); break;
    case 4: Division(); break;
    case 5: Exit(); break;
    default: Menu(); break;
  }
}

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
  Menu();
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
  Menu();
}

static void Multiplication()
{
  Console.Clear();
  Console.WriteLine("Informe o primeiro valor:");
  float valueOne = float.Parse(Console.ReadLine());

  Console.WriteLine("Informe o segundo valor:");
  float valueTwo = float.Parse(Console.ReadLine());

  Console.WriteLine();

  float multiplication = valueOne * valueTwo;

  Console.WriteLine($"O resultado da multiplicação de {valueOne} x {valueTwo} é: {multiplication}");
  Console.ReadKey();
  Menu();
}

static void Division()
{
  Console.Clear();
  Console.WriteLine("Informe o primeiro valor:");
  float valueOne = float.Parse(Console.ReadLine());

  Console.WriteLine("Informe o segundo valor:");
  float valueTwo = float.Parse(Console.ReadLine());

  if (valueTwo == 0)
  {
    Console.WriteLine("Não é permitido divisão por zero");
    Division();
  }
  else
  {
    Console.WriteLine();

    float division = valueOne / valueTwo;

    Console.WriteLine($"O resultado da divisão de {valueOne} por {valueTwo} é: {division}");
    Console.ReadKey();
    Menu();
  }

}

static void Exit()
{
  Console.Clear();
  Console.WriteLine("--------------------------------");
  Console.WriteLine("Obrigado por usar a Calculadora Digital");
  System.Environment.Exit(0);
}