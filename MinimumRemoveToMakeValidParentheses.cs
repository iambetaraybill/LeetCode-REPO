using System.Text.RegularExpressions;
public class Solution {
    public string MinRemoveToMakeValid(string s) {
        char[] res = s.ToCharArray();
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < res.Length; i++) {
        if (res[i] == '(') {
            stack.Push(i);
        } else if (res[i] == ')' && stack.Count!= 0) {
            stack.Pop();
        } else if (res[i] == ')') {
            res[i] = '0';
        }
    }
    
    while (stack.Count != 0) {
        int curIdx = stack.Pop();
        res[curIdx] = '0';
    }
    string ans = string.Join("", res);
    return Regex.Replace(ans, @"0", ""); 
    }
}
