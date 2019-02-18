public class Solution {
    public IList<string> LetterCombinations(string digits) {
        IList<string> retVal = new List<string>();
            var dict = new Dictionary<char, string>
            {
                { '2', "abc" },
                { '3', "def" },
                { '4', "ghi" },
                { '5', "jkl" },
                { '6', "mno" },
                { '7', "pqrs" },
                { '8', "tuv" },
                { '9', "wxyz" }
            };

            foreach(var digit in digits)
            {
                var cur = dict[digit].ToCharArray();
                if(retVal.Count == 0)
                {
                    foreach(var ch in cur)
                    {
                        retVal.Add(ch.ToString());
                    }
                }
                else
                {
                    var list = new List<string>();
                    foreach(var str in retVal)
                    {
                        foreach(var ch in cur)
                        {
                            list.Add(str + ch.ToString());
                        }
                    }
                    retVal = list;
                }
            }

            return retVal;
    }
}