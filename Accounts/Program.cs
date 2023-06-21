namespace Accounts
{
    struct Product
    {
        public int code;
        public string description;
        public double price;
    }

    class Person
    {
        public string full_name;

        public Person()
        {
            full_name = "John Doe";
        }
    }

    class Account
    {
        public int account_number;
    }

    public class Program
    {
        static double getCircleDiameter(double radius)
        {
            return radius * 2;
        }

        static void Main()
        {
            double radius = 5.0;
            double diameter = getCircleDiameter(radius);
            Console.WriteLine("The diameter of a circle with radius {0} is {1}", radius, diameter);
        }
    }
}
