using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace FirstIoCTest
{
    public class Caller
    {
        private readonly Callee _callee;

        public Caller(Callee callee)
        {
            _callee = callee;
            Console.WriteLine("Constructor of Caller");
        }

        public void DoSomething()
        {
            _callee.Do();
        }
    }
}
