using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John Michaelsen";
            name = ResizeName(name);
            Console.WriteLine(name);
        }
        public static string ResizeName(string n)
        {
            string result = "";
            string s = " ";

            char[] name = n.ToCharArray();
            char[] space = s.ToCharArray();

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == space[0])
                {
                    return result;
                }
                result += name[i];
            }
            return result;
        }
    }
}
