public class Solution {
    public bool DetectCapitalUse(string word) {
        if(word == null) return false;
		// count uppercase
        int ucount = 0;
		// check if lowercase letter already exists
        bool l = false;
        for(int i = 0; i < word.Length; i ++){
            if(i > 0 && l){
                if(Char.IsUpper(word[i])) return false;
            }
            if(ucount > 1 && Char.IsLower(word[i])) return false;
            if(Char.IsUpper(word[i])){
                ucount ++;
            }
            else{
                l = true;
            }
        }
        return true;
    }
}
