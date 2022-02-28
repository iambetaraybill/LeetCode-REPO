public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        
        List<string> res = new List<string>();
        if(nums == null || nums.Length == 0)
            return res;
        
        for(int i = 0; i < nums.Length; i++)
        {
            int start = nums[i];
            
            while(i + 1 < nums.Length && nums[i + 1] - nums[i] == 1)
                i++;
            
            string range = nums[i] == start? start.ToString() : start + "->" + nums[i];
            
            res.Add(range);
        }
        
        return res;
    }
}
