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
            var discounts = new List<string> { "a", "abba", "abca" };
            Print(findValidDiscountCoupons(discounts));

            Console.WriteLine("press any key..");
            Console.ReadKey();
        }

        public static List<int> findValidDiscountCoupons(List<string> discounts)
        {
            var r = new List<int>(); // result
            foreach (var d in discounts)
            {
                if (d == "")
                    r.Add(1);
                else if (d.Length == 1)
                    r.Add(1);
                else
                {
                    if (isAllCharCountEven(d))
                        r.Add(1);
                    else
                        r.Add(0);
                }
            }

            return r;
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
