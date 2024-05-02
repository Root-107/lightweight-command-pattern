using UnityEngine;

namespace Framework
{
    public static class CommandRunner
    {
        public static void Run(ICommand command)
        {
            command.Execute();
        }
        
        public static void Run<T>() where T : ICommand, new()
        {
            Run(new T());
        }
    }
}
