using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {

  if(s.Length <= 1) return true;
  string lowerCase = Regex.Replace(s, @"[^A-Za-z0-9]", "").ToLower();
  Console.WriteLine(lowerCase);
        // string rev ="";
  int left = 0, right = lowerCase.Length - 1;
        while(left < right){
            if(lowerCase[left] != lowerCase[right]){
                return false;
            }
            left++;
            right--;
        }
  
    return true;
  // Solution 2      
//          for(int i = s.Length - 1; i >= 0; i--) {
//         rev += s[i];
//     }

//     return rev == s;

//     }

// Solution 3
//         int left = (int)Math.Floor((double)(s.Length / 2)), right = left;

//     if(s.Length % 2 == 0) {
//         left--;
//     }
    
//     while(left >= 0 && right < s.Length) {
//         if(s[left] != s[right]) {
//             return false;
//         }
        
//         left--;
//         right++;
//     }
    
//     return true;
    }
}