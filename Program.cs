using System;

namespace wzorzec1
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton min = Singleton.nowe();
            Singleton won = Singleton.nowe();
            Singleton ho = Singleton.hrh();

            if (min == won)
            {
                Console.WriteLine("1. Obiekty są takie same");
            }
            else
            {
                Console.WriteLine("1. Obiekty są inne");
            }

            if (ho == min)
            {
                Console.WriteLine("2. Obiekty są takie same");
            }
            else
            {
                Console.WriteLine("2. Obiekty są inne");
            }

        }
    }

    class Singleton
    {
        private static Singleton meanie;

        public static Singleton nowe()
        {
            if (meanie == null)
            {
                meanie = new Singleton();
            }

            return meanie;
        }

        private static Singleton horanghae;

        public static Singleton hrh()
        {
            if (horanghae == null)
            {
                horanghae = new Singleton();
            }
            return horanghae;
        }
    }
}