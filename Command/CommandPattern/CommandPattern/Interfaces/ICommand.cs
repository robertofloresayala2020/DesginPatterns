using System.Diagnostics;

namespace CommandPattern.Interfaces
{

    //La interfaz ICommand declara el método Execute que todas las clases de comandos concretos deben implementar.
    public interface ICommand
    {
      void  Execute();


    }
}
