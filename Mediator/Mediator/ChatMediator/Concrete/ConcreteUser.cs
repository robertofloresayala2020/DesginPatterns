using ChatMediator.Interface;
using ChatMediator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMediator.Concrete
{
    public class ConcreteUser:User
    {
        public ConcreteUser(IChatMediator mediator, string name) : base(mediator, name)
        {
        }

        public override void Send(string message)
        {
          Console.WriteLine(this._name + ": Sending Message=" + message);
            _mediator.SendMessage(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine(this._name + ": Received Message:" + message);
        }




    }
}
