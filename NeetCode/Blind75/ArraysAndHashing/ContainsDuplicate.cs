namespace NeetCode.Blind75.ArraysAndHashing
{
    //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct
    public class ContainsDuplicate
    {
        private static int[] nums = new int[10];
        private static int counter = 0;
        private static Random Random = new Random();

        public static bool HardWay()
        {
            PopulateNums();

            for (int i = 0; i < nums.Length; i++)
            {
                int number = nums[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    if (counter >= 2)
                        return true;

                    else if (nums[j].Equals(number))
                        counter++;
                }

                counter = 0;
            }
            return false;
        }

        public static bool EasyWay()
        {
            PopulateNums();

            Console.WriteLine("\n");

            var numsList = nums.ToList();
            foreach (var n in numsList)
            {
                if (numsList.FindAll(x => x.Equals(n)).Count >= 2)
                    return true;
            }
            return false;
        }

        private static void PopulateNums()
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Random.Next(5);
                Console.Write($"{nums[i]} ");
            }
        }
    }
}