/**
 * @param {number[]} nums
 * @return {number}
 */
var singleNumber = function(nums) {
    
    let map = new Map();
    let ans;
    for(let i=0;i<nums.length;i++){
        map.set(nums[i],(map.get(nums[i])||0)+1);
    }
    map.forEach((val,key)=>{
        if(val==1){
            ans = key;
        }
    })
    return ans;
};