import random

# [worth, defence]
defenceCards = []
attackCards =[]
matchedCards = []

def checkInput(input):
    try:
        int(input)

        if int(input) > 1:
            return True
        else:
            return False

    except:
        return False

def MagicSetup():


    n = input("How many cards should I generate?\n")

    while not checkInput(n):
        n = input("please enter a valid amount of cards (any integer greater than 1)")


    print("number of cards:", n)

    for i in range(int(n)):
        defenceCards.append([random.randrange(1,int(n)), random.randrange(1,int(n))])
        attackCards.append(random.randrange(1,int(n)))

    print("Defence cards:", defenceCards)
    print("Attack cards:", attackCards)


    GreedyMagic()

def GreedyMagic():

    # print("Defence cards:", defenceCards)
    tempDefence = []
    tempattack =[]

    for n in range(len(defenceCards)):
        tempDefence.append([defenceCards[n][0],defenceCards[n][1],n])
        tempattack.append([attackCards[n], n])

    tempDefence.sort(key = lambda x: x[1], reverse = True)
    tempattack.sort(key=lambda x: x[0], reverse = True)




    for x in range(len(tempDefence)):
        temp = []
        for card in range(len(tempattack)):

            if tempattack[card][0] < tempDefence[x][1]:
                temp.append([tempattack[card][0], card])

        if len(temp) == 0:
            temp.append([tempDefence[x][2], 0])

        else:
            temp.sort(key= lambda x: x[0], reverse = True)

        matchedCards.append([tempDefence[x][2], tempattack[temp[0][1]][1]])

        tempattack.pop(temp[0][1])

    matchedCards.sort(key=lambda x: x[0])

    totalWorth = 0

    for i in matchedCards:

        print("defence card", defenceCards[i[0]], "matched with attack card", attackCards[i[1]])
        if  defenceCards[i[0]][1] < attackCards[i[1]]:
            totalWorth += defenceCards[i[0]][0]
    print("total worth:", totalWorth)

MagicSetup()