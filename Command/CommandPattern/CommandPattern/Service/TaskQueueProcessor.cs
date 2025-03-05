using CommandPattern.Models;

namespace CommandPattern.Service
{

    
    public class TaskQueueProcessor:BackgroundService
    {
        private readonly TaskQueue _taskQueue;
        public TaskQueueProcessor(TaskQueue taskQueue)
        {
            _taskQueue = taskQueue;
        }
        protected override  Task ExecuteAsync(CancellationToken stoppingToken)
        {

            return Task.Run(() => _taskQueue.ProcessTasks(), stoppingToken);

           
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _taskQueue.StopProcessing();
            return base.StopAsync(cancellationToken);
        }
    }

}
