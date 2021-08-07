def knapsack_multi(items, capacity):
    if capacity == 0 or len(items) == 0: # base case
        return 0
    
    if items[len(items)-1].getWeight() > capacity:  # if the weight is more than capacity recursive call without that item
        return knapsack_multi(items[:-1], capacity) # otherwise pick best item out of above option  recursive call with capacity minus the item's weight
    else:
        return max(items[len(items)-1].getValue() + knapsack_multi(items, capacity - items[len(items)-1].getWeight()), knapsack_multi(items[:-1], capacity))

def knapsack_single(items, capacity):
    if capacity == 0 or len(items) == 0:  # base case
        return 0

    if items[len(items)-1].getWeight() > capacity:   # if the weight is more than capacity recursive call without that item
        return knapsack_single(items[:-1], capacity) # otherwise pick best item out of above option  recursive call with capacity minus the item's weight and without the current item
    else:
        return max(items[len(items)-1].getValue() + knapsack_single(items[:-1], capacity - items[len(items)-1].getWeight()), knapsack_single(items[:-1], capacity))