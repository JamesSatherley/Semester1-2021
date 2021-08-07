import cake

class CakePicker:
    """handles AI task of picking a piece of cake
    """

    def __init__(self, cake):
        self.cake = cake

    def pick(self):
        """pick a piece of cake and return its index
        """
        min_pick = self.cake.prev(self.cake.taken_min)
        max_pick = self.cake.taken_max

        # simple greedy approach - pick bigger piece
        if self.cake.pieces[min_pick] >= self.cake.pieces[max_pick]:
            return min_pick
        else:
            return max_pick
