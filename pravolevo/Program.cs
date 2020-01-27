using System;

namespace pravolevo

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3-значное число:  ");
            string var = Console.ReadLine();
            string result = "";

            for (int i = var.Length - 1; i >= 0; i--) // i == длине строки(но -1 так как она начинается
                с 0) i>=0 потому что оно бы дошло до 1 и все

            {
                result += var[i];
            }

            Console.WriteLine(result);

            result = "";
            result += var[1].ToString() + var[0].ToString(); //из-за плюса перекинул в инт, поэтому тустринг
            for (int i = 2; i < var.Length; i++) 
            result += var[i];

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
