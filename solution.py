class Solution:
    def arraySign(self, nums):
        pos = True
        for n in nums:
            if n == 0: return 0
            if n < 0: pos = not pos
        
        if pos: return 1
        else: return -1
