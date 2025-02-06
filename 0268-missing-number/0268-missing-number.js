/**
 * @param {number[]} nums
 * @return {number}
 */
var missingNumber = function(nums) {
let n =nums.length + 1;
    let total=(n*(n-1)/2);
    let numsum = nums.reduce((acc,num)=>acc+num,0);
    return total - numsum;
    
};