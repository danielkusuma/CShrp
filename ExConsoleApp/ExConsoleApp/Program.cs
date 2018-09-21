using ExConsoleApp.Math;
using System;
using System.Collections.Generic; //List
using System.Linq;
using System.Text; //StringBuilder
using System.IO;

namespace ExConsoleApp {
    class Program {
        static void Main(string[] args) {
            File.OpenWrite
            /*
            // Demo Codility
            // create an array of N (integer between 1 - 100000)
            // var n = Enumerable.Range(1, 10000).ToList();
            // create an array of A (integer between -1kk - 1kk)
            // var a = Enumerable.Range(-1000000, 1000000).ToList();
            var a = new int[] { -1, -3 };
            var n = Enumerable.Range(1, 10000).ToList();
            var exist = n.Except(a).ToList();
            exist.RemoveAll(i => i < 0);
            Console.WriteLine(exist.First());
            */
            /*
            //StringBuilder
            //var builder = new StringBuilder();
            var builder = new StringBuilder("Hello World");
            //Append
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header")
                   .AppendLine()
                   .Append('-', 10);
            Console.WriteLine(builder);
            //Replace
            builder.Replace('-', '+');
            Console.WriteLine(builder);
            //Remove
            builder.Remove(0, 10);
            Console.WriteLine(builder);
            //Insert
            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);
            Console.WriteLine("First Char: " + builder[0]);
            */
            /*
            //String
            var fullName = "Daniel Kusuma ";
            // Trim
            Console.WriteLine("Trim: '{0}' ", fullName.Trim());
            // ToUpper
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            // Substring
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);
            // Split
            var names = ( fullName.Split(' ') );
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName:" + names[1]);
            // Replace
            Console.WriteLine(fullName.Replace("Daniel", "Dan"));
            Console.WriteLine(fullName.Replace('i', 'I'));
            // isNullOrWhiteSpace
            if(String.IsNullOrEmpty(" ".Trim())) {
                Console.WriteLine("Invalid");
            }
            if( String.IsNullOrWhiteSpace(" ") ) {
                Console.WriteLine("Invalid");
            }
            // Convert
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);
            // ToString
            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));
            */
            /*
            // Lists
            var numbers = new List<int>() { 1, 2, 3, 4 };
            // Add
            numbers.Add(1);
            // AdRange
            numbers.AddRange(new int[3] { 5, 6, 7 });
            foreach( var number in numbers ) {
                Console.WriteLine(number);
            }
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));
            Console.WriteLine("Count: " + numbers.Count);
            // Remove
            for( var i = 0; i < numbers.Count; i++ ) {
                if( numbers[i] == 1 ) {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach( var number in numbers ) {
                Console.WriteLine(number);
            }
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
            */
            /*
            // ArrAys
            // int[] numbers = new int[] { 1, 2, 3, 7, 5, 4 };
            var numbers = new[] { 1, 2, 3, 4, 5, 6 };
            // Length
            Console.WriteLine("Length: " + numbers.Length);
            // IndexOf()
            var index = Array.IndexOf(numbers, 7);
            Console.WriteLine("Index of 6: " + index);
            // Clear()
            Array.Clear(numbers, 0, 3);
            // Copy()
            var numbers1 = new int[3];
            Array.Copy(numbers1, numbers, 3);
            // Sort()
            Array.Sort(numbers);
            // Reverse()
            Array.Reverse(numbers);
            foreach (var n in numbers ) {
                Console.WriteLine(n);
            }
            */
            /*
            // While Loop
            while( true ) {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();
                if( !String.IsNullOrWhiteSpace(input) ) {
                    Console.WriteLine("@Echo: " + input);
                    // continue;
                }
                break;
            }
            var i = 0;
            while( i < 10 ) {
                if( i % 2 == 0 ) {
                    Console.WriteLine(i);
                }
                i++;
            }
            */
            /*
            // Foreach loop
            var numbers = new int[] {
                1, 2, 3, 4
            };
            foreach( var number in numbers ) {
                Console.WriteLine(number);
            };
            var name = "John Smith";
            for ( var i = 0; i < name.Length; i++ ) {
                Console.WriteLine(name[i]);
            }
            foreach (var character in name) {
                Console.WriteLine(character);
            }
            */
            /*
            // For Loop
            for( int i = 1; i <= 10; i++ ) {
                if( i % 2 == 0 ) {
                    Console.WriteLine(i);
                }
            }
            for( int i = 10; i >= 1; i-- ) {
                if( i % 2 == 0 ) {
                    Console.WriteLine(i);
                }
            }
            */
            /*
            // If Else and Switch Case
            var season = Season.Autumn;
            switch( season ) {
                case Season.Spring:
                case Season.Summer:
                    Console.WriteLine("It's a nice season");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's a beautiful season.");
                    break;
                default:
                    Console.WriteLine("It's a good season");
                    break;
            } 
            bool isGoldCostumer = true;
            //float price;
            //if( isGoldCostumer ) {
            //    price = 19.95f;
            //} else {
            //    price = 29.95f;
            //}
            float price = (isGoldCostumer) ? 19.95f : 29.95f;
            Console.WriteLine(price);
            int hour = 10;
            if ( hour > 0 && hour < 12 ) {
                Console.WriteLine("It's Morning");
            } else if ( hour > 12 && hour < 18 ) {
                Console.WriteLine("It's Afternoon");
            } else {
                Console.WriteLine("It's Evening");
            }
            */
            /*
            // Reference and Value Types (See Btm Page)
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("arrray1[0]: {0}, array2[]: {1}", array1[0], array2[0]));
            // var number = 1;
            // Increment(number);
            // Console.WriteLine(number);
            // var person = new Person1() { Age = 20 };
            // MakeOld(person);
            // Console.WriteLine(person.Age);
            */
            /*
            // enum (look up at bottom page)
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            Console.WriteLine(method.ToString());
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
            */
            /*
            // string
            var firstName = "Daniel";
            string lastName = "Kusuma";
            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My Name is {0} {1}", firstName, lastName);
            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);
            var text = @"Hi John
      Look into the following paths
      C:\folder1
      C:\folder2";
            Console.WriteLine(text);
            */
            /*
            // Arrays
            var numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);
            var names = new string[3] { "Jack", "John", "Mary" };
            */
            /*
            // Classes
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";        
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
            */
            /*
            // Variables and Constant
            Console.WriteLine("Hello World!");
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Daniel";
            bool isWorking = false;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            const float Pi = 3.14f;
            // Pi = 1;
            */
            /*
            // Type Conversion
            int i = 1;
            byte b = (byte)i;
            // max byte = 255
            Console.WriteLine(b);
            try {
                // var number = 1234;
                // int j = Convert.ToByte(number);
                // Console.WriteLine(j);   
                string str = "true";
                bool j = Convert.ToBoolean(str);
                Console.WriteLine(j);
            } catch( Exception ) {
                Console.WriteLine("The number cannot be converted to a byte");
            }
            */
            /*
            // Operators
            var a = 1;
            var b = 2;
            var c = 3;
            Console.WriteLine(a / b);
            Console.WriteLine((float)a / (float)b);
            Console.WriteLine(a + b * c);
            Console.WriteLine(a > b);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a > b));
            Console.WriteLine(c > b && a > b);
            Console.WriteLine(!(c > b || c == a));
            */
            // Reference Types and Value Types
        }
        /*
        // Reference and Value Type
        public static void Increment(int number) {
            number += 10;
        }
        public static void MakeOld(Person1 person) {
            person.Age += 10;
        }
        */
    }
    /*
    //Enum
    public enum ShippingMethod {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    */
    /*
    // Reference and Value Types
    public class Person1 {
        public int Age;
    }
    */
}
