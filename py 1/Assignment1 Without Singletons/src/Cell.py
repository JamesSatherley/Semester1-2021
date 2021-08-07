class cell:
    def __init__(self, row, col, val):
        self.row = row
        self.col = col
        self.val = val
        
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
        
    def clone(self): 
        return cell(self.row, self.col, self.val)