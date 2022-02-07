public class Solution {
    public char FindTheDifference(string s, string t) {
      int ans=0;
        for(int i=0;i<s.Length;i++)
        {
            ans-=s[i];
            ans+=t[i];
        }
        ans+=t[s.Length];  
        return (char)ans;   
    }
}
