using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Training:Company //Training extends the company (Training(Child) inherits the company(Parent))
    {
        public Training() : base("Life is too short to write bad code") //arguments are passed for the Parent Class
        {                                                                //constructor in the child constructor via base
        
            //some code
        }
        public void CodeReview()
        {
            Console.WriteLine("Reviewing code...");
        }
        public void AddEmployee()
        {
            numberOfEmployess2 += 1;
         
        }
        public void showEmployess()
        {
            Console.WriteLine();
        }
    }
}
