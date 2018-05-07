using DokanNet;
using NetCoreMirror;
using System;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Mirror mirror = new Mirror("D:");
                mirror.Mount("n:\\", DokanOptions.DebugMode, 5);
            }
            catch (DokanException ex)
            {
                Console.WriteLine(@"Error: " + ex.Message);
            }
        }
    }
}
