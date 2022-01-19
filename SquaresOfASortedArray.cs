
public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] result = new int[nums.Length];
        
        int l=0, r=nums.Length-1;
		
        for(int i=nums.Length-1; i>=0; i--){
            int square=0;
            if(Math.Abs(nums[l])<Math.Abs(nums[r])){
                square = nums[r--];
            }
            else{
                square = nums[l++];
            }
            result[i] = square*square;
        }
        return result;
    }
}
