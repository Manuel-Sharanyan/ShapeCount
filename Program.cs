namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {   start:
            // Below is choice menu
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Area");
            Console.WriteLine("2 - Perimeter");
            Console.WriteLine("3 - Draw");
            Console.WriteLine("4 - exit");
            Console.WriteLine("Choice");


            //int Choice = int.Parse(Console.ReadLine());
            if (!int.TryParse(Console.ReadLine(), out int Choice))
            {
                Console.WriteLine("Invalid choice input. Please enter a valid number.");
                goto start;
            }
            int height = 0;
            int width = 0;
            // This is Choice range from 1 to 3
            if (Choice > 0 && Choice < 4)
            {
                Console.Write("Enter height: ");
                if (!int.TryParse(Console.ReadLine(), out int parsedHeight))
                {
                    Console.WriteLine("Invalid height input. Please enter a valid number.");
                    goto start;
                }
                height = parsedHeight;
                //height = int.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                if (!int.TryParse(Console.ReadLine(), out int parsedWidth))
                {
                    Console.WriteLine("Invalid width input. Please enter a valid number.");
                    goto start;
                }
                width = parsedWidth;
                //width = int.Parse(Console.ReadLine());
            }

            // This is actions after entered values
            int Area = height * width;
            int Perimeter = 2 * (height + width);
            int Draw = height - width;

            switch (Choice)
            {
                case 1:
                    Console.WriteLine($"Area = {height} * {width} = {Area}");
                    break;
                case 2:
                    Console.WriteLine($"Perimeter = ({height} + {width}) * 2 = {Perimeter}");
                    break;
                case 3:
                    Console.WriteLine($"Draw = {height} - {width} = {Draw}");
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.WriteLine();
            goto start;
        }
    }
}