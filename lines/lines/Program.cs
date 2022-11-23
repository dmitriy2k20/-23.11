using System;

namespace lines
{
    class Program
    {

        public static void Main(string[] args)
        {

            string str1 = "Ice cream";
            string str2 = "Ice cream1";


            bool result = String.Equals(str1, str2);

            Console.WriteLine(result);

            Console.ReadLine();

            static void Main(string[] args)
            {
                string str1 = "cat";
                string str2 = "apple";
                int res = String.CompareOrdinal(str2, str1);

                Console.WriteLine("Difference is {0}", res);
            }
            static void Main()
            {

                const string val = "13,34";

                if (val.IndexOf(",") != -1)
                {
                    Console.WriteLine("The character , is present in the specified string");
                }
            }
        }
    }
}



