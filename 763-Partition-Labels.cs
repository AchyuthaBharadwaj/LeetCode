public class Solution {
    public IList<int> PartitionLabels(string S) {
        var res = new List<int>();
            var tmp = S;
           
            while(tmp != string.Empty)
            {
                var charArry = tmp.ToCharArray().ToList();
                int partEnd = tmp.LastIndexOf(charArry[0]);
                for(int i = 1; i<partEnd; i++)
                {
                    int newEnd = tmp.LastIndexOf(charArry[i]);
                    if (newEnd > partEnd) partEnd = newEnd;
                }
                tmp = tmp.Substring(partEnd+1, tmp.Length - partEnd -1);
                res.Add(partEnd+1);
            }

            return res;
    }
}