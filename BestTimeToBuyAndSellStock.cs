public class Solution {
   public int MaxProfit(int[] p)
{
    if (p == null || p.Length < 2) return 0;
    int min = p[0], max = p[0], preGain = 0;
    for (int i = 1; i < p.Length; i++)
        if (p[i] < min)
        {
            if (max - min > preGain)
                preGain = max - min;
            min = p[i];
            max = p[i];
        }
        else if (p[i] > max)
            max = p[i];
    return preGain > max - min ? preGain : max - min;
}
}
