namespace AssignmentC_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question19

            //int size;
            //do
            //{
            //    Console.Write("Enter the size of the identity matrix : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out size));
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Question20
            //int size;
            //do
            //{
            //    Console.Write("Enter The Size of the Array: ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out size));
            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter the Element {i + 1} : ");
            //    }
            //    while (!int.TryParse(Console.ReadLine(), out arr[i]));
            //}
            //int sum = 0;
            //for (int j = 0; j < size; j++)
            //{
            //    sum += arr[j];
            //}
            //Console.WriteLine($"The Sum of the Array is : {sum}");
            #endregion
            #region Question21
            //int[] firstArr = { 9, 6, 4, 5, 2 };
            //int[] secondArr = { 3, 7, 8, 1, 10 };
            //int[] mergedArr = new int[firstArr.Length + secondArr.Length];
            //mergedArr = firstArr.Concat(secondArr).ToArray();
            //Array.Sort(mergedArr);
            //foreach (int item in mergedArr)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion
            #region Question22
            //int size;
            //do
            //{
            //    Console.Write("Enter Size Of Array: ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out size));
            //int [] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter The Element {i + 1} : ");
            //    }
            //    while (!int.TryParse(Console.ReadLine(), out arr[i]));
            //}
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            Console.WriteLine($"Duplicate Element = {arr[i]}");
            //        }
            //    }
            //}
            #endregion
            #region Question23
            //int size;
            //do
            //{
            //    Console.Write("Enter Size Of Array: ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out size)  || size <= 0);
            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter The Element {i + 1} : ");
            //    }
            //    while (!int.TryParse(Console.ReadLine(), out arr[i]));
            //}
            //int max = arr[0];
            //int min = arr[0];
            //for (int i = 1; i < size; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine($"Maximum Number : {max}");
            //Console.WriteLine($"Minimum Number : {min}");
            #endregion
            #region Question24
            int size;
            int repetedNumber = 0;
            do
            {
                Console.Write("Enter the Size of the array: ");
            }
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0);
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                do
                {
                    Console.Write($"Enter Element {i + 1}: ");
                }
                while (!int.TryParse(Console.ReadLine(), out numbers[i]));
            }
            int maxDistance = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (numbers[i] == numbers[j])
                    {
                        int distance = j - i;
                        if (maxDistance < distance)
                        {
                            maxDistance = distance;
                        }
                        repetedNumber = numbers[i];
                    }
                }
            }
            Console.WriteLine($"Max Distance is = {maxDistance} , Number Of Element: {repetedNumber} ");
            #endregion
        }
    }
}
