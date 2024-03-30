public class Solution {
    public int MaxArea(int[] height) {
        int max = 0;
        int i = 0;
        int j = height.Length - 1;
        while (i != j){
            if(Math.Min(height[i], height[j])*Math.Abs(i-j) > max)
                max = Math.Min(height[i], height[j])*Math.Abs(i-j);
            if(height[i] <= height[j])
                i++;
            else
                j--;
        }
        return max;
    }
}