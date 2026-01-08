public class Solution {
    public int ArraySign(int[] nums) {
        bool pos = true;
        foreach(int n in nums){
            if(n == 0) return(0);
            if(n < 0) pos = !pos;
        }

        if(pos) return(1);
        else return(-1);
    }
}
