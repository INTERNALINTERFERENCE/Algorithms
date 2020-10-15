using System;
using System.Collections.Generic;
using System.Linq;

namespace GrokkingAlgorithms.ChapterOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<int> { 1, 3, 5, 7, 9 };
            Console.WriteLine(BinarySearch(myList, 9));
        }


        private static int? BinarySearch(IList<int> list, int item)
        {
            var low = 0;
            var high = list.Count() - 1;

            while(low <= high)
            {
                var mid = (low + high) / 2; //check mid value
                var guess = list[mid];     //

                if (guess == item)
                    return mid;

                if(guess > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
                
            }

            return null;
        }
    }
}
