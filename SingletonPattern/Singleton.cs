using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazyInstance =
            new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance { get { return lazyInstance.Value; } }

        private Singleton()
        {
        }

        public void Access()
        {
            Console.WriteLine("Singleton accessed.");
        }
    }
}
