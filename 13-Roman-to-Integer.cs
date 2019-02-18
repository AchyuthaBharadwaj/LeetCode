public class Solution {
    public int RomanToInt(string s) {
       int retVal = 0;

        s = s.Replace("IX", "VIV").Replace("XC", "LXL").Replace("CM", "DCD")
            .Replace("IV", "IIII").Replace("XL", "XXXX").Replace("CD", "CCCC");

        foreach(var ch in s)
        {
            switch (ch)
            {
                case 'M': retVal += 1000; break;
                case 'D': retVal += 500; break;
                case 'C': retVal += 100; break;
                case 'L': retVal += 50; break;
                case 'X': retVal += 10; break;
                case 'V': retVal += 5; break;
                default: retVal += 1; break;
            }
        }
        return retVal; 
    }
}