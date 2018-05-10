using System;
using System.Collections.Generic;
using System.Text;

namespace FirstIoCTest
{
    public class Callee
    {
        public Callee()
        {
            Console.WriteLine("Constructor of callee.");
        }

        public void Do()
        {
            Console.WriteLine("Hiya");
        }
    }
}
