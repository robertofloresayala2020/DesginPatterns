using CommandPattern.Models;

namespace CommandPattern.Interfaces
{
    public class TurnOffCommand : ICommand
    {
        //Las clases TurnOnCommand y TurnOffCommand implementan la interfaz ICommand y definen la relación entre el receptor (Light) y una acción (On y Off).
        private readonly Light _light;
        public TurnOffCommand(Light light)
        {

            _light = light; 

        }
        public void Execute()
        {
            _light.TurnOff();
        }
    }
}
