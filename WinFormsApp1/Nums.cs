using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Nums
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }


        // OBJECT
        public Nums GetNums(List<int> list)
        {
            Nums nums = new Nums();
            nums.FirstNumber = list.First();
            nums.SecondNumber = list.Last();
        return nums;
        }

        // TUPLE
        public (int first, int last) GetNums2(List<int> list)
        {
            int first = list.First();
            int last = list.Last();

            return (first, last);
        }
    }
}
