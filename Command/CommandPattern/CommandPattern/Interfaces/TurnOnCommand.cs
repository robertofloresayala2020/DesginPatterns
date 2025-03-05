using CommandPattern.Models;

namespace CommandPattern.Interfaces
{

    //Las clases TurnOnCommand y TurnOffCommand implementan la interfaz ICommand y definen la relación entre el receptor (Light) y una acción (On y Off).
    public class TurnOnCommand :ICommand
    {

        private readonly Light _light;
        public TurnOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOn();
        }
    }
}
