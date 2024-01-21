using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public static class AddOperations
    {
        // Overloaded Add() method.
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static long Add(long x, long y)
        {
            return x + y;
        }

        public static int Add(int x, int y, int z = 0)
        {
            return x + (y * z);
        }

        // in, ref, and out are not considered as part of the signature for method overloading when more than 1 modifier is used.
        // The following overloads will cause an error.
        // static int Add(ref int x) { }
        // static int Add(out int x) { }

        // However, if only 1 method uses in, ref, or out, the compiler can distinguish between the signatures.
        // static int Add(ref int x) { }
        // static int Add(int x) { }
    }
}
