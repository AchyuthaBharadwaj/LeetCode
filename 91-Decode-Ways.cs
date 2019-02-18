class Solution {
   public int numDecodings(String s){
		if(s == null || s.length() == 0) {
            return 0;
        }

        int[] decodeWays = new int[s.length()+1];
        decodeWays[0] = 1;
        decodeWays[1] = s.charAt(0) != '0' ? 1 : 0;
        for(int i = 2; i <= s.length(); i++) {
            int first = Integer.parseInt(s.substring(i-1, i));
            int second = Integer.parseInt(s.substring(i-2, i));
            if(first >= 1 && first <= 9) {
            	decodeWays[i] += decodeWays[i-1];  
            }
            if(second >= 10 && second <= 26) {
            	decodeWays[i] += decodeWays[i-2];
            }
        }
        return decodeWays[s.length()];
	}
}