public class Solution {
    public int Reverse(int x) {
        int sign = 1;
        var sb = new StringBuilder();
        if(x < 0)
            sign = -1;

        long num = Math.Abs((long)x);
        while(num > 0){
            sb.Append(num % 10);
            num = num / 10;
        }
        string str = sb.ToString();
        long result = 0;
        if(long.TryParse(str, out result))
            if(result > int.MaxValue || result < int.MinValue)
                return 0;
            else return (int)result*sign;
        else return 0;
    }
}