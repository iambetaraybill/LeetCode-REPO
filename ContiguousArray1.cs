public class Solution {
    public int FindMaxLength(int[] nums) {
      Dictionary<int, int> sums = new Dictionary<int,int>();
        sums.Add(0,0);
        int max = 0; int sum = 0; int index = 0;
        for(int i =0 ;i<nums.Length; i++){
            if(nums[i] == 0){
                sum -= 1;
            }
            else
            {
                sum += 1;
            }
            index = i + 1;
            
            if(sums.ContainsKey(sum)){
                max = Math.Max(max, (index - sums[sum]));
            }
            else
            {
                sums.Add(sum, index);
            }
        }
        
        return max;
    }
}
