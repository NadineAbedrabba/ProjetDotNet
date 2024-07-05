namespace MagicVillas.Logging
{
    public class Logging : ILogging
    {
        public void Log(string message, string type)
        {
            if (type == "error")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Error.WriteLine("il y a une erreur!!!!! _" + message);
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
