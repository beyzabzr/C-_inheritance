using System;
namespace inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*                      CANLILAR
                                        |
                        BITKILER                    HAYVANLAR
                    |               |           |               |
                  TOHUMLU       TOHUMSUZ    SURUNGENLER      KUSLAR 
            */

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("**********");

            Kuslar marti = new Kuslar();
            marti.Ucmak();

        }
    }
}