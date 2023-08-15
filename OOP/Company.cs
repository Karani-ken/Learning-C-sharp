using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //inheritance example
    public class Company
    {
        //to enforce a structure/design pattern -abstraction
        //pub/*lic abstract void working();*/
        //has 3 departments
        //same communication channels for the 3 departments
        public string Quote;

        //protected access modifier example
        private int numberOfEmployees = 100;//only accessible from this class
        protected int numberOfEmployess2 = 100;//accessible from this class and its children
        public Company(string quote)
        {
            Quote = quote;
        }
        public void Communication()
        {
            Console.WriteLine("The Communication Channel..");
        }
        public void Working()
        {
            Console.WriteLine("Office is open");
        }
    }
}
