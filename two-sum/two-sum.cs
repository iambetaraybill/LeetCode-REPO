
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
      
	 Dictionary<int, int> hash = new Dictionary<int, int>();
	 int numberToFind;
	 HashSet<int> hashset = new HashSet<int>();
	 int[] result = new int[] {-1,-1};
	 for(int i=0; i<nums.Length; i++){
	 if ( hash.ContainsKey(nums[i]) ){
	  return new int[]{hash[nums[i]],i};
	 }
     else{
     numberToFind = target - nums[i];
     if(hashset.Contains(numberToFind)){ continue;}
     else{
     hashset.Add(numberToFind);
	 hash.Add(numberToFind,i);
     }
	 }   
	 }  
	 return result;  
    }
}