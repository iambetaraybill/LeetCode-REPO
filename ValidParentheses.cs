// using System.Collections.Generic;
public class Solution {
    public bool IsValid(string s) {
        Hashtable defined = new Hashtable();
        defined.Add('(',')');
        defined.Add('{','}');
        defined.Add('[',']');
        if(s.Length == 0) return true;
  
  Stack<char> stack = new Stack<char>();
  
  for(int i = 0; i < s.Length; i++)  {
    if(defined.ContainsKey(s[i])) {
      stack.Push(s[i]);
    } else {
      char leftBracket = stack.Count == 0? 'N' :(char)stack.Pop();
      char correctBracket = leftBracket == 'N' ? 'O' :(char)defined[leftBracket];
      if(s[i] != correctBracket) return false;
    }
  }
  
  return stack.Count == 0;
    }
}