public class Solution {
    public int MajorityElement(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            var length = nums.Length;
            var majority = nums[0];
            var count = 1;
            var hasMajority = true;
            for (int i = 1; i < length; i++)
            {
                var current = nums[i];
                if (hasMajority)
                {
                    if (current == majority)
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                    }

                    hasMajority = count > 0;
                }
                else
                {
                    count = 1;
                    hasMajority = true;
                    majority = nums[i];
                }
            }

            return majority;
    }
}
