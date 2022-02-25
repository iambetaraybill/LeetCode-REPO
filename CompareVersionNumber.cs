public class Solution
    {
        public int CompareVersion(string version1, string version2)
        {
            int[] version1Parts = version1.Split(new []{'.'}, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
            int[] version2Parts = version2.Split(new[] {'.'}, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

            int i = 0;
            int j = 0;

            while (i < version1Parts.Length || j < version2Parts.Length)
            {
                int cur1 = (i < version1Parts.Length ? version1Parts[i] : 0);
                int cur2 = (j < version2Parts.Length ? version2Parts[j] : 0);

                int cmp = cur1.CompareTo(cur2);

                if (cmp != 0)
                {
                    return cmp;
                }

                i++;
                j++;
            }

            return 0;
        }
    }
