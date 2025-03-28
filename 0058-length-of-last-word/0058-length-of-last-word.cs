public class Solution {
    public int LengthOfLastWord(string s) {
        string[] strArr = s.Trim().Split(" ");
        return strArr[strArr.Length - 1].Trim().Length;
        
    }
}