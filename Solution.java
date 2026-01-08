class Solution {
    public int arraySign(int[] nums) {
        boolean pos = true;
        for(int n : nums){
            if(n == 0) return(0);
            if(n < 0) pos = !pos;
        }

        if(pos) return(1);
        else return(-1);
    }
}
