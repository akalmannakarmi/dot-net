// Implement the jagged array with suitable example
namespace Lab4
{
    public class Q5
    {
        public static void run(string[] args)
        {
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            Console.WriteLine("Jagged array elements:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"Array {i + 1}: ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}