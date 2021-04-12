using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondMax
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Test
    {
        public static int FoundMax2nd(int[] inputArray)
        {
            if (inputArray == null)
                throw new NullReferenceException("array not set");
            int max = 0;
            int result = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (max < inputArray[i])
                {
                    result = max;
                    max = inputArray[i];
                }
                else if (inputArray[i] > result & result < max)
                {
                    result = inputArray[i];
                }
            }
            return result;
        }
    }
}
