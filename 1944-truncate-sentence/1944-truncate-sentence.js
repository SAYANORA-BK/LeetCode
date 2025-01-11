/**
 * @param {string} s
 * @param {number} k
 * @return {string}
 */
var truncateSentence = function(s, k) {
 let str=s.split(" ")
 let str1=[]
 for(i=0;i<k;i++){
    str1[i]=str[i]
 }

 return str1.join(" ")
};