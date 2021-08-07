import pygame, os, random, Sudoku_IO, Solver

pygame.init()
size=[660,660]
screen=pygame.display.set_mode(size)
pygame.display.set_caption("Sudoku Solver")
done=False
clock=pygame.time.Clock()

while done==False:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                done=True
            if event.type == pygame.KEYDOWN:
                if event.key == pygame.K_e:
                    easypuzzle = random.choice(os.listdir("easypuzzles"))
                    easypuzzle = "easypuzzles/" + easypuzzle
                    firstSnapshot = Sudoku_IO.loadPuzzle(easypuzzle) 
                    Solver.solve(firstSnapshot, screen)
                if event.key == pygame.K_h:
                    hardpuzzle = random.choice(os.listdir("hardpuzzles"))
                    hardpuzzle = "hardpuzzles/" + hardpuzzle
                    firstSnapshot = Sudoku_IO.loadPuzzle(hardpuzzle) 
                    Solver.solve(firstSnapshot, screen)
        clock.tick(10)
        pygame.display.flip()

pygame.quit ()