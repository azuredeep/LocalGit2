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
        }
        public void SayMessage()
        {
            Console.WriteLine("Change in Master branch");
        }
        public void SayBranchMessage()
        {
            Console.WriteLine("Change in Dev branch");
        }

    }
}
