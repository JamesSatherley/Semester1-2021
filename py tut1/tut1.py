def findAnagram(list_of_words, two_words):
    output = []
    for word in list_of_words:
        if word[0] == two_words[0]:
            output.append(word[1])
            sorted_words_editable.remove(word)
    return output



sorted_words = []

with open("words.txt") as file:
    words = file.readlines()
words = [line.strip() for line in words]

for line in words:
    replacement = ""
    list_of_letters = sorted(list(line.lower()))
    for i in list_of_letters:
        replacement += i
    sorted_words.append([replacement, line])

sorted_words_editable = sorted_words

for line in sorted_words:
    output = findAnagram(sorted_words_editable, line)
    if len(output) >= 5:
        print(output)
