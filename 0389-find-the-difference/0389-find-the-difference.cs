public class Solution {
    public char FindTheDifference(string s, string t) {
        return (s + t).GroupBy(x => x).Where(x => x.Count() % 2 == 1).Select(c => c.Key).ToList()[0];
    }
}