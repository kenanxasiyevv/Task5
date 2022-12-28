namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil et: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Eded daxil et: ");
            int number2 = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int r =(int) Math.Sqrt(number); r <= Math.Sqrt(number2); r++)
            {
                if (number2 >= r * r && r*r>=number)
                    sum++;

            }
            Console.WriteLine(sum);
        }
    }
}              