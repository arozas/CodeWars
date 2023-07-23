namespace RemoveDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    public static class Kata
    {
        public static int[] distinct(int[] a)
        {
            HashSet<int> uniquesNums = new HashSet<int>();
            List<int> result = new List<int>();

            foreach (int number in a)
            {
                if (!uniquesNums.Contains(number))
                {
                    uniquesNums.Add(number);
                    result.Add(number);
                }
            }
            return result.ToArray();
        }
    }

}