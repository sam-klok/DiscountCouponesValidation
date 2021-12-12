using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCouponesValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            var discounts = new List<string> { "a","abba","abca","acac","aabb","aabbx","caabbc" };
            //var discounts = new List<string> { "caabbc" };
            Print(findValidDiscountCoupons(discounts));

            Console.WriteLine("press any key..");
            Console.ReadKey();
        }

        public static List<int> findValidDiscountCoupons(List<string> discounts)
        {
            var r = new List<int>(); // result
            foreach (var s in discounts)
            {
                if (s == "")
                    r.Add(1);
                else if (s.Length == 1)
                    r.Add(0);
                else
                {
                    if (isAllCharCountEven(s) && areCharPairsValid(s))
                        r.Add(1);
                    else
                        r.Add(0);
                }
            }

            return r;
        }

        public static bool areCharPairsValid(string s)
        {
            char[] a = s.ToCharArray();

            int y = a.Length;

            for (int x = 0; x < y; x++)
            {
                if (x + 1 < y && a[x] == a[x + 1])
                {
                    // two valid characteres together
                    x++;
                }
                else if (a[x] == a[y - 1])
                {
                    // chars at the front and the end of array match
                    y--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public static bool isAllCharCountEven(string s)
        {
            while (s.Length > 0)
            {
                int count = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[0] == s[j])
                    {
                        count++;
                    }
                }

                if (count % 2 != 0)
                    return false;

                s = s.Replace(s[0].ToString(), string.Empty);
            }

            return true;
        }

        public static void Print(List<int> r)
        {
            if (r == null)
                Console.Write("null");
            else
                foreach (var i in r)
                    Console.Write(i + " ");

            Console.WriteLine();
        }
    }
}
