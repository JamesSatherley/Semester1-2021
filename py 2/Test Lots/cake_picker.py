import cake
import random

class CakePicker:
    """handles AI task of picking a piece of cake
    """

    def __init__(self, cake):
        self.cake = cake

    def generateCache(self,l):
        cache = []
        for i in range(len(l)-1):
            cache.append([])
            for j in range(len(l)-1):
                cache[i].append(0)
        return cache

    def findRemaining(self, mp):
        i = mp
        pieces = []
        while not self.cake.is_taken(i):
            pieces.append(self.cake.pieces[i])
            i = self.cake.next(i)
        return pieces

    def picker(self, cake, matrix, x, y):
        if matrix[x][y] > 0:
            return matrix[x][y]
        if x == y:
            print(x, y, cake)
            matrix[x][y] = cake[y]
            return matrix[x][y]
        if y == x+1:
            matrix[x][y] = max(cake[x], cake[y])
            return matrix[x][y]
        maxed = min(cake[x] + min(self.picker(cake, matrix, x+2, y), self.picker(cake, matrix, x+1, y-1)),
                    cake[y] + min(self.picker(cake, matrix, x+1, y-1), self.picker(cake, matrix, x, y-2)))
        matrix[x][y] = maxed
        return maxed

    def pick(self):
        min_pick = self.cake.prev(self.cake.taken_min)
        max_pick = self.cake.taken_max
        l = self.findRemaining(max_pick)
        if len(l) < 2:
            if min_pick < max_pick:
                return max_pick
            else:
                return min_pick
        else:
            m = self.generateCache(l)
            x = self.picker(l[1:], m, 0, len(l)-2)
            m = self.generateCache(l)
            y = self.picker(l[:-1], m, 0, len(l)-2)
            if x < y:
                return max_pick
            elif y < x:
                return min_pick
            else:
                return random.choice([max_pick, min_pick])