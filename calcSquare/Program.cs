namespace calcSquare 
{
    class Program
    {
        public static void Main()
        {  
            Console.Write("1 - circle, 2 - triangle\nYour Choice: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            if (userChoice == 1)
            {
                Console.Write("Enter Radius: ");
                double r = Convert.ToDouble(Console.ReadLine());

                Circle circle = new(r);

                Console.WriteLine("Answer: " + circle.Calc());
                Console.ReadKey(true);
            }
            else
            {
                Console.Write("Enter AB side: ");
                double ab = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Enter BC side: ");
                double bc = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter AC side: ");
                double ca = Convert.ToDouble(Console.ReadLine());
                
                Triangle triangle = new(ab, bc, ca);

                Console.WriteLine("Answer: " + triangle.Calc());
                Console.ReadKey(true);
            }
        }
    }
}   