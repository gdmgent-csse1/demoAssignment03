using System;
using System.IO;

namespace assignment_03_start
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WriteSecret("Hello World!!!");

            Console.WriteLine("lengte: " + args.Length);
/*
            Random rnd = new Random();
            int output = rnd.Next(5, 20);
            Console.WriteLine(output);
*/

            //hoeveel elementen zitten er in de collectie...
            if(args.Length == 2)
            {
                bool isStrong = false;
                //speciale gevallen l s en u s
                for (int x = 0; x < args.Length; x++)
                {
                    if(args[x] == "s")
                    {
                        isStrong = true;
                    }
                }

                // operaties...

                for (int i = 0; i < args.Length; i++)
            {
                Random rnd = new Random();
                Console.WriteLine(args[i]);
                switch (args[i])
                {
                    case "n":
                        Console.WriteLine("Geef een minimum waarde in van het bereik...");
                        int min = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Geef een maximum waarde in van het bereik...");
                        int max = Convert.ToInt32(Console.ReadLine());
                        //int output = rnd.Next(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                        int output = rnd.Next(min, max);
                        Console.WriteLine(output);
                        break;
                    case "l":
                        //wachtwoord returnen met kleine letters...
                        //lengte vragen...
                        string secret = "";

                        int lengte = Convert.ToInt32(Console.ReadLine());
                        for (int j = 0; j < lengte; j++)
                        {
                            //97 122
                            //int output = rnd.Next(97, 123);
                            //secret += ;
                        }
                        WriteSecret(secret);
                        break;
                    case "u":
                        //wachtwoord returnen met hoofdletters...
                        //lengte vragen...
                        //string secret = "";
                        
                        //int lengte = );
                        for (int j = 0; j < Convert.ToInt32(Console.ReadLine()); j++)
                        {
                            //97 122
                            //int output = rnd.Next(97, 123);
                            //secret += ;
                        }
                        //WriteSecret(secret.ToUpper());
                        WriteSecret("rertert".ToUpper());
                        break;
                    default:
                        break;
                }
            }
            }
            else
            {
                //gewone operaties
                for (int i = 0; i < args.Length; i++)
            {
                Random rnd = new Random();
                Console.WriteLine(args[i]);
                switch (args[i])
                {
                    case "n":
                        Console.WriteLine("Geef een minimum waarde in van het bereik...");
                        int min = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Geef een maximum waarde in van het bereik...");
                        int max = Convert.ToInt32(Console.ReadLine());
                        //int output = rnd.Next(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                        int output = rnd.Next(min, max);
                        Console.WriteLine(output);
                        break;
                    case "l":
                        //wachtwoord returnen met kleine letters...
                        //lengte vragen...
                        string secret = "";

                        int lengte = Convert.ToInt32(Console.ReadLine());
                        for (int j = 0; j < lengte; j++)
                        {
                            //97 122
                            //int output = rnd.Next(97, 123);
                            //secret += ;
                        }
                        WriteSecret(secret);
                        break;
                    case "u":
                        //wachtwoord returnen met hoofdletters...
                        //lengte vragen...
                        //string secret = "";
                        
                        //int lengte = );
                        for (int j = 0; j < Convert.ToInt32(Console.ReadLine()); j++)
                        {
                            //97 122
                            //int output = rnd.Next(97, 123);
                            //secret += ;
                        }
                        //WriteSecret(secret.ToUpper());
                        WriteSecret("rertert".ToUpper());
                        break;
                    default:
                        break;
                }
            }
            }           

        }

        static void WriteSecret(string input)
        {
             if(File.Exists("secret.txt"))
            {
                string content = File.ReadAllText("secret.txt");
                Console.WriteLine("Current content of file:");
                Console.WriteLine(content);
            }
            File.WriteAllText("secret.txt", input);
        }
    }
}
