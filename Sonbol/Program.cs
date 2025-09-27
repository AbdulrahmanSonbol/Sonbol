namespace Sonbol
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] num = new int[] {1,2,3};
            //num[0,1] = 77; 

            //Console.WriteLine(num[1]);
            //Console.WriteLine(num.Length);
            //Console.WriteLine(num.Rank);

            for (int i = 0; i < num.GetLength(0); i++)
            {
                Console.ReadLine(num[i], out int number);
            }    

            for (int i = 0; i < num.GetLength(0); i++)
            {
               for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.WriteLine(num[i,j] + " ");
                }
            }





        }
    }
}
