public class Solution {
    public int MaxArea(int[] height) {
        int area = 0;
            int i = 0;
            int j = height.Length - 1;

            while (i < j)
            {
                var heightOfContainer = Math.Min(height[i], height[j]);
                var cur_area = heightOfContainer * (j - i);
                if (cur_area > area)
                    area = cur_area;
                if (height[i] > height[j])
                    j--;
                else
                    i++;
            }

            return area;
    }
}