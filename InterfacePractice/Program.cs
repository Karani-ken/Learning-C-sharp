
using InterfacePractice;

Registration registration = new Registration();
registration.WelcomeNotification(new List<INotification>()
{
    new EmainNotification(){},
    new SmSNotification(){}

});