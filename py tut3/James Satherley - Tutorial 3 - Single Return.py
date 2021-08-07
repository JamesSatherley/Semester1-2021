someSongs = [("a large song", 60), ("a little song", 10), ("a bigger song", 20), ("a very short song", 2), ("a tiny song", 1)] # input list

def CDSolve(songsToUse, space):

    if not songsToUse or space <= 0: # base case; if song list empty or space less than or = to 0 return empty list and space
        return [], space

    option1 = CDSolve(songsToUse[1:], space) # recursive call; try not adding first song to the cd

    if songsToUse[0][1] <= space: # test if second recursion is needed
        option2 = CDSolve(songsToUse[1:], space - songsToUse[0][1]) # recursive call; try adding first call to the cd

        if option1[1] <= option2[1]: # find best choice from the two recursion calls
            bestOption = option1
        else:
            bestOption = option2[0] + [songsToUse[0]], option2[1] # set best options to the best recursion choice
    else:
        bestOption = option1

    return bestOption # return the best choice

print(CDSolve(someSongs, 22))
print(CDSolve(someSongs, 68))
print(CDSolve(someSongs, 12)) # program test statements
print(CDSolve(someSongs, 0))
print(CDSolve(someSongs, 70))