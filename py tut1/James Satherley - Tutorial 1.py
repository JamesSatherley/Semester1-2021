import time # to time certain parts of code
processed = {} # define globals

def menu(): # prints a menu for the user
    choice = 0
    while choice < 1 or choice > 2:
        choice = input("Do you want to get all possible anagrams or enter a select few words to find anagrams? Choose option 1 or 2: ")
        try:
            choice = int(choice)
            if choice < 1 or choice > 2:
                print("Your input is not 1 or 2") # let the use choose to find all anagrams of all words or to input certain words
        except:
            choice = 0
            print("Your input is not a number")
    
    if choice == 1:
        allPossibleAnagrams() # calls the functions needed based on user entry above
    elif choice == 2:
        whichWords()
    else:
        print("Error")

def allPossibleAnagrams(): # finds all anagrams and outputs them to user
    start_time = time.time() # starts timer
    findAnagrams()
    print("\nTime: ", time.time() - start_time,"\n") # prints time taken
    print(processed) # prints the total time and the final list

def whichWords(): # lets user select certain words to send to anagram finder
    print("This program will ask you for input words to test for anagrams in the accompanying text file. When done entering words type three fullstops; ... and the program will begin running. Type three commas to restart; ,,, This will empty the items to send.")
    going = True
    output = []
    while going == True:
        word = input("Input word: ") # lets the user choose which words to give to the function which calculates the anagrams
        if word == "...":
            going = False
            print("Items sent: ", output)
        elif word == ",,,":
            output = []
            print("Items to send: ", output) # can restart entering or pass the details with certain commands: ,,, and ...
        else:
            output.append(word)
            print("Items to send: ", output)
    certainAnagrams(output)

def certainAnagrams(items): # finds anagrams based on what the user enters
    start_time = time.time() # starts a timer
    findAnagrams() # finds all anagrams
    
    output = []
    for item in items:
        x = ''.join(sorted(list(item))) # converts an item in the list to alphabetical order
        if x in processed:
            output.append([processed[x],[item]]) # tests if it has anagrams, if so it will grab them and send them to an output list
        else:
            output.append([["anagram was not found"],[item]]) # if it has no anagrams it will tell the user

    output.sort(key=lambda x: -len(x[0])) # sorts in reverse order
    print("\nTime: ", time.time() - start_time,"\n") # prints time taken
    for item in output:
        print("For the word/letters:", item[1], "the following anagrams were found:", item[0]) # prints out item in output list seperately

def findAnagrams():   
    lines = [line.strip().lower() for line in open("words.txt")] # imports every word from the txt file in a list stripped of white space and capitols
    for line in lines:
        x = ''.join(sorted(list(line))) # orders each word by alphabetical order
        if x in processed:
            processed[x].append(line) # tests if the word is already in the dictionary. if it is it will add the normal word to a list which is the value
        else:
            processed[x] = [line] # if the word is not in the dictionary it sets a new item in the dictionary with the key as the alphabeticalised word

menu() # calls the menu to start program


