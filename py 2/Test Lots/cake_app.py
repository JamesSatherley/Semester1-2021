import cake, cake_io, cake_picker, cake_picker_greedy
import pygame, os, random

def bake_random(cake_size, piece_min, piece_max):
    """ create random cake with given number of pieces; each piece size lies between given min and max
    """
    fresh_cake = cake.Cake()
    for i in range(0, cake_size):
        piece_size = random.randint(piece_min, piece_max)
        fresh_cake.pieces.append(piece_size)
    return fresh_cake


# init screen
pygame.init() 
screen_size = [800,800]
screen = pygame.display.set_mode(screen_size)
pygame.display.set_caption("Piece of Cake")

# init cake
my_cake = bake_random(cake_size = 100, piece_min = 5, piece_max = 9)
cake_center = (screen_size[0]/2, screen_size[1]/2)
cake_radius = min(screen_size)/2 - 10
cakeDisplay = cake_io.CakeRenderer(my_cake, cake_center, cake_radius)
print("cake: ", my_cake.pieces)

# init AI
cakePicker = cake_picker.CakePicker(my_cake)
cakePicker_greedy = cake_picker_greedy.CakePicker(my_cake)

player_score = 0
tof = True

# draw
cakeDisplay.display_cake(screen)
pygame.display.flip()

# -------- Main Program Loop -----------
while True:
    event = pygame.event.wait() # get one event, wait until it happens
    if event.type == pygame.QUIT: # user clicked close
        break
    if not my_cake.is_empty():
        # check if user picked on a valid piece
        if tof:
            cake_piece = random.choice(my_cake.pieces)
            tof = False
        else:
            cake_piece = cakePicker_greedy.pick()
        if cake_piece != None and my_cake.can_take_piece(cake_piece):
            print("piece chosen by player:", cake_piece, "(" + str(my_cake.pieces[cake_piece]) + ")")
            player_score += my_cake.take_piece(cake_piece)
            # update the screen
            cakeDisplay.display_cake(screen)
            pygame.display.flip()
            pygame.time.delay(500)
            if not my_cake.is_empty():
                # AI picks its piece
                ai_piece = cakePicker.pick()
                print("piece chosen by ai:", ai_piece)
                my_cake.take_piece(ai_piece)
                cakeDisplay.display_cake(screen)
            if my_cake.is_empty():
                # show win/loss message
                myfont = pygame.font.SysFont("Comic Sans MS", 30)
                total_score = sum(my_cake.pieces)
                victory = player_score > total_score / 2
                msg = "You scored {0} points out of {1}. You {2}.".format(player_score, total_score, "win" if victory else "lose")
                print(msg)
                label = myfont.render(msg, 1, cake_io.red)
                screen.blit(label, ((screen_size[0]-label.get_width()) // 2, screen_size[1] // 2))
            pygame.display.flip()

# clean exit
pygame.quit ()
