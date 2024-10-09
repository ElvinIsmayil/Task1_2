using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            string ededler = "3 ve 5 qaliqsiz bolunen ededler: ";


            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    ededler += i + " ";
                }

            }

            Console.WriteLine(ededler);

            #endregion
        
        

            #region Task2
            byte a = 79;

            if (a < 65)
            {
                Console.WriteLine("Kesildin");
            }
            else if (65 <= a && a <= 85)
            {
                Console.WriteLine("Adi Diplom");
            }
            else if (85 <= a && a <= 95)
            {
                Console.WriteLine("Seref Diplomu");
            }
            else if ((95 < a))
            {
                Console.WriteLine("Yuksek Seref Diplomu");
            }

            #endregion
        }


    }
}

    

                

