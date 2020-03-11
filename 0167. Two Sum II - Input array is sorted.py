class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        l = len(numbers)
        a = {}
        for i in range(l):
            sub = target - numbers[i]
            if numbers[i] in a:
                return a[numbers[i]]+1, i+1
            else:
                a[sub] = i