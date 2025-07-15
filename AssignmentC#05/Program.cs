namespace AssignmentC_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question019

            int size;
            do
            {
                Console.Write("Enter the size of the identity matrix : ");
            }
            while (!int.TryParse(Console.ReadLine(), out size));
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
