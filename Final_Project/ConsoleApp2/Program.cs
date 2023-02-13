namespace ConsoleApp2
{
     class Program
    {




        public static long aVeryBigSum(List<long> ar)
        {
            long sum=0;
            foreach (long number in ar)
            {
                sum += number;
            }
            return sum;
        }
    
        static void Main(string[] args)
        {
            List<int> a = new List<int>{ 1,2,3,4,5};
            Console.WriteLine(compareTriplets(a));
            
        }

    }

}