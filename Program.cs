Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Quem vai ganhar a champions league? ");

Console.ResetColor();

string time = "ta maluco, aqui é real madrid!!!";
string fraseDigitada;

Console.Write("digite quem voce acha que vai ganhar a final: ");
fraseDigitada = Console.ReadLine()!;

fraseDigitada = time
.Replace("borussia", time);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(time);
Console.ResetColor();

string segundotime = "mais uma pra conta, hala madrid!!!";
string segundaFrase;

Console.Write("digite quem voce acha que vai ganhar a final: ");
segundaFrase = Console.ReadLine()!;

segundaFrase = segundotime
.Replace("real madrid", segundotime);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(segundotime);
Console.ResetColor();
