using System;
using System.Linq;
using System.Text;
using System.Collections;

namespace HelloWorld
{
    class Program
    {
        private static string grouping(int num)
        {
            string numStr = num.ToString();   // 21
            ArrayList arrayList = new ArrayList();
            string res = "";

            for (int i = 1; i <= numStr.Length; i++)
            {
                if (i == numStr.Length || numStr[i] != numStr[i - 1])
                {
                    arrayList.Add(numStr[i - 1]);
                    string temp = addDigitCount(arrayList);
                    arrayList.Clear();
                    res += temp;
                }
                else
                {
                    arrayList.Add(numStr[i - 1]);
                }
            }
            return res;
        }

        private static string addDigitCount(ArrayList array)
        {
            StringBuilder res = new StringBuilder();
            res.Append(array.Count);
            res.Append(array[0]);
            return res.ToString();
        }

        public static void Main(String[] args)
        {
            int number = 222;
            String result = grouping(number);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
