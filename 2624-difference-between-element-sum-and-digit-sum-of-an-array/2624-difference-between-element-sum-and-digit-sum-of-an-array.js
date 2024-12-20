/**
 * @param {number[]} nums
 * @return {number}
 */
var differenceOfSum = function(nums) {
    
    let sum=nums.reduce((acc,num)=>acc+num,0)
    let digit=nums.join('').split('').map(Number);
    let digitsum=digit.reduce((acc,num)=>acc+num,0);
    return sum-digitsum;
};