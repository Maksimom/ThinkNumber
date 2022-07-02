using System;

namespace ConsoleTryToGuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is the number more than that");
           int g = 0;
            Console.WriteLine(g);
            string k = Console.ReadLine();
            if (k == ">")
            {
                g = g + 2;
            }
            else if (k == "<")
            {
                g = g - 2;
            }
            else if (k == "Yes")
            {
                Console.WriteLine("that means i won");
            }
           Console.WriteLine(g);
            k = Console.ReadLine();          
            while (k!="Yes")
            {
                if (g<0)
                {
                    while (k != ">")
                    {
                        g = g * 2;
                        Console.WriteLine(g);
                        k = Console.ReadLine();
                        
                    }
                    if (g == -2 && k == ">")
                    {
                        g = g + 1;
                        Console.WriteLine(g);
                        k = Console.ReadLine();
                    }
                    int d = g - (g / 4) - (g / 2);
                    while (k != "Yes")
                    {
                        if (k == ">")
                        {
                            g = g - d;
                            d = d / 2;
                            Console.WriteLine(g);
                            k = Console.ReadLine();
                        }
                        else if (k == "<")
                        {
                            g = d + g;
                            d = d / 2;
                            Console.WriteLine(g);
                            k = Console.ReadLine();
                        }
                    }

                }
                while (k!="Yes"&&g > 0)
                {
                    while (k != "<")
                    {
                        g = g * 2;
                        Console.WriteLine(g);
                        k = Console.ReadLine();

                    }
                    while (k != "<")
                        {
                            g = g * 2;
                            Console.WriteLine(g);
                            k = Console.ReadLine();

                        }
                        if (g == 2 && k == "<")
                        {
                            g = g - 1;
                            Console.WriteLine(g);
                            k = Console.ReadLine();
                        }
                         int d = g - (g / 4) - (g / 2);
                        while (k != "Yes")
                        {
                        if (k == "<")
                        {
                            g = g - d;
                            d = d / 2;
                            Console.WriteLine(g);
                            k = Console.ReadLine();
                        }
                        else if (k == ">")
                        {
                            g = d + g;
                            d = d / 2;
                            Console.WriteLine(g);
                            k = Console.ReadLine();
                        }
                   }
                        
                            

                       

                    
                }

            }
            Console.WriteLine("that means i won");
        }
    }
}
