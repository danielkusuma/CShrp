using ExConsoleApp.Math;
using System;

namespace ExConsoleApp
{
    class Program
    {
        /*
        //Enum
        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }
        */
        static void Main(string[] args)
        {
            /*
            // enum
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
            byte b = (byte) i;
            // max byte = 255
            Console.WriteLine(b);
            try
            {

                // var number = 1234;
                // int j = Convert.ToByte(number);
                // Console.WriteLine(j);   
                string str = "true";
                bool j = Convert.ToBoolean(str);
                Console.WriteLine(j);
            }
            catch (Exception)
            {
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
        }
    }
}
