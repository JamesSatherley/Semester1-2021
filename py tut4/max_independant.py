count = 0

def max_ind_set(nodes, edges):
    global count
    if len(nodes) <= 1: return len(nodes)
    node = nodes[0] # pick a node

    # case 1: node lies in independent set => remove neighbours as well
    nodes1 = [ n for n in nodes if n != node and (node, n) not in edges ]
    size1 = 1 + max_ind_set(nodes1, edges)
    count += 1

    # case 2: node does not lie in independent set
    nodes2 = [ n for n in nodes if n != node ]
    size2 = max_ind_set(nodes2, edges)
    count += 1

    return max(size1, size2)

def max_ind_set_improved(nodes, edges):
    if len(nodes) <= 1: return len(nodes)
    node = nodes[0] # pick a node

    # case 1: node lies in independent set => remove neighbours as well
    nodes1 = [ n for n in nodes if n != node and (node, n) not in edges ]
    size1 = 1 + max_ind_set_improved(nodes1, edges)

    if len([ n for n in nodes if (node, n) in edges ]) <= 1:
        return size1

    # case 2: node does not lie in independent set
    nodes2 = [ n for n in nodes if n != node ]
    size2 = max_ind_set_improved(nodes2, edges)

    return max(size1, size2)

if __name__ == '__main__':
    nodes = [1,2,3,4,5,6,7,8]
    edges = [(1,2),(1,3),(2,3),(2,4),(3,5),(4,5),(4,6),(5,7),(6,7),(6,8),(7,8)]
    # undirected graph => edges go in both directions (simplifies algorithms)
    edges += [ (b,a) for (a,b) in edges ]
    print("max_ind_set = {}".format(max_ind_set(nodes,edges)))
    print("max_ind_set_improved = {}".format(max_ind_set_improved(nodes,edges)))

    print(count)
