class cell:
    def __init__(self, row, col, val, combos):
        self.row = row
        self.col = col
        self.val = val
        self.combos = combos # Added list of possible combonations and setters and getters
        
    def getRow(self):
        return self.row
    
    def setRow(self, row):
        self.row = row
        
    def getCol(self):
        return self.col
    
    def setCol(self, col):
        self.col = col
        
    def getVal(self):
        return self.val
    
    def setVal(self, val):
        self.val = val  
        
    def getCombos(self):
        return self.combos
    
    def setCombos(self, combos):
        self.combos = combos  
        
    def clone(self): 
        return cell(self.row, self.col, self.val, self.combos)