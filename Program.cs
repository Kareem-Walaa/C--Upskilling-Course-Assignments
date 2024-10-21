namespace ConsoleApp1
{
    internal class Program
    {  
        static int ReadNumber(string msg)
    {
        Console.Write(msg);
        int n = int.Parse(Console.ReadLine());
        return n;
    }

        static string ReadString(string msg)
        {
            Console.Write(msg);
            string s = Console.ReadLine();
            return s;
        }

        static void Show_Assignment_Solution(bool Assg1 = true , bool Assg2 = true, bool Assg3 = true , bool Assg4 = true)
        {
            //Assignment 1
            Assg1 = true;
            while (Assg1)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(" Assignment 1 Solution ");
                Console.WriteLine("       Say hi :)       ");
                Console.WriteLine("-----------------------\n");

                string UserName = ReadString(" What is your name : ");
                Console.WriteLine($"\nHello, {UserName}! Welcome to the C# course.");
                Console.WriteLine("-----------------------------------------------------------");
                break;
            }

            //Assignment 2
            Assg2 = true;
            while (Assg2)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(" Assignment 2 Solution ");
                Console.WriteLine(" Arithmetic operations ");
                Console.WriteLine("-----------------------\n");

                int num1 = ReadNumber(" enter first number : ");
                int num2 = ReadNumber(" enter seconed number : ");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($" Sum of numbers : {num1+num2} .");
                Console.WriteLine($" Subtracion of numbers : {num1 - num2} .");
                Console.WriteLine($" multiply of numbers : {num1 * num2} .");
                Console.WriteLine($" division of numbers : {num1 / num2} .");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~");
                break;

            }

            //Assignment 3
            Assg3 = true;

            while (Assg3)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(" Assignment 3 Solution ");
                Console.WriteLine("      Calculate Age    ");
                Console.WriteLine("-----------------------\n");

                int CurrentYear = 2024;
                int birthYear = ReadNumber(" Please Enter your birth year : ");
                int YourAge = CurrentYear - birthYear;
                Console.WriteLine($"\n You are {YourAge} years old ");

                Console.WriteLine();
                break;

            }

            //Assignment 4
            Assg4 = true;

           while(Assg4)
            {

                Console.WriteLine("-----------------------");
                Console.WriteLine(" Assignment 4 Solution ");
                Console.WriteLine(" Temprature Converter\n  from C -> F   ");
                Console.WriteLine("-----------------------\n");

                int c = ReadNumber(" enter the temperature in Celsius : ");

                int F =(int)(c * 1.8) + 32;
                Console.WriteLine($"\n {c} degrees Celsius is {F} degrees Fahrenheit.\r\n");

                Console.WriteLine();
                break;

            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\n\n Assignment Solution : \n\n ");

            Show_Assignment_Solution();
        }
    }
}
