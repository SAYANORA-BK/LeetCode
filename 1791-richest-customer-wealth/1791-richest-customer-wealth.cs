public class Solution {
    public int MaximumWealth(int[][] accounts) {
        
        return accounts.Select(account=>account.Sum()).Max();
    }
}