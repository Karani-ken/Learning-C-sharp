using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public class EmainNotification : INotification
    {
        public void send(Message message)
        {
            Console.WriteLine("Email sent to johndoe@gmail.com");
        }
    }
}
