namespace AssignmentC_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question019

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
            int size;
            do
            {
                Console.Write("Enter The Size of the Array: ");
            }
            while (!int.TryParse(Console.ReadLine(), out size));
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                do
                {
                    Console.Write($"Enter the Element {i + 1} : ");
                }
                while (!int.TryParse(Console.ReadLine(), out arr[i]));
            }
            int sum = 0;
            for (int j = 0; j < size; j++)
            {
                sum += arr[j];
            }
            Console.WriteLine($"The Sum of the Array is : {sum}");
            #endregion
        }
    }
}
