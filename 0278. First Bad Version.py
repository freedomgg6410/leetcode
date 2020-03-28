# The isBadVersion API is already defined for you.
# @param version, an integer
# @return a bool
# def isBadVersion(version):

class Solution:
    def firstBadVersion(self, n):
        """
        :type n: int
        :rtype: int
        """
        min = 0 
        max = n 
        

        
        while max > min:
            mid = min + int((max-min)/2) 
            if isBadVersion(mid):
                max = mid
            else:
                min = mid+1
            
        

        return max