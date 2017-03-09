using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArr = {1, 2, 5};
            Difference d = new Difference(myArr);

            d.computeDifference();

            Console.Write(d.maximumDifference);
            Console.ReadLine();

        }//end of main-method
        
    }//end of class

    class Difference
    {

        private int[] elements;
        public int maximumDifference;

        public Difference(int[] theArr)
        {
            this.elements = theArr;
        }

        public void computeDifference()
        {
            if (elements.Length < 2)
            {
                return;
            }
            //store in max the biggest value of the array
            int max = elements[0];
            //store in min the smallest value of the array
            int min = elements[1];

            for (int i = 0; i < elements.Length; i++)
            {
                if (max < elements[i])
                {
                    max = elements[i];
                }
                if(min > elements[i])
                {
                    min = elements[i];
                }
                
            }
            //now just substract the biggest and smallest number to get the maximum difference
            int diff = Math.Abs(max - min);
            this.maximumDifference = diff;
        }

    }//end of class Difference

}//end of namespace
