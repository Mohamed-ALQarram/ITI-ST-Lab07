using Lab07;

namespace Lab7
{
     class Program
    {
        static void Main(string[] args)
        {
            int ShapesNo = 3;
            GeoShape[] Shapes = new GeoShape[ShapesNo];
            int Counter = 0;
            bool looping = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n1.Add Shape\n" +
                                "2.Calculate Area\n" +
                                "3.Sum Of Total Areas\n" +
                                "4.Exit\n");
                Console.Write("Enter Choice: ");
                char.TryParse(Console.ReadLine(), out char ch);
                if (Counter < 3 || ch != '1')
                {
                    Console.Clear();
                    switch (ch)
                    {
                        case '1':
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\n1.Rectangle\n" +
                        "2.Triangle\n" +
                        "3.Circule\n" +
                        "4.Exit\n");
                            Console.ResetColor();
                            Console.Write("Enter Your Choice: ");
                            char.TryParse(Console.ReadLine(), out ch);
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine();
                            switch (ch)
                            {
                                case '1':
                                    Console.Write("Enter Width = ");
                                    double.TryParse(Console.ReadLine(), out double Width);
                                    Console.Write("Enter Height = ");
                                    double.TryParse(Console.ReadLine(), out double Height);
                                    Shapes[Counter] = new Rectangle(Width, Height);
                                    break;
                                case '2':
                                    Console.Write("Enter Base = ");
                                    double.TryParse(Console.ReadLine(), out double Base);
                                    Console.Write("Enter Height = ");
                                    double.TryParse(Console.ReadLine(), out Height);
                                    Shapes[Counter] = new Triangle(Base, Height);
                                    break;
                                case '3':
                                    Console.Write("Enter redius = ");
                                    double.TryParse(Console.ReadLine(), out double redius);
                                    Shapes[Counter] = new Circule(redius);
                                    break;
                                case '4':
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Enter Valied number from 1 to 4");
                                    continue;
                            }
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Counter++;
                            Console.WriteLine($"{Shapes[Counter - 1].GetType().Name} Added Successfully");
                            break;
                        case '2':
                            if (Shapes[Counter] is null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("First Add Shape to Calculate area");
                                continue;
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"\n{Shapes[Counter - 1].GetType().Name} Area's= {Shapes[Counter - 1].CalArea()}\n");
                            break;
                        case '3':
                            double sum = 0;
                            for (int i = 0; i < Counter; i++)
                            {
                                sum += Shapes[i].CalArea();
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Sum of Areas = {sum}\n");
                            break;
                        case '4':
                            looping = false;
                            break;
                    default:
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.WriteLine("Enter a Valied Number (1 - 4)");
                            continue;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Can't add More Shapes your list is full\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Would you like to replace existing Shapes? (y , n)");
                    char.TryParse(Console.ReadLine(), out ch);
                    if (ch == 'y')
                        Counter %= 3;
                    Console.Clear();
                }
            }
            while (looping);
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.Write("Thank You For Using Our App.\x03");
            Console.ForegroundColor=ConsoleColor.Black;
        }
     }
}

