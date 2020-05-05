using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication1.ClassLibrary
{
    public class Comparator
    {
        public static int ValueComparator(int i, int j)
        {
            return i - j;
        }

        public static bool StringComparator(String s1, String s2)
        {
            return s1 == s2 ? true : false;
        }
    }
}
