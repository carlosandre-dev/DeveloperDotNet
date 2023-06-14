// See https://aka.ms/new-console-template for more information
Menu();

static void Menu()
{
	Console.Clear();
	Console.WriteLine("Bem vindo ao Editor de Textos C#");
	Console.WriteLine("==============================");
	Console.WriteLine("Escolha a opção: ");
	Console.WriteLine("------------------------------");
	Console.WriteLine("1 -> Abrir arquivo");
	Console.WriteLine("2 -> Editar arquivo");
	Console.WriteLine("0 -> sair");
	short option = short.Parse(Console.ReadLine());

	switch (option)
	{
		case 0: Exit(); break;
		case 1: Open(); break;
		case 2: Edit(); break;
		default: break;
	}
}

static void Open()
{
	Console.Clear();
	Console.WriteLine("Qual caminho do arquivo?");
	string path = Console.ReadLine();

	using (var file = new StreamReader(path))
	{
		string text = file.ReadToEnd();
		Console.WriteLine(text);
	}

	Console.WriteLine("");
	Console.ReadLine();
	Menu();
}

static void Edit()
{
	Console.Clear();
	Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
	string text = "";

	do 
	{
		text += Console.ReadLine();
		text += Environment.NewLine;
	}
	while (Console.ReadKey().Key != ConsoleKey.Escape);

	Save(text);
}

static void Save(string text)
{
	Console.Clear();
	Console.WriteLine("Qual caminho para salvar o arquivo?");
	var path = Console.ReadLine();

	using (var file = new StreamWriter(path))
	{
		file.Write(text);
	}

	Console.WriteLine($"Arquivo {path} salvo com sucesso!");
	Console.ReadLine();
	Menu();
}

static void Exit()
{
	Console.Clear();
	Console.WriteLine("Deseja mesmo sair da aplicação?");
	char response = char.Parse(Console.ReadLine());

	if ((response == 'S') || (response == 's'))
	{
		Console.WriteLine("--------------------------------");
		Console.WriteLine("Obrigado por usar o Editor de Textos C#");
		System.Environment.Exit(0);
	}
	Menu();
}