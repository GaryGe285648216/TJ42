using System;

namespace GPLexTutorial
{
     public enum Tokens
    {
        INTERGER,
        FLOAT,
        EOF
    };
    public struct MyValueType
    {
        public int num;
        public float flo;
    };
    public abstract class ScanBase
    {
        public MyValueType yylval;
        public abstract int yylex();
        protected virtual bool yywrap() { return true; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                using (var input = System.IO.File.OpenRead(args[0]))
                {
                    Scanner scanner = new Scanner(input);

                    Tokens token;
                    do
                    {
                        token = (Tokens)scanner.yylex();
                        switch (token)
                        {
                            case Tokens.INTERGER:
                                Console.WriteLine("INTERGER ({0})", scanner.yylval.num);
                                break;
                            case Tokens.FLOAT:
                                Console.WriteLine("FLOAT ({0})", scanner.yylval.flo);
                                break;
                            case Tokens.EOF:
                                Console.WriteLine("EOF");
                                break;
                            default:
                                Console.WriteLine("'{0}'", (char)token);
                                break;
                        }
                    }
                    while (token != Tokens.EOF);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

