import Cell

class snapshot:
    def __init__(self):
        self.rows = 9
        self.columns = 9
        self.cells = []
        for row in range(9):
            self.cells.append([])
            for column in range(9):
                self.cells[row].append(Cell.cell(row, column, 0, []))

    def countPossibles(self, l): # function which computes possible numbers in each empty spot
        for cell in l:
            possible = [1,2,3,4,5,6,7,8,9]
            row, col = cell.getRow(), cell.getCol()
            colcells, rowcells, blockcells = self.cellsByCol(col), self.cellsByRow(row), self.cellsByBlock(row, col)
            for i in range(9):
                if colcells[i].getVal() in possible:
                    possible.remove(colcells[i].getVal()) # looks in row,col,block from a cell for range of 9 and if the number isnt in any it will not be removed from possible. possible is then set to the cells combos
                if rowcells[i].getVal() in possible:
                    possible.remove(rowcells[i].getVal())
                if blockcells[i].getVal() in possible:
                    possible.remove(blockcells[i].getVal())
            cell.setCombos(possible)

    def setCellVal(self, i, j, val):
        self.cells[i][j].setVal(val)
        
    def getCellVal(self, i,j):
        return self.cells[i][j].getVal()
    
    def cellsByRow(self,row):
        return self.cells[row]
    
    def cellsByCol(self,col):
        column = []
        for row in range(9):
            column.append(self.cells[row][col])
        return column
    
    def cellsByBlock(self, row, col):
        block = []
        for i in range(9):
            for j in range(9):     
                if (i//3 == row//3) and (j//3 == col//3):
                    block.append(self.cells[i][j])
        return block
    
    def unsolvedCells(self):
        unsolved = []
        for row in range(9):
            for col in range(9):
                if self.cells[row][col].getVal() == 0 :
                    unsolved.append(self.cells[row][col])
        return unsolved
        
    def clone(self):
        clone = snapshot()
        for row in range(9):
            for col in range(9):
                clone.setCellVal(row,col,self.getCellVal(row,col))
        return clone