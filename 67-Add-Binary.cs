public class Solution {
    public string AddBinary(string a, string b) {
        string retVal = string.Empty;
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            while(i >= 0 || j >= 0)
            {
                if(i >= 0 && j >= 0)
                {
                    if(a.ElementAt(i) == '1' && b.ElementAt(j) == '1')
                    {
                        if(carry == 0)
                        {
                            retVal = '0' + retVal;
                            carry = 1;
                        }
                        else
                        {
                            retVal = '1' + retVal;
                            carry = 1;
                        }
                    }
                    else if((a.ElementAt(i) == '1' && b.ElementAt(j) == '0')
                        || a.ElementAt(i) == '0' && b.ElementAt(j) == '1')
                    {
                        if (carry == 0)
                        {
                            retVal = '1' + retVal;
                            carry = 0;
                        }
                        else
                        {
                            retVal = '0' + retVal;
                            carry = 1;
                        }
                    }
                    else if(a.ElementAt(i) == '0' && b.ElementAt(j) == '0')
                    {
                        if (carry == 0)
                        {
                            retVal = '0' + retVal;
                            carry = 0;
                        }
                        else
                        {
                            retVal = '1' + retVal;
                            carry = 0;
                        }
                    }
                }
                else if(i >= 0)
                {
                    if (carry == 0)
                    {
                        retVal = a.ElementAt(i) + retVal;
                        carry = 0;
                    }
                    else
                    {
                        if(a.ElementAt(i) == '1')
                        {
                            retVal = '0' + retVal;
                            carry = 1;
                        }
                        else
                        {
                            retVal = '1' + retVal;
                            carry = 0;
                        }
                    }
                }
                else if (j >= 0)
                {
                    if (carry == 0)
                    {
                        retVal = b.ElementAt(j) + retVal;
                        carry = 0;
                    }
                    else
                    {
                        if (b.ElementAt(j) == '1')
                        {
                            retVal = '0' + retVal;
                            carry = 1;
                        }
                        else
                        {
                            retVal = '1' + retVal;
                            carry = 0;
                        }
                    }
                }
                i--;
                j--;
            }

            if(carry == 1)
            {
                retVal = '1' + retVal;
            }
            return retVal;
    }
}