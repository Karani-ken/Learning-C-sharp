using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    internal class Registration
    {
        public void WelcomeNotification(List<INotification> notifications)
        {
            foreach(var notification in notifications)
            {
                notification.send(new Message());
            }
        }
    }
}
