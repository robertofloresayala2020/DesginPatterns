

using ChatMediator.Concrete;
using ChatMediator.Interface;
using ChatMediator.Model;

IChatMediator  mediator = new ChatMediator.ChatMediator();

User user1 = new ConcreteUser(mediator, "Alex");
User user2 = new ConcreteUser(mediator, "Brian");
User user3 = new ConcreteUser(mediator, "Charles");

mediator.AddUser(user1);
mediator.AddUser(user2);
mediator.AddUser(user3);


user1.Send("Hello Everyone");   
user2.Send("Hi Alex");  
user3.Send("Hi Brian");
