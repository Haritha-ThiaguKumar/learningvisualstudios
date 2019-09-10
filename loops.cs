using System;
using System.Collections.Generic;
using System.Text;

namespace learningvisualstudios
{
    class loops
    {
        public void countMethod()
        {
            int count = 1;
            while (count <= 10)
            {
                Console.WriteLine("count is" + count);
                count++;
            }
        }
        public void printMethodwithfor()
        {
           
           
                for (int j = 0; j < 5; j++)
                {
                    for (int i = 1; i <=10; i++)
                    {
                        Console.WriteLine(i);
                    }
                    
                    
                }
                
            
        }
        public void printarrays()
        {
            int[] studentids = new int[]
                {55,99,52,96,63,78,56,95,52};
            Console.WriteLine(studentids[5]);
            //for each loop is used to iterate through a loop
            foreach (var studentid in studentids)
            {
                Console.WriteLine(studentid);
            }
        }
    }
}
