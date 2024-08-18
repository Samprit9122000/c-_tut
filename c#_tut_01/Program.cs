using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using MyException;

namespace c__tut_01
{

    // class for testing
    public class Animal
    {
        public string name { get; set; } = "Elephant";
        private string sound;
        public string Sound   // using to get and set private variable sound  IN C# FORMAT
        {
            get
            {
                return sound;  
            }
            set
            {
                if (value.Length > 10)     // value is predefined keyword to get the given value in setter
                {
                    Console.WriteLine("Too long sound");
                    this.sound = "No sound";
                }
                else
                {
                    this.sound = value;
                }
            }
        }


        // Easy getter setter like java
        public string getSound()
        {
            return sound;
        }

        public void setSound(string sound)
        {
            this.sound= sound;
        }


    }

    internal class Program
    {

        //---- static methods ------

        static double DoDivision(double x, double y)
        {
            if (y == 0.0)
            {
                throw new CustomException("this is my exception xxxxxxxxxxxxxxxxxxx");
            }
            return (double)(x / y);
        }


        static void swap(ref int a,  ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static int add(params int[] nums)
        {
            int sum = 0;
            foreach (int i in nums) {
                //Console.WriteLine(i);
                sum = sum + i;
            }
            return sum;
        }

        // -------------------------

        static void Main(string[] args)
        {
                //Console.WriteLine("Hello World");
                //var a = 2;
                //var b = 3;
                //int c = a+b;
                //Console.WriteLine(c);
                ///*Console.WriteLine(args[0]);
                //Console.WriteLine(args[1]);*/
                //Console.Write("Enter Your Name: ");
                //var name = Console.ReadLine();
                //Console.WriteLine();
                //Console.WriteLine($"yyyyyyyy {name} !!!!!");
                //Console.ReadLine();

                // *** String methods
                //string randString = "This is a new string";
                //string[] newArray = randString.Split(' ');
                //Console.WriteLine(randString.Split(' '));
                //for (int i = 0; i < newArray.Length; i++)
                //{
                //    Console.WriteLine(newArray[i]);
                //}
                //Console.WriteLine(randString.Contains("is"));
                //Console.ReadLine();


                // Exception Handling
                //double x = 5.0;
                //double y = 0.0;

                //try
                //{
                //    Console.WriteLine(DoDivision(x, y));
                //}

                //catch (DivideByZeroException ex)
                //{
                //    Console.WriteLine(ex.GetType().Name);
                //    Console.WriteLine(ex.Message);
                //}
                //catch (CustomException ex)
                //{
                //    Console.WriteLine("This is a normal exception");
                //    Console.WriteLine(ex.GetType().Name);
                //    Console.WriteLine("Messege: {0}",ex.Message);

                //}
                //finally
                //{
                //    Console.WriteLine("Exception handling done (This is in finally block)");
                //    Console.ReadLine();

                //}



                // pass by reference
                //int a = 10;
                //int b = 20;
                //swap(ref a, ref b);
                //Console.WriteLine($"a = {a}\nb = {b}");
                //Console.ReadLine();


                // pass unlimited parameters
                //Console.WriteLine("1 + 2 + 3 = {0}",add(1, 2, 3));
                //Console.ReadLine();


                // Nullable value
                //int? a = null;
                //if (!a.HasValue)
                //{
                //    Console.WriteLine("value is null");
                //}
                //else {
                //    Console.WriteLine(a.Value);
                //}

                //var a = "Hello World";
                //Console.WriteLine(a);



                // experiment getter and setter 
                Animal myAnimal = new Animal()
                {
                    name = "dog",
                    Sound = "bark"
                };
                Console.WriteLine($"Name: {myAnimal.name}\nSound: {myAnimal.Sound}");

                Animal cat = new Animal()
                {
                 name = "cat"
                };

                cat.setSound("Mew");
                Console.WriteLine($"Name: {cat.name}\nSound: {cat.getSound()}");

                Console.ReadLine();


        }
    }
}
