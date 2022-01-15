public class Solution {
    public bool IsPalindrome(int x) {
        char[] arr = x.ToString().ToCharArray();
        int left = 0;
        int right = arr.Length - 1;
        while(left < right){
            if(arr[left] != arr[right]){
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}