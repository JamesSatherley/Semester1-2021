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
        clone.countPossibles(unsolved) # also calls all needed functions for pruning
        checkSingletons(clone, to_use)        
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