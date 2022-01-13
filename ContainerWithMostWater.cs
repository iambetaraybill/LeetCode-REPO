public class Solution {
    public int MaxArea(int[] height) {
        int p1 = 0;
        int p2 = height.Length - 1;
        int max=0, ht, width, area;
        
        while(p1< p2){
            ht = Math.Min(height[p1],height[p2]);
            width = p2 - p1;
            area = ht * width;
            max = Math.Max(max, area);
            if(height[p1] <= height[p2]){
                p1++;
            }else{
                p2--;
            }
        }
        return max;
    }
}