using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_flow
{
    public class SelectionStatements
    {
        //if else statement
        //NB: Avoid using a lot of nested if statement else use statement
        public void PracticeIf( int age)

        {
            if (age > 18)
            {
                Console.WriteLine("You are a legal citizen");
            }
            else
            {
                Console.WriteLine("You are not a legal citizen");
            }
        }

        public void practiceSwitch(Careers careers)
        {
            switch(careers)
            {
                case Careers.HR: Console.WriteLine($"Hello {Careers.HR}");
                    break;
                case Careers.CEO:
                case Careers.COO:
                    Console.WriteLine($"Hello CEO/COO");
                    break;
                case Careers.Developer:
                    Console.WriteLine($"Hello {Careers.Developer}");
                    break;
                case Careers.Project_Managers:
                    Console.WriteLine($"Hello {Careers.Project_Managers}");
                    break;
                case Careers.QA:
                    Console.WriteLine($"Hello {Careers.QA}");
                    break;
                case Careers.Marketer:
                    Console.WriteLine($"Hello {Careers.Marketer}");
                    break;
                case Careers.SalesPerson:
                    Console.WriteLine($"Hello {Careers.SalesPerson}");
                    break;
                default:
                    Console.WriteLine($"Hello {Careers.HR}");
                    break;

            }
        }
    }
}
