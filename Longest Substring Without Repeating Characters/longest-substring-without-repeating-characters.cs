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

//Optimal js solution
// var lengthOfLongestSubstring = function(s) {
//      if(s.length <= 1) return s.length;
    
//     const seen = {};
//     let left = 0, longest = 0;
    
//     for(let right = 0; right < s.length; right++) {
//         const currentChar = s[right];
//         const previouslySeenChar = seen[currentChar];
        
//         if(previouslySeenChar >= left) {
//           left = previouslySeenChar + 1;
//         }
        
//         seen[currentChar] = right;
        
//         longest = Math.max(longest, right - left + 1);
//     }
    
//     return longest;
// };