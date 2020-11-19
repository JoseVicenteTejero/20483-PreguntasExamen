using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace JTejero
{
    public class Q162
    {
        public void DoWork()
        {
            //int[] arr = new int[] 
            List<Int32> items = new List<int>(){
                100, 95, 80, 75, 95};
            var result = items.Where(i => i > 80);

            foreach (Int32 r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}