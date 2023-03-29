def threeNumberSum(array, targetSum):
    result = []
    cs = 0
    lpos = 1
    rpos = len(array)-1
    left = array[lpos]
    right = array[rpos]
    for currentItem in array:
        if targetSum == (currentItem + left + right):
            result.append([currentItem, left, right])
            print(result)
        
        
    pass