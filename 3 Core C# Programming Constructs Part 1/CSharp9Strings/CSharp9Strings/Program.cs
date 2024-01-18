using System;

namespace CSharp9Strings
{
    class Program
    {
        static void Main(string[] strings)
        {
            int age = 4;
            string name = "Soren";
            string greeting1 = string.Format("\tHello {0}, you are {1} years old.", name.ToUpper(), age);
            string greeting2 = $"\tHello {name.ToUpper()}, you are {age} years old.";
        }
    }
}
