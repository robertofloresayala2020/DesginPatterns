using CommandPattern.Interfaces;
using System.Collections.Concurrent;

namespace CommandPattern.Models
{

    //La clase TaskQueue maneja la cola de tareas utilizando BlockingCollection<ICommand>.
    //Esta clase permite encolar comandos y procesarlos en orden.
    public class TaskQueue
    {

        private readonly BlockingCollection<ICommand> _commands = new BlockingCollection<ICommand>();

        public  void EnqueueTask(ICommand command)
        {
            _commands.Add(command);
        }

        public void ProcessTasks()
        {
            foreach (var command in _commands.GetConsumingEnumerable())
            {
                command.Execute();
            }
        }

        public  void StopProcessing()
        {
            _commands.CompleteAdding();
        }

    }
}
