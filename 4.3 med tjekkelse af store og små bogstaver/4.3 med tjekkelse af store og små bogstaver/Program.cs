using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class palindrome
{
    static void Main(string[] args)
    {
        Console.WriteLine("skriv et tal eller bogstaver");
        string text = Console.ReadLine();
        response hej = IsPalindrome(text);
        //bool ispalidrome = IsPalindrome(text);
        Console.WriteLine(hej.palidrome);
        Console.ReadLine();
       
    }
    static response IsPalindrome(string s)
    {
        response r = new response();
        s = s.Replace(" ", "");
        s = s.Replace(",", "");
        s = s.Replace(":", "");

        int i = 0;
        int j = s.Length - 1;

        while (i < j)
        {
            if (s[i].ToString().ToLower() != s[j].ToString().ToLower())
                r.ispalidrome=false;

            i++;
            j--;
        }
        r.palidrome = s;
        if (!r.ispalidrome)
        {
            return r;
        }
        r.ispalidrome = true;
        return r;
    }


}

public class response
{
    public bool ispalidrome;

    public string palidrome;
}

