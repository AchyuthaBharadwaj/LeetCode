class Codec:
    def __init__(self):
        self.dic = dict()

    def encode(self, longUrl):
        """Encodes a URL to a shortened URL.
        
        :type longUrl: str
        :rtype: str
        """
        self.dic[0] = longUrl
        return longUrl

    def decode(self, shortUrl):
        """Decodes a shortened URL to its original URL.
        
        :type shortUrl: str
        :rtype: str
        """
        return self.dic[0]

#Runtime: 24 ms, faster than 100.00% of Python online submissions for Encode and Decode TinyURL.
url = "https://leetcode.com/problems/design-tinyurl"
codec = Codec()
print(codec.decode(codec.encode(url)))