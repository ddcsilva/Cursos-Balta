static void Menu()
{
    Console.Clear();
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Abrir um Arquivo");
    Console.WriteLine("2 - Criar um Arquivo");
    Console.WriteLine("0 - Sair");

    short opcao = short.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0: Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Criar(); break;
        default: Menu(); break;
    }

    static void Abrir()
    {

    }

    static void Criar()
    {

    }
}