public class Solution {
    public bool RotateString(string A, string B) {
        for(int i=0; i<A.Length; i++)
            {
                if (A.Equals(B)) return true;
                A = A.Substring(1) + A.Substring(0, 1);
            }
            return false;
    }
}