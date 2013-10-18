using Microsoft.Practices.Unity;
using System;

namespace ConsoleApplication
{
    interface IWorker
    {
        void doSomething();
    }


    public class GruntWorker : IWorker
    {
        public void doSomething()
        {
            Console.WriteLine("doSomething() from GruntWorker");
        }
    }

    public class SuperWorker : IWorker
    {
        public void doSomething()
        {
            Console.WriteLine("doSomething() from SuperWorker");
        }
    }


    public class MyFactory
    {
        private IWorker IWorker;
        MyFactory(IWorker IWorker)
        {
            this.IWorker = IWorker;
        }

        void makeEmWork()
        {
            IWorker.doSomething();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var container = new UnityContainer())
            {
                container.RegisterInstance<IWorker>(new GruntWorker());     // register
                IWorker IWorker = container.Resolve<IWorker>();             // resolve
                IWorker.doSomething();                                      // use
            }                                                               // dispose

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
