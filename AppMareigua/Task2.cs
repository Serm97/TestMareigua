using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMareigua
{
    public class Task2
    {
        //Contructor
        public Task2(){}

        public void FindLargestInteger()
        {
            int[] listInt = { 1, 99, 10000, 84849, 111, 212, 314, 21, 442, 455, 244, 554, 22, 22, 211 };
            Console.WriteLine(String.Concat("The largest integer is: ", FindNumber(listInt)));
        }

        private int FindNumber(int[] listNumbers)
        {            
            var Max = 0;

            for (int i = 0; i < listNumbers.Length; i++)
            {
                if (listNumbers[i] > Max)
                {
                    Max = listNumbers[i];
                }
            }
            return Max;
        }
    }
}
