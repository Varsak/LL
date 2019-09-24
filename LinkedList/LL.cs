using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LL
{
    public class Program
    {
        public static void Main(string[] args)
        {

            LinkedList L1 = new LinkedList();
            
            //L1.PrintAll();
            L1.Addfirst("varsak2");
            L1.Addlast("last2");
            // L1.Addlast("last1");
            //L1.Remove(1);
            L1.AddAt("Varkaf", 1);
            L1.Addlast("last2");
            L1.AddAt("Петька", 3);
            L1.Length();
            //L1.RemoveAt("last1");
            //L1.RemoveAt("last2");
            L1.PrintAll();
            //L1.Addfirst("varsak1");
            /*L1.Addfirst("varsak2");
            L1.Addfirst("varsak3");
            L1.Addlast("last2");
            L1.Addlast("last3");
            L1.AddAt("додаэмо після 2",2);
            L1.AddAt("додаємо після 5",5);
            L1.PrintAll();
            L1.Length();
            
            Console.WriteLine();
            L1.RemoveFirst();
            L1.PrintAll();
            L1.Length();
            
            Console.WriteLine();
            L1.RemoveAt("last2");
            L1.RemoveAt("dblfksd");
            L1.PrintAll();
            L1.Length();
            Console.WriteLine();
            L1.ElementAt(3);
            L1.ElementAt(10);*/

        }
    }
}