using System.Text;

namespace EditorHTML;

public class Editor
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("Modo Editor (Aperete F1 para finalizar");
        Console.WriteLine("--------------------------------------");  
        Start();
    }

    public static void Start()
    {
        var file = new StringBuilder();

        do
        {
            file.Append(Console.ReadLine());
            file.Append(Environment.NewLine);
        } while(Console.ReadKey().Key != ConsoleKey.F1);
        
        Console.WriteLine("---------");
        Console.WriteLine("Deseja salvar o arquivo?");
        Console.ReadLine();
        Viewer.Show(file.ToString());
    }

}
