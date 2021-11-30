using System;

namespace FIsrtGitProje
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ff = true;
            while (ff)
            {
                int eded1;
                Console.WriteLine("Zehmet olmasa 1ci ededi daxil edin!!!");
                bool ed1 = int.TryParse(Console.ReadLine(), out eded1);
                if (ed1==false)
                {
                    throw new Exception("Zehmet olmasa 1ci ededi duzgun daxil edin");
                }
                int eded2;
                Console.WriteLine("Zehmet olmasa 2ci ededi daxil edin!!!");
                bool ed2 = int.TryParse(Console.ReadLine(), out eded2);
                if (ed2 == false)
                {
                    Console.WriteLine("Zehmet olmasa 2ci ededi duzgun daxil edin");
                    break;
                }
                ff = true;
                int cem = eded1 + eded2;
                Console.WriteLine(cem);
            }
            

        }
    }
}
