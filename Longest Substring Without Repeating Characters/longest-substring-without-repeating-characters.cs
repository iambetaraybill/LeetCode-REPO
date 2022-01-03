public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length <= 1) return s.Length;
        int longest = 0;
        int right, current;
        Hashtable ht = new Hashtable();
        for(int i=0; i< s.Length; i++){
         current = 0;
         for(right = i; right< s.Length; right++){
             if(!ht.ContainsValue(s[right])){
                 current++;
                 ht.Add(right,s[right]);
                 longest = Math.Max(longest, current);
                 
             }else{
                 ht.Clear();
                 break;
             }
         }
        }
        return longest;
    }
}