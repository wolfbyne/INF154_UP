using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int myCounter=5;

            bool Checked = true;

            if (!Checked)

            {

                myCounter += 5;

            }

            else

            {

                myCounter += 2;

            }

            Console.WriteLine(Convert.ToString(myCounter));
        }
    }
}
