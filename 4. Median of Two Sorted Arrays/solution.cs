public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] combo = new int[nums1.Length + nums2.Length];
        nums1.CopyTo(combo, 0);
        nums2.CopyTo(combo, nums1.Length);
        Array.Sort(combo);
        double result = (combo.Length % 2 == 0) ? ((combo[combo.Length/2] + combo[combo.Length/2 - 1])/2.0) : combo[combo.Length / 2];
        return result;
        }
}