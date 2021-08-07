import random

def generateCards(num):
    x,y = [], []
    for i in range(num):
        x.append([random.randint(1, num),random.randint(1, num)])
        y.append(random.randint(1, num))
    return x, y

def checkInt(n):
    try:
        if int(n) > 0:
            return True
    except ValueError:
        return False

def greedy(d_cards, a_cards):
    return_d_cards, return_a_cards = [], []
    for i in range(len(d_cards)):
        current_highest = [[0,0],0]
        match = []
        for j in range(len(d_cards)):
            if d_cards[j][0] > current_highest[0][0]:
                current_highest = [d_cards[j], j]
        for k in range(len(d_cards)):
            if current_highest[0][1] == a_cards[k]:
                match = [current_highest, [a_cards[k], k]]
            elif current_highest[0][1] >= a_cards[k]:
                match = [current_highest, [a_cards[k], k]]
        if not match:
            return_d_cards.append(d_cards[0])
            d_cards.pop(0)
            return_a_cards.append(a_cards[0])
            a_cards.pop(0)
        else:
            return_d_cards.append(d_cards[match[0][1]])
            d_cards.pop(match[0][1])
            return_a_cards.append(a_cards[match[1][1]])
            a_cards.pop(match[1][1])
    return return_d_cards, return_a_cards

def main():
    num_input = input("Enter amount of cards: ")
    while not checkInt(num_input):
        num_input = input("That is not an acceptable number, Enter amount of cards: ")
    defense_cards, attack_cards = generateCards(int(num_input))
    defense_cards, attack_cards = greedy(defense_cards, attack_cards)
    totalWorth = 0
    for i in range(int(num_input)):
        print("Defense card with worth {} and defense {} matched with {}".format(defense_cards[i][0], defense_cards[i][1], attack_cards[i]))

        if defense_cards[i][1] >= attack_cards[i]:
            totalWorth += defense_cards[i][1]
    print("total worth:", totalWorth)

main()