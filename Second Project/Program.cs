namespace Second_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double num1 = 5, num2 = 10;

            bool flag;
            int num01;
            do
            {
                Console.Write("Enter the first number: ");
                flag = int.TryParse(Console.ReadLine(), out num01);
            }while(!flag);

            bool flag02;
            int num02;
            do
            {
                Console.Write("Enter the second number: ");
                flag02 = int.TryParse(Console.ReadLine(), out num02);
            } while (!flag02);

            Console.WriteLine("Addition: " + Maths.Add(num01, num02));
            Console.WriteLine("Subtraction: " + Maths.Subtract(num01, num02));
            Console.WriteLine("Multiplication: " + Maths.Multiply(num01, num02));
            Console.WriteLine("Division: " + Maths.Divide(num01, num02));
        }
    }
}
