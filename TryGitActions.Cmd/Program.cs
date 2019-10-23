using System;
using System.Reflection;

namespace TryGitActions.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current Version Number: '{typeof(Program).Assembly.GetName().Version}'");
        }
    }
}
