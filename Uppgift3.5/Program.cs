using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj ett räknesätt");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            string val = Console.ReadLine();

            switch(val)
            {

                //Addition 11 21
                case "1":
                    Console.WriteLine("Ange två tal.");
                    Console.Write("Tal 1 : ");
                    int tal11 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Tal 2 : ");
                    int tal21 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(tal11 + " + " + tal21 + " = " + (tal11 + tal21));

                    break;

                //Subtraktion 12 22
                case "2":
                    Console.WriteLine("Ange två tal.");
                    Console.Write("Tal 1 : ");
                    int tal12 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Tal 2 : ");
                    int tal22 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(tal12 + " - " + tal22 + " = " + (tal12 - tal22));

                    break;

                //Multiplikation 13 23
                case "3":
                    Console.WriteLine("Ange två tal.");
                    Console.Write("Tal 1 : ");
                    int tal13 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Tal 2 : ");
                    int tal23 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(tal13 + " * " + tal23 + " = " + (tal13 * tal23));

                    break;

                //Division 14 24
                case "4":
                    Console.WriteLine("Ange två tal.");
                    Console.Write("Tal 1 : ");
                    int tal14 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Tal 2 : ");
                    int tal24 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(tal14 + " / " + tal24 + " = " + (tal14 / tal24));

                    break;



            }
                

        }
    }
}
