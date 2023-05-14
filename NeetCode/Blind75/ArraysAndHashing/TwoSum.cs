namespace NeetCode.Blind75.ArraysAndHashing
{
    internal class TwoSum
    {
        public static bool Solution(int[] nums, int target)
        {
            //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
            //You may assume that each input would have exactly one solution, and you may not use the same element twice.
            //You can return the answer in any order.

            var filtered = nums.Where(x => x < target).ToArray();
            if (filtered.Length == 0)
                return false;

            List<string> output = new List<string>();

            for (int i = 0; i < filtered.Length; i++)
            {
                for (int j = i + 1; j < filtered.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        string text = $"[{i},{j}] {nums[i]} + {nums[j]} == {target}";
                        output.Add(text);
                    }
                }
            }
            
            foreach (var i in output)
            {
                Console.WriteLine(i);
            
            }
            return true;
        }
    }
}
