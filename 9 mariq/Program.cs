namespace _9_mariq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  5x20


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1)
                    {
                        if (j == 0 || j == n - 1)
                        {
                            Console.Write("+ ");
                        }
                        else
                        {
                            Console.Write("- ");
                        }
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
