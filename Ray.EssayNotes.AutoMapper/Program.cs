using System;
using System.Reflection;
using Ray.Infrastructure.EssayTest;

namespace Ray.EssayNotes.AutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var factory = new TestFactory(Assembly.GetExecutingAssembly());

            factory.Run();
        }
    }
}
