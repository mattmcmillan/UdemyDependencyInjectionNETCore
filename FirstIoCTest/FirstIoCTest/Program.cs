using System;
using System.ComponentModel;
using System.Security.Authentication.ExtendedProtection;
using Microsoft.Extensions.DependencyInjection;

namespace FirstIoCTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //register types with container
            var container = new ServiceCollection();
            container.AddScoped<Callee>();
            container.AddScoped<Caller>();

            //get types from provider
            var provider = container.BuildServiceProvider();

            //call methods with caller
            //instances of registered classes are also created here (constructors)
            var caller = provider.GetService<Caller>();

            //Console.Clear();
            caller.DoSomething();
            Console.ReadKey();


        }
    }
}
