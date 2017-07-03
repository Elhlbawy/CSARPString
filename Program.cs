
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "Hello \"Live is good\" Man"; // to use "" inside string use \
            //string myString = "A new line \nlike that"; // to add a new line use \n
            //string myString = "Go to c:\\drive"; // to use backslash \\
            //string myString = @"That other way to use backslash, Like this:: Go to c:\drive";

            //string myString = string.Format("{0}+{1}", "First ", " Second");
            //string myString = string.Format("{0:C}", 1254.35); // for Currency symbols
            //string myString = string.Format("{0:N}", 1235545494841164); // to add comma to seperate number
            // string myString = string.Format("Percentage: {0:P}", .1235);
            //string myString = $"Saudi Arabia phone number: {966561263158: (+###) ##-#######}";
            //string myString = string.Format("Saudi Arabia phone number: {0: (+###) ##-#######}", 966561263158);

            //string myString = " That summer took three a cross the broad ";
            //myString = myString.Substring(6,14); 
            //myString = myString.ToUpper();
            // myString = myString.Replace(" ", "--"); //it`s caseSenetive
            // myString = myString.Remove(6,14);
            //myString = string.Format("Lenght befor: {0} -- Lenght After: {1}", myString.Length, myString.Trim().Length);
            //string myString = "";
            //for (int i = 0; i < 100; i++)
            //{
            //    myString += "--" + i.ToString();
            //}


            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
            Console.WriteLine(myString);
            Console.ReadLine(); 
        }
    }
}
