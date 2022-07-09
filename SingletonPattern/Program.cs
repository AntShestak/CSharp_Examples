using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Singleton.Instance.Access();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
