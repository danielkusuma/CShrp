//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;

//namespace ExConsoleApp {
//    class Solution {
//        static void Main(string[] args) {
//            // create an array of N (integer between 1 - 100000)
//            // var n = Enumerable.Range(1, 10000).ToList();
//            // create an array of A (integer between -1kk - 1kk)
//            // var a = Enumerable.Range(-1000000, 1000000).ToList();
//            var a = new int[] { -1, -3 };
//            var n = Enumerable.Range(1, 10000).ToList();
//            var exist = n.Except(a).ToList();
//            exist.RemoveAll(i => i < 0);
//            Console.WriteLine(exist.First());
//        }
//    }
//}
