using System;

namespace FunWithFlags
{
    class Program
    {

        public enum Flags
        {
            White = 1, 
            Red = 2, 
            Black = 4, 
            Green = 8, 
            Pink = 16, 
            Hazel = 32, 
            Yellow = 64, 
            Orange = 128
        }
        static void Main(string[] args)
        {


            var someValues = (byte) (Flags.Orange  | Flags.Black);

            byte shift = 1;
            shift = (byte) (shift << 3);
            
            Console.WriteLine($"{Convert.ToString((byte)someValues, 2).PadLeft(8, '0')}");

            Console.WriteLine(("------------------------------------------"));
            Console.WriteLine($"{Convert.ToString((byte)shift, 2).PadLeft(8, '0')}");

            if ((someValues & (byte) Flags.Black) == (byte) Flags.Black)
            {

                Console.WriteLine("Black was included");
            }
            else
            {
                Console.WriteLine("Black was not included");
            }
        }


    }
}
