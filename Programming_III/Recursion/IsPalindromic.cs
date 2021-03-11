using System;
namespace Programming_III.Recursion
{
    public class IsPalindromic
    {
        //valid password: ['a', 'x', 'r', '4']
        //in-valid password: ['a', 'x', 'x', 'a']
        //Given and String, the system should inform whether the string is valid as a password or not.
        // in-valid = the string is palindromic
        // valid = the string is nOT palindromic
        //Using recursion
        //(e.g.) 'hello' = VALID
        //(e.g.) 'civic' = IN-VALID

        /*
            caso base
                ['x'] = invalid
                ['x', 'x'] = invalid
                ['x', 'y'] = valid

            recursion
                palindromic(s[0... n-1], i=0, f=n-1) = s[i] == s[f] && palindromic(s, i+1, f-1)

                base case:
                    if(i == f): true
                    if(i + 1 == f): return s[i] == s[f]
                        
                
        */

        public static void Main(String[] args)
        {
            String password1 = "kayak9"; //valid
            String password2 = "civ3i6c"; //invalid

            bool isPassword1Valid = !IsPalindromicString(password1, 0, password1.Length - 1);
            bool isPassword2Valid = !IsPalindromicString(password2, 0, password2.Length - 1);

            if (!isPassword1Valid)
            {
                Console.WriteLine("Password 1 is not valid");
            }
            else
            {
                Console.WriteLine("Password 1 is valid");
            }

            if (!isPassword2Valid)
            {
                Console.WriteLine("Password 2 is not valid");
            }
            else
            {
                Console.WriteLine("Password 2 is valid");
            }
        }

        public static bool IsPalindromicString(String s, int i, int f)
        {
            if (i == f) return true;

            if (i + 1 == f) return s[i] == s[f];

            return s[i] == s[f] && IsPalindromicString(s, i + 1, f - 1);
        }
    }
}
