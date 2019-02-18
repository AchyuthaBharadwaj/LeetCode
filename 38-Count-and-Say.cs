class Solution {
    public String countAndSay(int n){
		if(n == 0) return "";
		StringBuilder result = new StringBuilder("1");
		
		while(n > 1){	
			StringBuilder current = new StringBuilder();
			int count = 1;
			for(int i=0; i<result.length(); i++){		
				if(i+1<result.length() && result.charAt(i) == result.charAt(i+1)){
					count++;
				}
				else{
					current.append(count);
					current.append(result.charAt(i));
					count = 1;
				}
			}			
			result = current;
			n--;
		}
		
		return result.toString();
	}
}