public class Solution {
    public int SingleNumber(int[] nums) {
        int p1 = 0;
        int p2 = 1;
        int res = 0;
        if(nums.Length == 0){return nums.Length;}
        else if(nums.Length == 1){return nums[0];}
        while(p2 < nums.Length){
            res = (p1 == 0 ? nums[p1] : res) ^ nums[p2]; // XOR approach
            p1++;
            p2++;
        }
        return res;
    }
}
