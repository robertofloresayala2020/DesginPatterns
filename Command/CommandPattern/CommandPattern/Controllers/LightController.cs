using Microsoft.AspNetCore.Mvc;
using CommandPattern.Models;
using CommandPattern.Interfaces;

namespace CommandPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LightController : ControllerBase
    {
		private readonly TaskQueue _taskQueue;
		private readonly Light _light;


		public LightController(TaskQueue taskQueue)
		{
			_taskQueue = taskQueue;
			_light = new Light();
		}
		[HttpPost("turnon")]
		public IActionResult TurnOn()
		{

			 var turnOnCommand = new TurnOnCommand(_light);
			_taskQueue.EnqueueTask(turnOnCommand);
			return Ok("Turn on Command Request");
		}


		[HttpPost("turnoff")]
		public IActionResult TurnOff()
		{
			_taskQueue.EnqueueTask(new TurnOffCommand(_light));
			return Ok("Turn off Command Request");
		}
		

	}
}
