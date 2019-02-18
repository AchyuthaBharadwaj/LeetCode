public class Solution {
    public string IntToRoman(int num) {
        string retval = string.Empty;

            while(num > 0)
            {
                if(num >= 1000)
                {
                    retval += "M";
                    num -= 1000;
                }
                else if (num >= 500)
                {
                    retval += "D";
                    num -= 500;
                }
                else if (num >= 100)
                {
                    retval += "C";
                    num -= 100;
                }
                else if (num >= 50)
                {
                    retval += "L";
                    num -= 50;
                }
                else if (num >= 10)
                {
                    retval += "X";
                    num -= 10;
                }
                else if (num >= 5)
                {
                    retval += "V";
                    num -= 5;
                }
                else if (num >= 1)
                {
                    retval += "I";
                    num -= 1;
                }
            }

            retval = retval.Replace("IIII", "IV").Replace("XXXX", "XL").Replace("CCCC", "CD")
                .Replace("VIV", "IX").Replace("LXL", "XC").Replace("DCD", "CM");
            return retval;
    }
}