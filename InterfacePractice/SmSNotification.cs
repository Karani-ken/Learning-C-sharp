using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public class SmSNotification : INotification,ILogger
    {
        public void log()
        {
            Console.WriteLine("Loogin something");
        }

        public void send(Message message)
        {
            Console.WriteLine("Sms was sent to John");
        }
    }
}
