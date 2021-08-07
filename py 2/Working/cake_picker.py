import cake
import random

class CakePicker:
    def __init__(self, cake):
        self.cake = cake                             # cake is defined as input in init

    def generateCache(self,l):                             # generates cash that is n^2 to store possible minimums. List of lists containing 0's
        cache = []
        for i in range(len(l)-1):
            cache.append([])
            for j in range(len(l)-1):
                cache[i].append(0)
        return cache

    def findRemaining(self, mp):                             # find remaining non eaten cake pieces
        i = mp
        pieces = []
        while not self.cake.is_taken(i):
            pieces.append(self.cake.pieces[i])
            i = self.cake.next(i)
        return pieces

    def picker(self, cake, matrix, x, y):
        if matrix[x][y] > 0:
            return matrix[x][y]                             # defines base cases for if already found, if indexes are equal and one to add to cache
        if x == y:
            print(x, y, cake)
            matrix[x][y] = cake[y]
            return matrix[x][y]
        if y == x+1:
            matrix[x][y] = max(cake[x], cake[y])
            return matrix[x][y]
        maxed = min(cake[x] + min(self.picker(cake, matrix, x+2, y), self.picker(cake, matrix, x+1, y-1)),                             # lastly recursive call, this is adding the cake item and the min of two more calls, one less and one more in the cache index
                    cake[y] + min(self.picker(cake, matrix, x+1, y-1), self.picker(cake, matrix, x, y-2)))                             # I AM FINDING THE MINIMUM BECAUSE I AM FINDING ALL POSSIBLE MOVES OF THE PLAYER. I AM THEN THEIR LOWEST AMOUNT OF POINTS AND TRYING TO PLAY SO THEY GET THAT, MINIMISING THEIR WINNINGS AND MAXIMISING MY OWN
        matrix[x][y] = maxed
        return maxed                             #finally set to cache and return variable

    def pick(self):
        min_pick = self.cake.prev(self.cake.taken_min)                             # defines min and max index based on user input
        max_pick = self.cake.taken_max
        l = self.findRemaining(max_pick)                             # finds remaining non eaten cake pieces
        if len(l) < 2:
            if min_pick < max_pick:                             # if the length of remaining non eaten pieces is less than 2 it will cause errors, so i use greedy method
                return max_pick
            else:
                return min_pick
        else:
            m = self.generateCache(l)                             # otherwise generate caches for each recrusive call
            x = self.picker(l[1:], m, 0, len(l)-2)
            m = self.generateCache(l)
            y = self.picker(l[:-1], m, 0, len(l)-2)
            if x < y:                             #if y bigger, return max
                return max_pick
            elif y < x:                             # if x bigger, return min
                return min_pick
            else:                             # otherwise do a random choice (when theyre equal)
                return random.choice([max_pick, min_pick])