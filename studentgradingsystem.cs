using System;
using System.Collections.Generic;
using System.Text;


namespace learningvisualstudios
{
    class studentgradingsystem
    {
        public void studentgrading()
        {

            Console.WriteLine("enter the number of students in your class");
            var studentcount = int.Parse(Console.ReadLine());

            var studentsnamee = new string[studentcount];
            var studentsgrade = new int[studentcount];


            for (int i = 0; i < studentcount; i++)
            {
                Console.WriteLine("enter student name");
                studentsnamee[i] = Console.ReadLine();

                Console.WriteLine("enter student grade");
                studentsgrade[i] = int.Parse(Console.ReadLine());

            }



            for (int i = 0; i < studentcount; i++)
            {
                Console.WriteLine("Student name: {0} grade:{1}", studentsnamee[i], studentsgrade[i]);
            }






        }  
    }
}
