/**
 * @param {number[]} nums
 * @return {number}
 */
var findNonMinOrMax = function(nums) {
    let num= Math.min(...nums)
    let num2= Math.max(...nums)
    if(nums.length<=2){
        return -1;
    }
    for(i=0;i<=nums.length;i++){
        if(nums[i]!=num&&nums[i]!=num2){
            return nums[i];

  }
    }
    
    
};