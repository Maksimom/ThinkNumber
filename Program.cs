using System;

namespace ConsoleTryToGuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is the number more than that");
            int t;
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
                    t = g;
                    while (k == ">")
                    {
                        
                        g = (g / 2) + (g / 4);
                        

                        if (g % 2 == 1)
                        {
                            Console.WriteLine(g + 1);
                            k = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine(g);
                            k = Console.ReadLine();
                        }
                    }
                    while (k == "<")
                    {
                        
                        g = (t-g)/2 +g ;

                        if (g % 2 == 1)
                        {
                            Console.WriteLine(g + 1);
                            k = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine(g);
                            k = Console.ReadLine();
                        }
                    }

                }
                if (g > 0)
                {
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
                    t = g;
                    while (k == "<")
                    {

                        g = (g / 2) + (g / 4);


                       
                       
                            Console.WriteLine(g);
                            k = Console.ReadLine();
                        
                    }
                    while (k == ">")
                    {

                        g = (t - g) / 2 + g;

                        
                        
                            Console.WriteLine(g);
                            k = Console.ReadLine();
                        
                    }

                }

            }
            Console.WriteLine("that means i won");
        }
    }
}
