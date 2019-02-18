public class Solution {
    public int NumJewelsInStones(string J, string S) {
        int count = 0;

        for(int i = 0; i<J.Length; i++)
        {
            var c = J.ElementAt(i);
            count += S.Count(x => x == c);
        }

        return count;
    }
}