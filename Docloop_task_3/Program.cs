using System;

namespace Docloop_task_3
{
    class Program
    {
        /*
         For a given string in C# count the number of occurrences of each character that repeats itself (occurs more than once). 
        You are not allowed to use LINQ. 

        Example: str = “abcdzefazz”. Program output: “Character a has 2 occurrences. Character z has 3 occurrences.”
         */

        static void Main(string[] args)
        {
            string my_string = "aaabbcddeeeeefgh";
            char[] my_char_arr = my_string.ToCharArray();
            string doubles = my_char_arr[0].ToString();
            

            for (int i = 1; i < my_char_arr.Length; i++)
            {
                for (int j = i + 1; j < my_char_arr.Length; j++)
                    if (my_char_arr[i] == my_char_arr[j])
                        if (!doubles.Contains(my_char_arr[i].ToString()))
                            doubles += my_char_arr[i].ToString();                       
            }
            
            char[] double_arr = doubles.ToCharArray();
            foreach (char x in double_arr)
            {
                int count = 0;
                for (int m = 0; m < my_char_arr.Length; m++)
                    if (x == my_char_arr[m])
                        count++;

                if (count > 1)
                    Console.WriteLine("Character {0} has {1} occurrences", x, count);
            }            
        }
    }
}
