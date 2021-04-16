using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterView
{
    class Program
    {
        static void Main(string[] args)
        {
            //True BST
            //           4  
            //       2
            //    1      7
            //       5
            //           9
            string[] arr = { "(1,2)", "(2,4)", "(5,7)", "(7,2)", "(9,5)" };
            
            //False BST
            //string[] arr = { "(1,2)", "(3,2)", "(2,12)", "(5,2)" };
            //          12
            //     2
            //5    1     3

            Console.WriteLine(BST(arr));
            Console.ReadKey();
        }


        static string BST(string[] arr)
        {
            var childern = arr.ToList().Select(child => child.Split(',')[0].Replace("(", string.Empty)).ToList();
            var parents = arr.ToList().Select(parent => parent.Split(',')[1].Replace(")", string.Empty)).ToList();
            return childern.Distinct().Count() == arr.Count() && 
                !parents.GroupBy(g => g).Where(c => c.Count() > 2).Any() ? "True" : "False";
        }
    }
}
