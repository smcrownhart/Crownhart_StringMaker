using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Crownhart_StringMaker
{
    internal class StringMaker : SoOverrideWillWork
    {
        //https://www.geeksforgeeks.org/stack-set-3-reverse-string-using-stack/
        //https://www.c-sharpcorner.com/blogs/string-reverse-using-stack
        public string Reverse(string s)
        {
            int l = s.Length;
            string reverse = string.Empty;
            Stack stack = new Stack(l);

            for (int i = 0; i < l; i++)
            {
                stack.Push(s[i]);
            }

            while (stack.Count > 0)
            {
                reverse += stack.Pop();
            }

            return reverse;
        }
        public string Reverse(string s, bool PreserveCaseLocation)
        {
            string reverse = "";
            char[] saved = new char[s.Length];
            Stack stack = new Stack(s.Length);
            bool[] UpperCase = new bool[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                stack.Push(s[i]);
            }

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (char.IsUpper(c)) { UpperCase[i] = true; }
                if (char.IsLower(c)) { UpperCase[i] = false; }
            }

            while (stack.Count > 0)
            {
                reverse += stack.Pop();
            }

            for (int i = 0; i < reverse.Length; i++)
            {
                char x = reverse[i];
                if (UpperCase[i] == true) { saved[i] = char.ToUpper(x);}
                if (UpperCase[i] == false) { saved[i] = char.ToLower(x); }
            }
            string itFinallyWorks = new string(saved);
            

            return itFinallyWorks;
        }

        public bool Symmetric(string s)//palindrome
        {
            string reverse = string.Empty;
            Stack stack = new Stack(s.Length);

            for (int i = 0; i < s.Length; i++)
            {
                stack.Push((char)s[i]);
            }

            while (stack.Count > 0)
            {
                reverse += stack.Pop();
            }

            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = 0; j < reverse.Length; j++)
                {
                    if (s[i] == reverse[j]){return true;}
                    
                    else {return false;}
                }
            }
            return false;
        }

        public override string ToString(string s)
        {
            char ch = ' ';
            int[] number = new int[s.Length];
            int add = 0;
            string another = string.Empty;

            if(s.Length <= 0){another = "Negative One "; return another;}
            
            //https://stackoverflow.com/questions/5002909/getting-the-ascii-value-of-a-character-in-a-c-sharp-string
            for (int i = 0; i < s.Length; i++)
            {
                ch = s[i];
                add += (int)ch;
            }

            
            string final = add.ToString();
            char[] done = final.ToCharArray();
            string[] some = new string[final.Length];
            string[] finished = new string[some.Length];

            for(int i = 0; i < some.Length; i++)
            {
                some[i] = char.ToString(done[i]);
                
            }

            for(int i = 0; i < some.Length; i++)
            {

                if (some[i] == "1"){ finished[i] = "One ";}
                
                if (some[i] == "2"){ finished[i] = "Two ";}
                
                if (some[i] == "3"){finished[i] = "Three ";}
                
                if (some[i] == "4"){finished[i] = "Four ";}
                
                if (some[i] == "5"){finished[i] = "Five ";}
                
                if (some[i] == "6"){finished[i] = "Six ";}
                
                if (some[i] == "7"){finished[i] = "Seven ";}
                
                if (some[i] == "8"){finished[i] = "Eight ";}
                
                if (some[i] == "9"){finished[i] = "Nine ";}
                
                if (some[i] == "0"){finished[i] = "Zero ";}

            }

            
            foreach (string i in finished)
            {
                another += i;
            }

            return another;
        }

        public override bool Equals(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (char.IsDigit(c)) { return false; }
            }

            string compare = "Hello World";
            
            if (s.Equals(compare)){return true;}
            
            else{return false;}

            return s.Equals(ToString(s)); ;
        }
        
    }


}
    

