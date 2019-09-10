using System;

namespace learningvisualstudios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            Console.WriteLine("the first line showed up on github after making changes and syncing it with guthub,but the second line no");
            Console.WriteLine("the 2nd line not in git,try making a change");

            var a = "declaring a variable";
            Console.WriteLine(a);

            Console.WriteLine("What is your name?");
            var b = Console.ReadLine();
            b = Tryagain(b);
            Console.WriteLine("customer name is " + b);

            Console.WriteLine("How old are you?");
            var c = Console.ReadLine();
            c = Tryagain(c);
            Console.WriteLine("customer age is " + c);

            Console.WriteLine("What month you were born in");
            var month = Console.ReadLine();
            month = Tryagain(month);
            Console.WriteLine("customer date of birth month is is " + month);

            var passcode = "";
            while (passcode != "secret")
            {
                Console.WriteLine("Enter the passcode");
                passcode = Console.ReadLine();
                if (passcode != "secret")
                {
                    Console.WriteLine("your passcode is not authenticated");
                }
               
                
            }
            Console.WriteLine("your passcode is authenticated");

            loops ls = new loops();
            ls.printMethodwithfor();
            ls.printarrays();*/

            studentgradingsystem jk = new studentgradingsystem();
            jk.studentgrading();




        }
        /*static string Tryagain(string question)
        {
            if (question == "")
            {
                Console.WriteLine("plz type something");
                return Console.ReadLine();
            }
            return question;
        }*/

       
    }
}
