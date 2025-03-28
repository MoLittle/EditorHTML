namespace EditorHTML;

public class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        
        DrawScreen();
        WriteOptions();
        
        var option = short.Parse(Console.ReadLine());
        HandleMenuOption(option);
    }

    public static void DrawScreen()
    {
        Console.Write("+");
        for (int i = 0; i <= 40; i++)
        {
            Console.Write("-");
        }
        Console.Write("+");
        Console.Write("\n");

        for (int line = 0; line <= 10; line++)
        {
            Console.Write("|");
            for (int i = 0; i <= 40; i++)
            {
                Console.Write(" ");
            }

            Console.Write("|");
            Console.Write("\n");
        }
        
        Console.Write("+");
        for (int i = 0; i <= 40; i++)
        {
            Console.Write("-");
        }
        Console.Write("+");
        Console.Write("\n");
    }

    public static void WriteOptions()
    {
        Console.SetCursorPosition(3,0);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(3,1);
        Console.WriteLine("===================");
        Console.SetCursorPosition(3,2);
        Console.WriteLine("Selecione uma opção abaixo");
        Console.SetCursorPosition(3,4);
        Console.WriteLine("1 - Novo arquivo");
        Console.SetCursorPosition(3,5);
        Console.WriteLine("2 - Abrir");
        Console.SetCursorPosition(3,6);
        Console.WriteLine("0 - Sair");
        Console.SetCursorPosition(3,7);
        Console.Write("Opção: ");
    }

    public static void HandleMenuOption(short option)
    {
        switch (option)
        {
            case 1: Editor.Show(); break;
            case 2: Console.WriteLine("View"); break;
            case 0:
            {
                Console.Clear();
                Environment.Exit(0);
                break;
            }
            default: Show(); break;
        }
    }
}
