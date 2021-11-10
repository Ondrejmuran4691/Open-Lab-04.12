using System;
using System.Collections.Generic;
namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] nums)
        {
            var all = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
          foreach(int i in nums)
            {
                all.Remove(i);

            }

            int vysledok = all[0];

            return vysledok;
        }
    }
}
