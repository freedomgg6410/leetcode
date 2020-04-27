class NumArray:

    def __init__(self, nums: List[int]):
        self.array = [0]
        for i in nums:
            self.array.append(self.array[-1] + i)

    def sumRange(self, i: int, j: int) -> int:
        return self.array[j+1] - self.array[i]


# Your NumArray object will be instantiated and called as such:
# obj = NumArray(nums)
# param_1 = obj.sumRange(i,j)