public class Solution {
    public bool IsValid(string s) {
        var queue = new List<char>();

            foreach(var ch in s)
            {
                if(ch == '(' || ch == '{' || ch == '[')
                {
                    queue.Add(ch);
                }
                else
                {
                    if (queue.Count == 0) return false;
                    if((ch == ')' && queue.Last() == '(')
                        || (ch == ']' && queue.Last() == '[')
                        || (ch == '}' && queue.Last() == '{'))
                    {
                        queue.RemoveAt(queue.Count - 1);
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (queue.Count > 0) return false;

            return true;
    }
}