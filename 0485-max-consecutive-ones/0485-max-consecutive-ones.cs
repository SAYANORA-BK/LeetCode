public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        
         int counter = 0;
        int maxCount = 0;
        for(int i = 0; i < nums.Length; i ++){
            if(nums[i] == 1){
                counter++;
                if(counter > maxCount){
                    maxCount = counter;
                }
            }
            else{
                counter = 0;
            }
        }

        return maxCount;
   
    }
}