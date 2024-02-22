public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrEmpty(s))
            return 0;

        string unic = "";
        int result = 1;

        for (int i = 0; i < s.Length; i++)
        {
            int index = unic.IndexOf(s[i]);
            if (index != -1){
                unic = unic.Substring(index + 1);
                unic += s[i].ToString();
            }
            else{
                unic += s[i].ToString();
                if (result < unic.Length)
                    result = unic.Length;
            }
        }
        return result;
    }
}