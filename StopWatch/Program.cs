﻿// See https://aka.ms/new-console-template for more information
Menu();

static void Menu()
{
  Console.Clear();
  Console.WriteLine("S = Segundo");
  Console.WriteLine("M = Minuto");
  Console.WriteLine("0 = Sair");
  Console.WriteLine("Quanto tempo deseja contar?");

  string data = Console.ReadLine().ToLower();
  char type = char.Parse(data.Substring(data.Length - 1, 1));
  int time = int.Parse(data.Substring(0, data.Length - 1));
  int multiplier = 1;

  if(type == 'm')
  {
	multiplier = 60;
  }

  if(time == 0)
  {
	System.Environment.Exit(0);
  }

  PreStart(time * multiplier);

}

static void PreStart(int time)
{
	Console.Clear();
	Console.WriteLine("Ready...");
	Thread.Sleep(1000);
	Console.WriteLine("Set...");
	Thread.Sleep(1000);
	Console.WriteLine("Go...");
	Thread.Sleep(2500);

	Start(time);
}

static void Start(int time)
{
  int currenTime = time;

  while (currenTime != 0)
  {
    Console.Clear();
    Console.WriteLine(currenTime);
    Thread.Sleep(1000);
	  currenTime--;
  }

  Console.Clear();
  Console.WriteLine("Stopwatch finishing");
  Thread.Sleep(2500);
  Menu();
}