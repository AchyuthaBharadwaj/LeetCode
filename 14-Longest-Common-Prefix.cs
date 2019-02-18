public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var retVal = string.Empty;
            var strings = strs.ToList();
        if (strings == null || strings.Count == 0)
                return retVal;

            int minLength = strings.Min(y => y.Length);

            for(int i = 0; i < minLength; i++)
            {
                bool isCommon = true;
                var cur = strings[0].ElementAt(i);
                foreach(var str in strings)
                {
                    if (!str.ElementAt(i).Equals(cur))
                    {
                        isCommon = false;
                        break;
                    }
                }
                if (isCommon)
                {
                    retVal += cur;
                }
                else
                {
                    break;
                }
            }

            return retVal;
    }
}