namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            char choice = ' ';
            int count = 0;

            while (choice != 'q' && choice != 'Q')
            {
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("Q - Quit");
                Console.WriteLine("Enter your choice: ");

                choice = Convert.ToChar(Console.ReadLine());

                if (choice == 'a' || choice == 'A')
                {
                    Console.WriteLine("Enter number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    numbers.Insert(count, num);
                    count++;
                    Console.WriteLine(num + " added");
                }

                else if (choice == 'p' || choice == 'P')
                {
                    if (count == 0)
                    {
                        Console.WriteLine("[] - the list is empty");
                    }
                    else
                    {
                        Console.Write("[ ");
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                        Console.WriteLine("]");
                    }
                }

                else if (choice == 'm' || choice == 'M')
                {
                    if (count == 0)
                    {
                        Console.WriteLine("Unable to calculate the mean - no data");
                    }
                    else
                    {
                        double sum = 0;
                        for (int i = 0; i < count; i++)
                        {
                            sum = sum + numbers[i];
                        }
                        Console.WriteLine("The mean is " + sum / count);
                    }
                }

                else if (choice == 's' || choice == 'S')
                {
                    if (count == 0)
                    {
                        Console.WriteLine("Unable to determine the smallest number - list is empty");
                    }
                    else
                    {
                        int small = numbers[0];
                        for (int i = 0; i < count; i++)
                        {
                            if (numbers[i] < small)
                            {
                                small = numbers[i];
                            }
                        }
                        Console.WriteLine("The smallest number is " + small);
                    }
                }

                else if (choice == 'l' || choice == 'L')
                {
                    if (count == 0)
                    {
                        Console.WriteLine("Unable to determine the largest number - list is empty");
                    }
                    else
                    {
                        int large = numbers[0];
                        for (int i = 0; i < count; i++)
                        {
                            if (numbers[i] > large)
                            {
                                large = numbers[i];
                            }
                        }
                        Console.WriteLine("The largest number is " + large);
                    }
                }

                else if (choice == 'q' || choice == 'Q')
                {
                    Console.WriteLine("Goodbye");
                }
                else
                {
                    Console.WriteLine("Unknown selection, please try again");
                }

                Console.WriteLine();
            }
        }
    }
}
