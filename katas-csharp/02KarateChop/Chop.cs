namespace katas_csharp._02KarateChop
{
    public class Chop
    {
        public int Run(int target, int[] sortedArray)
        {
            if (sortedArray.Length == 0) return -1;
            if (sortedArray[0] != target) return -1;

            return sortedArray[0];
        }
    }
}
