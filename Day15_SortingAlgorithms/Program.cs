namespace Day15_SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "ABC";
                int n = str.Length;
            UC1_StringPermutations.Permute(str, 0, n - 1);
        }
    }
}