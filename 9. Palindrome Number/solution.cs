public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0)
            return false;
        
        string xStr = x.ToString();
        string reverseString = new string(xStr.Reverse().ToArray());
        if(xStr == reverseString)
            return true;
        else
            return false;
    }
}