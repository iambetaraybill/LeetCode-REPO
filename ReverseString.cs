public class Solution {
    public void ReverseString(char[] s) {
        int p1 = 0;
        int p2 = s.Length - 1;
        
        while(p1 < p2){
            s[p1] = (char)((int)s[p1] + (int)s[p2]);
        s[p2] = (char)((int)s[p1] - (int)s[p2]);
        s[p1] = (char)((int)s[p1] - (int)s[p2]);
            p1++;
            p2--;
        }
    }
}
