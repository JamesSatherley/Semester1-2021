class Item:
    def __init__(self, weight, value):
        self.weight = weight
        self.value = value # item class file. defines item class and methods for it

    def getWeight(self):
        return self.weight

    def getValue(self):
        return self.value

    def setWeight(self, new):
        self.weight = new
        
    def setValue(self, new):
        self.value = new