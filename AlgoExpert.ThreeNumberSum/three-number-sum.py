def threeNumberSum(array, targetSum):
    sorted_array = sorted(array)
    print(sorted_array)
    result = []
    lpos = 1
    rpos = len(sorted_array)-1
    for currentItem in sorted_array:
        while lpos < rpos:
            left = sorted_array[lpos]
            right = sorted_array[rpos]
            currentSum = currentItem + left + right
            print("se target igual a soma", targetSum, currentSum, currentItem, left, right)
            if targetSum == currentSum:
                result.append([currentItem, left, right])
                print(result)
            elif targetSum > currentSum:
                lpos+=1
            elif targetSum < currentSum:
                rpos-=1
    print(result)    
    pass

arrayValues = [12,3,1,2,-6,5,-8,6]
targetSumValue = 0

threeNumberSum(arrayValues,targetSumValue)

