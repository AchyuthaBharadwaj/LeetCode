public class Solution {
    public string ReorganizeString(string S) {
        string res = "";
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach(char c in S)
            {
                if(dict.Any(x => x.Key == c.ToString()))
                {
                    dict[c.ToString()] += 1;
                }
                else
                {
                    dict.Add(c.ToString(), 1);
                }
            }
            dict.OrderBy(x => x.Value);
            List<string> keys = new List<string>(dict.Keys);
            while (!dict.All(x => x.Value == 0))
            {                
                foreach (string key in keys)
                {
                    if(dict[key] > 0)
                    {
                        if(res.Length == 0)
                        {
                            res += key;
                            dict[key]--;
                        }
                        else if(res.Length == 1)
                        {
                            if (key == res) return "";
                            res += key;
                            dict[key]--;
                        }
                        else
                        {
                            if (res.ElementAt(0).ToString() != key)
                            {
                                res = key + res;
                                dict[key]--;
                            }
                            else if (res.ElementAt(res.Length-1).ToString() != key)
                            {
                                res += key;
                                dict[key]--;
                            }
                            else
                            {
                                bool flag = false;
                                for (int i = 0; i < res.Length - 1; i++)
                                {
                                    var m = res.ElementAt(i).ToString();
                                    var n = res.ElementAt(i + 1).ToString();
                                    if (m != key && n != key)
                                    {
                                        res = res.Insert(i+1, key);
                                        dict[key]--;
                                        flag = true;
                                        break;
                                    }
                                }
                                if (!flag) { return ""; }
                            }                            
                        }
                    }
                }                
            }

            return res;
    }
}