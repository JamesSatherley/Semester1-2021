import pygame
import random

black    = (   0,   0,   0)
white    = ( 255, 255, 255)
green    = (   0, 255,   0) # Define some colors
red      = ( 255,   0,   0)
yellow   = ( 255, 255,   0)

pygame.init() # Initialize pygame
size=[1000,1000] # Set the height and width of the screen
screen=pygame.display.set_mode(size)
screen.fill(white) # Set the screen background

pygame.display.set_caption("Random Maze") # Set title of screen
mazegrid=[] # Create a 2 dimensional array. A two dimensional array in our implementation is simply a list of lists. Each cell corresponds to a 5 pixel x 5 pixel area of the screen surface.
cheeseflag = True
count = 0
minimum_maze_size = 25 # in cells of 5 pixels

def clearMazegrid(empty): # function to clear the maze so you can click 'm' over and over
    empty = []
    for row in range(200):
        empty.append([]) # Add an empty array that will hold each cell in this row
        for column in range(200):
            empty[row].append(0) # Append a cell
    return empty

def GenerateMaze(): # function to generate the maze using addwalls()
    screen.fill(white) # empties the screen in case generate maze has already been called
    pygame.draw.rect(screen, black, [0, 0, 1000, 5])
    pygame.draw.rect(screen, black, [0, 0, 5, 1000])
    pygame.draw.rect(screen, black, [995, 0, 5, 1000]) # draws outside lines and top left door in
    pygame.draw.rect(screen, black, [0, 995, 1000, 5])
    pygame.draw.rect(screen, white, [0, 0, 15, 15])

    AddWalls(mazegrid, [[1,1],[200,200]], False) # call the first iteration of AddWalls()

def AddWalls(mazegrid, roomcoords, cheeseflag): # function to create rooms in side of the previous
    if roomcoords[1][0] - roomcoords[0][0] >= minimum_maze_size and roomcoords[1][1] - roomcoords[0][1] >= minimum_maze_size: # tests if the to-be room will be big enough
        x = random.randrange(roomcoords[0][0]+10, roomcoords[1][0]-10) # generates the random x, y values to be the center of the four rooms
        y = random.randrange(roomcoords[0][1]+10, roomcoords[1][1]-10)
        for i in range(roomcoords[1][0] - roomcoords[0][0]):
            mazegrid[roomcoords[0][0]+i][y] = 1 
        for i in range(roomcoords[1][1] - roomcoords[0][1]): # adds the '1' in the mazegrid for the range of each line
            mazegrid[x][roomcoords[0][1]+i] = 1 
        mazegrid[x][y] = 2 # adds '2' for the center so can make a door
        AddWalls(mazegrid, [roomcoords[0],[x,y]], False) # top left recursive call
        AddWalls(mazegrid, [[x,roomcoords[0][1]],[roomcoords[1][0], y]], False) # top right recursive call
        AddWalls(mazegrid, [[roomcoords[0][0],y],[x,roomcoords[1][1]]], False) # bottom left recursive call
        AddWalls(mazegrid, [[x,y],roomcoords[1]], False) # bottom right recursive call

    else:
        global count # when the counter of broken recursive calls == 40 it will place the cheese in that room
        count += 1
        if count == 40:
            x = random.randrange(roomcoords[0][0]+3, roomcoords[1][0]-3)
            y = random.randrange(roomcoords[0][1]+3, roomcoords[1][1]-3)
            pygame.draw.ellipse(screen, yellow, [x*5, y*5, 10, 10], 0) # draws an ellipse as the cheese
            cheeseflag = False


def DisplayMaze():
    for i in range(len(mazegrid)):
        for j in range(len(mazegrid[i])): # loops through entire mazegrid and draws each "1" as a black rectangle
            if mazegrid[i][j] == 1:
                pygame.draw.rect(screen, black, [i*5, j*5, 5, 5])
    for i in range(len(mazegrid)):
        for j in range(len(mazegrid[i])): # loops through entire mazegrid again (to not avoid being overwritten) and draws each "2" as a larger white rectangle for a door
            if mazegrid[i][j] == 2:
                pygame.draw.rect(screen, white, [(i-2)*5, (j-2)*5, 25, 25])

done=False # Loop until the user clicks the close button.
clock=pygame.time.Clock() # Used to manage how fast the screen updates

# -------- Main Program Loop -----------
while done==False:
    for event in pygame.event.get(): # User did something
            if event.type == pygame.QUIT: # If user clicked close
                done=True # Flag that we are done so we exit this loop
            if event.type == pygame.KEYDOWN: # If user wants to perform an action
                if event.key == pygame.K_m:
                    count = 0 # resets count
                    mazegrid = clearMazegrid(mazegrid) # clears maze
                    GenerateMaze() # generates maze
                    DisplayMaze() # displays maze
    clock.tick(20) # Limit to 20 frames per second
    pygame.display.flip() # Go ahead and update the screen with what we've drawn.
pygame.quit() # If you forget this line, the program will 'hang' on exit.