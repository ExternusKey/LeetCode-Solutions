public class Solution {
    public int MyAtoi(string s) {
        s = s.Trim();
        int sign = 1;
        int startIndex = 0;

        if (s.Length == 0) 
            return 0;

        if (s[0] == '-' && s.Length>1){
            sign = -1;
            startIndex = 1;
        }    
        else if (s[0] == '+' && s.Length>1)
            startIndex = 1;
        else if (!char.IsDigit(s[0])) 
            return 0;

        return Compilation(s,sign,startIndex);    
    }

    public int Compilation (string s, int sign, int startIndex){
        List<char> result = new List<char>();

        if(!char.IsDigit(s[startIndex]))
            return 0;

        for (int i = startIndex; i < s.Length; i++)
            if(char.IsDigit(s[i]))
                result.Add(s[i]);
            else 
                break;

        if (long.TryParse(new string(result.ToArray()), out long number)){
            if (number*sign > int.MaxValue) 
                return int.MaxValue;
            if (number*sign < int.MinValue) 
                return int.MinValue;
            
            return (int)(number * sign);
        } 
        else if (sign == -1)
            return int.MinValue;
        else 
            return int.MaxValue;
    }
}