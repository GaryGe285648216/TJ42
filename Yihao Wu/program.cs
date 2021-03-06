using System.IO;
using System;

namespace GPLexTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scanner = new Scanner(
                new FileStream(args[0], FileMode.Open));
            Parser parser = new Parser(scanner);
            parser.Parse();
            Console.ReadKey();
        }
    }
}
