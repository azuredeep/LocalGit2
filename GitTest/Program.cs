using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Git local App");
            Program p = new Program();
            p.SayMessage();
            p.Say2ndMessage();
        }
        public void SayMessage()
        {
            Console.WriteLine("Change in Master branch");
        }
        public void Say2ndMessage()
        {
            Console.WriteLine("Second change in master branch");
        }
    }
}
