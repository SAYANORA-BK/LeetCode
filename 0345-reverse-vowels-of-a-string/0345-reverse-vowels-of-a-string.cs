public class Solution {
    public string ReverseVowels(string s) {
         var str = new StringBuilder();
        var l = new Stack<char>();

        foreach(var i in s){
            if("aeiouAEIOU".Contains(i))
                l.Push(i);
        }

        foreach(var i in s){
            if("aeiouAEIOU".Contains(i))
                str.Append(l.Pop());
            else
                str.Append(i);
        }
        
        return str.ToString();
    }
        
    }
