public class Solution {
    public int CountPrimeSetBits(int L, int R) {
        int count = 0;

            for(int i = L; i<= R; i++)
            {
                var binaryString = Convert.ToString(i, 2);
                var numberOfSetBits = 0;
                binaryString.ToCharArray().ToList().ForEach(x => numberOfSetBits += x == '1' ? 1 : 0);
                var isNumSetBitsPrime = true;
                for(int j = 2; j<=numberOfSetBits/2; j++)
                {
                    if(numberOfSetBits%j == 0)
                    {
                        isNumSetBitsPrime = false;
                    }
                }
                if (isNumSetBitsPrime && numberOfSetBits > 1) { count++; }
                
            }

            return count;
    }
}