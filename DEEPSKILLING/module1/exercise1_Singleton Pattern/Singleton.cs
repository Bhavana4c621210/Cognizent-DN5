using System;
using System.Collections.Generic;
using System.Text;

namespace CognizantDN5.DesignPatterns
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Singleton Object Created");
        }
    }
}
