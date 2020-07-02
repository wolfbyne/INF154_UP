using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "distance";
            Random rnd = new Random();

            int i = 0;
            while(i < 10)
            {
                int leaveOut = rnd.Next(0, test.Length);
                Console.WriteLine(test.Replace(test.Substring(leaveOut, 1), "*"));
                i++;
            }
            
        }
    }
}
