public class Solution {
    public int SingleNumber(int[] nums)
        {
            if (nums == null)
                return -1;

            int sum = 0;
            foreach(var item in nums)
            {
                sum ^= item;
            }

            return sum;
    }
}
