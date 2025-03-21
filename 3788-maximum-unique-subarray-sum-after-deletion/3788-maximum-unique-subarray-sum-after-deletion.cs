public class Solution {
    public int MaxSum(int[] nums) {
        if(nums.Length == 1)
            return nums[0];

        var h = new HashSet<int>(nums);
        var l = h.ToList();
        var rs = new HashSet<int>();

        if(l.Max() <= 0)
            return l.Max();

        while(l.Min() < 0)
            l.Remove(l.Min());
        
        for(var i = 0; i < l.Count; i++){
            var cur = l[i];
            rs.Add(cur);
            for(var j = i + 1; j < l.Count; j++){
                cur += l[j];
                rs.Add(cur);
            }
        }
        return rs.Max();
    }
}