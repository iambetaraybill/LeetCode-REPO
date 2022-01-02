public class Solution {
    public bool BackspaceCompare(string s, string t) {
        return BuildString(s) == BuildString(t);
    }
    
    private string BuildString(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach(char c in s)
        {
            if (c == '#')
            {
                if (stack.Count > 0)
                {
                    stack.Pop();                    
                }
                continue;
            }
            
            stack.Push(c);            
        }
        
        return string.Join("", stack);
    }
}