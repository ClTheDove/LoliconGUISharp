using System;
using System.Diagnostics;

namespace LoliconGUISharp
{
    public static class Log
    {
        private const string TAG = nameof(Log);
        public const string INFO = "I";
        public const string DEBUG = "D";
        public const string WARNING = "W";
        public const string ERROR = "E";

        private static void WriteLine(string level, string tag, string content)
        {
            switch (level)
            {
                case INFO:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case DEBUG:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case WARNING:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case ERROR:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }

            Console.WriteLine($"{DateTime.Now} {level} {tag}: {content}");
        }

        public static void I(string tag, string content)
        {
            WriteLine("I", tag, content);
        }

        [Conditional("DEBUG")]
        public static void D(string tag, string content)
        {
            WriteLine("D", tag, content);
        }

        public static void W(string tag, string content)
        {
            WriteLine("W", tag, content);
        }

        public static void E(string tag, string content)
        {
            WriteLine("E", tag, content);
        }
    }
}