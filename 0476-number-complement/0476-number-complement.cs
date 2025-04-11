public class Solution {
    public int FindComplement(int num) {
     
    string nums= Convert.ToString(num,2);
     string s="";

     for ( int i=0;i<nums.Length;i++){
        if(nums[i]=='1'){
            s+="0";
        }
        else{
            s+='1';
        }
      }
     return Convert.ToInt32(s, 2);
    

    }
}