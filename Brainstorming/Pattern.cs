using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brainstorming
{
    public class Pattern
    {
        public int _number;
        public void assignPattern(int number)
        {
            _number = number;
        }
        public void DrawPattern()
        {
            for(int i = 1; i <= _number;i++)
            {

                for (int j = 1; j < i; j++)
                {
                    Console.Write("");

                }
                for (int k = 1; k <= i; k++)
                {
                    //if(k % _number == 1)
                    //{
                    //    continue;
                    //}
                    //else
                    //{
                    //    Console.Write("#");
                    //}
                    Console.Write("#");

                }
                Console.WriteLine("");

            }
        }
    }
}
