using System;

namespace RandomNumberGeneratorQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
                private static Random random = new Random();

        /// <summary>
        /// Shuffles a list of generic objects randomly using the Fisher-Yates algorithm.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void Randomize<T>(this IList<T> list)
        {
            int size = list.Count;
            while (size > 1)
            {
                size--;
                int index = random.Next(size + 1);
                T value = list[index];
                list[index] = list[size];
                list[size] = value;
            }
        }

        /// <summary>
        /// Asserts uniqueness of a generic list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool TestUnique<T>(IList<T> list)
        {
            return list.Distinct().Count() == list.Count();
        }

        /// <summary>
        /// Asserts that a generic list size equals an expected size.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static bool TestCount<T>(IList<T> list, int count)
        {
            return list.Count == count;
        }

        /// <summary>
        /// Asserts that the original list is in a different order.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="original"></param>
        /// <param name="randomized"></param>
        /// <returns></returns>
        public static bool TestOrder<T>(IList<T> original, IList<T> randomized)
        {
            return original != randomized;
        }

        static void Main(string[] args)
        {
            // User starting sequence.
            Console.WriteLine("Welcome to Shuffle. This program is written to randomly shuffle a list.");
            Console.WriteLine("To test, lets shuffle some numbers. Please enter a range of integers you wish to shuffle (Example: 1 - 10000)");

            int min, max;
            bool proceed = true;
            string response;

            do
            {
                do
                {
                    // Range is not valid.
                    if (!proceed)
                    {
                        Console.WriteLine("Invalid range. Please make sure the minimum integer is greater than the maximum integer.");
                    }
                    // Get the minimum range value.
                    Console.Write("\nPlease enter the minimum integer: ");
                    // Check if input is an integer.
                    while (!int.TryParse(Console.ReadLine(), out min))
                    {
                        Console.Write("Invalid input. We are only testing for integers at the moment. Please enter a valid minimum integer: ");
                    }
                    // Get the minimum range value.
                    Console.Write("Please enter the maximum integer: ");
                    // Check if input is an integer
                    while (!int.TryParse(Console.ReadLine(), out max))
                    {
                        Console.Write("Invalid input. We are only testing for integers at the moment. Please enter a valid maximum integer: ");
                    }
                    // Check if range is valid.        
                    proceed = (min < max) ? true : false;
                } while (!proceed);

                Console.WriteLine("Testing shuffle for a range of {0} to {1}...\n", min, max);

                // Create a list.
                List<int> numbers = new List<int>(Enumerable.Range(min, max));

                // Assert list size.
                Debug.Assert(TestCount<int>(numbers, (max - min + 1)));

                // Assert uniqueness.
                Debug.Assert(TestUnique<int>(numbers));

#if DEBUG
                // Copy original list of numbers only in debug mode.
                List<int> originalNumbers = new List<int>(numbers);
#endif

                // Randomize the list.
                numbers.Randomize();

                // Re-assert uniqueness.
                Debug.Assert(TestUnique<int>(numbers));

                // Assert random order.
                Debug.Assert(TestOrder(originalNumbers, numbers));

                // Output the list.
                numbers.ForEach(num => Console.Write("[{0}], ", num));

                // User input to re-run test.
                Console.Write("\n\nWould you like to run another test? (y|n): ");

                response = Console.ReadLine();

                while (response.ToLower() != "y" && response.ToLower() != "n")
                {
                    Console.Write("Invalid response. Please use 'y' or 'n'. Would you like to run another test? ");
                    response = Console.ReadLine();
                }

            } while (response == "y");

        }
    }
    
}
