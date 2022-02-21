"""
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.
"""
class Solution(object):
    def twoSum(self, nums, target):
        index1 = 0
        for i in nums:
            index2 = 0
            for j in nums:
                if index1 != index2:
                    if (nums[index1] + nums[index2]) == target:
                        return [index1, index2]
                index2 += 1
            index1 += 1