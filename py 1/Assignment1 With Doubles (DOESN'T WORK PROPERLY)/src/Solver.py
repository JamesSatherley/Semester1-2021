import pygame, Sudoku_IO

def solve(snapshot, screen):
    pygame.time.delay(20)
    Sudoku_IO.displayPuzzle(snapshot, screen)
    pygame.display.flip()

    if isComplete(snapshot): # tests if tree is complete (base case)
        return True
    else:
        clone = snapshot.clone()
        unsolved = clone.unsolvedCells() # if tree is not complete, will clone snapshot and set the current cell to the first item
        to_use = unsolved[0]
        unsolved.remove(to_use)
        clone.countPossibles(unsolved)
        checkSingletons(clone, to_use) # also calls all needed functions for pruning
        checkDoubles(clone, to_use)
        
    for i in range(1,10):
        if checkConsistency(clone, to_use, i): # if the cell is consistent clone is set to the number in range 1,10
            clone.setCellVal(to_use.getRow(), to_use.getCol(), i)
            if solve(clone, screen): # if tree is complete will return, otherwise will return false after setting to_use back to 0
                return True
            clone.setCellVal(to_use.getRow(), to_use.getCol(), 0)
    return False

def checkSingletons(snapshot, x):
    unsolved = snapshot.unsolvedCells()
    unsolved.remove(x) # checks for singletons by first removing the cell the solve function is working on to not set that and cause errors. for each item in unsolved list it will test its length, if it is only 1 long it is a singleton and gets set to itself
    for cell in unsolved:
        if len(cell.getCombos()) == 1:
            cell.setVal(cell.getCombos()[0])

def checkNotSameBlock(snapshot,cell1,cell2): # checks given cells are not in the same block
    if snapshot.cellsByBlock(cell1.getRow(),cell1.getCol()) == snapshot.cellsByBlock(cell2.getRow(),cell2.getCol()):
        return False
    return True

def checkDoubles(snapshot, x): # this function is discussed in the README docuement
    unsolved = snapshot.unsolvedCells()
    unsolved.remove(x)
    for cell in unsolved:
        for cell2 in unsolved:
            x = doubleChecks2(cell, cell2, cell.getCol(), cell2.getCol(), snapshot.cellsByRow(cell.getRow()))
            if x != None:
                cell2.getCombos().remove(x)
                print(1, checkConsistency(snapshot, cell, x), checkConsistency(snapshot, cell2, cell2.getCombos()[0]), checkNotSameBlock(snapshot, cell, cell2))
                if checkConsistency(snapshot, cell, x) and checkConsistency(snapshot, cell2, cell2.getCombos()[0]) and checkNotSameBlock(snapshot, cell, cell2):
                    print(1, x, cell2.getCombos()[0])
                    cell.setVal(x)
                    cell2.setVal(cell2.getCombos()[0])
                else:
                    cell2.getCombos().append(x)
                
            x = doubleChecks(cell, cell2, cell.getRow(), cell2.getRow(), snapshot.cellsByRow(cell.getCol()))
            if x!= None:
                cell2.getCombos().remove(x)
                print(2, checkConsistency(snapshot, cell, x), checkConsistency(snapshot, cell2, cell2.getCombos()[0]), checkNotSameBlock(snapshot, cell, cell2))
                if checkConsistency(snapshot, cell, x ) and checkConsistency(snapshot, cell2, cell2.getCombos()[0]) and checkNotSameBlock(snapshot, cell, cell2):
                    cell.setVal(x)
                    cell2.setVal(cell2.getCombos()[0])
                else:
                    cell2.getCombos().append(x)

def doubleChecks(cell1, cell2, cell1indenifier, cell2indenifier, cellsList):
    if len(cell1.getCombos()) == 2 and len(cell2.getCombos()) == 2:
        if cell1indenifier == cell2indenifier:
            for x in cell1.getCombos():
                if x in cell2.getCombos():
                    for c in cellsList:
                        if x == c.getVal():
                            return x
    return None

def doubleChecks2(cell1, cell2, cell1indenifier, cell2indenifier, cellsList):
    if len(cell1.getCombos()) == 2 and len(cell2.getCombos()) == 2:
        if cell1indenifier == cell2indenifier:
            for x in cell1.getCombos():
                if x in cell2.getCombos():
                    for c in cellsList:
                        if x == c.getVal():
                            return x
    return None

def checkConsistency(snipshot, cell, num): # check consistency function, checks if num given follows suduko rules. if true number will not be in cells row, col or block
    for i in range(9):
        if snipshot.cellsByCol(cell.getCol())[i].getVal() == num:
            return False
    for i in range(9):
        if snipshot.cellsByRow(cell.getRow())[i].getVal() == num:
            return False
    for i in range(9):
        if snipshot.cellsByBlock(cell.getRow(), cell.getCol())[i].getVal() == num:
            return False
    return True

def isComplete(snapshot): # is complete function, finds if the unsolved cells is empty
    list_of_empties = snapshot.unsolvedCells()
    if list_of_empties:
        return False
    return True