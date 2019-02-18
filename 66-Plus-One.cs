public class Solution {
    public int[] PlusOne(int[] digits) {
        int i = 1;
            digits[digits.Length - i] += 1;
            while (i != digits.Length && digits[digits.Length - i] >= 10)
            {
                digits[digits.Length - i] -= 10;
                digits[digits.Length - i - 1] += 1;
                i++;
            }
            int[] retVal;
            int pos;
            if(digits[0] >= 10)
            {
                retVal = new int[digits.Length + 1];
                retVal[0] = 1;
                digits[0] -= 10;
                pos = 1;
            }
            else
            {
                retVal = new int[digits.Length];
                pos = 0;
            }
            
            for(i = 0; i< digits.Length; i++)
            {
                retVal[pos++] = digits[i];
            }

            return retVal;
    }
}