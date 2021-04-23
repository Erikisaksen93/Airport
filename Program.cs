using System;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandPrompt = new CommandHandler();
            while (true)
            {
                commandPrompt.DisplayCommands();
                var command = Console.ReadLine();
                commandPrompt.HandleCommand(command);
            }
        }
    }
}
