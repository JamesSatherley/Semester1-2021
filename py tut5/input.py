import recursive, item # imports other files. prints output

print(recursive.knapsack_multi([item.Item(6,30), item.Item(3,14), item.Item(4,16), item.Item(2,9)], 10))
print(recursive.knapsack_single([item.Item(6,30), item.Item(3,14), item.Item(4,16), item.Item(2,9)], 10))