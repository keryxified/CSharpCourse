using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8._1_2_
{
    internal class SumOfElements : IObserver
    {
        public void Update(ISubject subject)
        {
            int[] array = (subject as NumbersProcessor).resultArray;
            Console.WriteLine($"\nSum of the elements is {array.Sum()}");
        }
    }
}
