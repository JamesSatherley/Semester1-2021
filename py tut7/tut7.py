import random

def randomised_st_connectivity(G, n, s, t):
    stepcount = 0
    while (s != t) and (stepcount < 2*n**3):
        neighbours = []
        for i in range(len(G[s])):
            if G[s][i] == 1:
                neighbours.append(i)
        s = random.choice(neighbours)
        stepcount = stepcount + 1
    if s == t:
        return (True, stepcount)
    else:
        return (False, stepcount)

def getInfo(text):
    l = []
    file = open(text)
    lines = file.readlines()
    for line in lines:
        if lines.index(line) > 3:
            line = line.strip()
            line = line.split()
            for i in range(len(line)):
                line[i] = int(line[i])
            l.append(line)
        else:
            line = line.strip()
    return l, int(lines[0]), int(lines[1]), int(lines[2])

def main():
    for i in range(1,11):
        gIn, nIn, sIn, tIn = getInfo("testgraph" + str(i) + ".txt")
        print(randomised_st_connectivity(gIn, nIn, sIn, tIn))

main()