def threeNumberSum(array, targetSum):
    sorted_array = sorted(array)
    print(sorted_array)
    result = []
    for currentItem in sorted_array:
        lpos = sorted_array.index(currentItem)+1
        print("sorted_array.index(currentItem)", sorted_array.index(currentItem))
        rpos = len(sorted_array)-1
        print(currentItem)
        while lpos < rpos:
            left = sorted_array[lpos]
            right = sorted_array[rpos]
            print('left', left)
            print('right', right)
            currentSum = currentItem + left + right
            print("se target igual a soma", targetSum, currentSum, currentItem, left, right)
            if targetSum == currentSum:
                result.append([currentItem, left, right])
                lpos+=1
                print("resultado", result)
            elif targetSum > currentSum:
                lpos+=1
                print("maior", targetSum, currentSum, lpos)
            elif targetSum < currentSum:
                rpos-=1
                print("menor", targetSum, currentSum, rpos)
    print(result)    
    return result
    pass

arrayValues = [12,3,1,2,-6,5,-8,6]
targetSumValue = 0

resultado = threeNumberSum(arrayValues,targetSumValue)
print(resultado)    

