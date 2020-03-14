class MyStack:
    
    
    
    def __init__(self):
        """
        initialize your data structure here.
        """
        self.stack = []

    def push(self, x):
        """
        :type x: int
        :rtype: nothing
        """
        self.stack.insert(0, x)
        for i in range(len(self.stack)-1):
            self.stack.insert(0, self.stack[-1])
            self.stack.pop()

    def pop(self):
        """
        :rtype: nothing
        """
        #直接把最後一個元素彈出即可，不需要再append了，所以是len()-1
        for i in range(len(self.stack)-1):
            self.stack.append(self.stack.pop(0))
        return self.stack.pop(0)

    def top(self):
        """
        :rtype: int
        """
        return self.stack[-1]

    def empty(self):
        """
        :rtype: bool
        """
        return not self.stack

    
# Your MyStack object will be instantiated and called as such:
# obj = MyStack()
# obj.push(x)
# param_2 = obj.pop()
# param_3 = obj.top()
# param_4 = obj.empty()