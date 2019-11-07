using System;
using System.Reflection;


namespace TryGitActions.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriter.ConsoleWriter.Info($"Current Version Number: '{typeof(Program).Assembly.GetName().Version}'");
        }
    }
}
