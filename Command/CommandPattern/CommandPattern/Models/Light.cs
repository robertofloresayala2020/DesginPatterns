namespace CommandPattern.Models
{

    //La clase Light sabe cómo realizar las operaciones asociadas a encender y apagar la luz.
    public class Light
    {

        public void TurnOn()
        {
           Console.WriteLine("Light is on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Light is off");
        }
    }
}
