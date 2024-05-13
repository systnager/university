def quicksort(arr):
    if len(arr) <= 1:
        return arr
    pivot = arr[len(arr) // 2]
    left = [x for x in arr if x < pivot]
    middle = [x for x in arr if x == pivot]
    right = [x for x in arr if x > pivot]
    return quicksort(left) + middle + quicksort(right)


test_data = [5, 3, 8, 6, 2, 7, 1, 4]
print("Не відсортований масив:", test_data)
print("Відсортований масив:", quicksort(test_data))

###################################################
def counting_sort(arr, exp):
    n = len(arr)
    output = [0] * n
    count = [0] * 10

    for i in range(n):
        index = arr[i] // exp
        count[index % 10] += 1

    for i in range(1, 10):
        count[i] += count[i - 1]

    i = n - 1
    while i >= 0:
        index = arr[i] // exp
        output[count[index % 10] - 1] = arr[i]
        count[index % 10] -= 1
        i -= 1

    for i in range(n):
        arr[i] = output[i]

def radix_sort(arr):
    max_num = max(arr)
    exp = 1
    while max_num // exp > 0:
        counting_sort(arr, exp)
        exp *= 10

test_data = [170, 45, 75, 90, 802, 24, 2, 66]
print("Не відсортований масив:", test_data)
radix_sort(test_data)
print("Відсортований масив:", test_data)
####################################################
class HashTable:
    def __init__(self, size):
        self.size = size
        self.hash_table = [None] * self.size

    def hash_function(self, key):
        return key % self.size

    def insert(self, key, value):
        index = self.hash_function(key)
        while self.hash_table[index] is not None:
            index = (index + 1) % self.size
        self.hash_table[index] = (key, value)

    def search(self, key):
        index = self.hash_function(key)
        while self.hash_table[index] is not None and self.hash_table[index][0] != key:
            index = (index + 1) % self.size
        if self.hash_table[index] is None:
            return None
        return self.hash_table[index][1]


hash_table = HashTable(3)  # 3 - кількість елементів у хеш-таблиці
hash_table.insert(5, "apple")
hash_table.insert(15, "banana")
hash_table.insert(25, "cherry")

print("Значення для ключа 5:", hash_table.search(5))
print("Значення для ключа 15:", hash_table.search(15))
print("Значення для ключа 25:", hash_table.search(25))
#######################################################################
import heapq

def dijkstra(graph, start):
    distances = {vertex: float('infinity') for vertex in graph}
    distances[start] = 0
    priority_queue = [(0, start)]

    while priority_queue:
        current_distance, current_vertex = heapq.heappop(priority_queue)

        if current_distance > distances[current_vertex]:
            continue

        for neighbor, weight in graph[current_vertex].items():
            distance = current_distance + weight
            if distance < distances[neighbor]:
                distances[neighbor] = distance
                heapq.heappush(priority_queue, (distance, neighbor))

    return distances

graph = {
    'A': {'B': 1, 'C': 4},
    'B': {'A': 1, 'C': 2, 'D': 5},
    'C': {'A': 4, 'B': 2, 'D': 1},
    'D': {'B': 5, 'C': 1}
}
start_vertex = 'A'
print(f"Найкоротші відстані від вершини {start_vertex} до інших вершин:")
print(dijkstra(graph, start_vertex))
####################################################
class HashTable:
    def __init__(self, size):
        self.size = size
        self.hash_table = [[] for _ in range(size)]

    def hash_function(self, key):
        return key % self.size

    def insert(self, key, value):
        index = self.hash_function(key)
        self.hash_table[index].append((key, value))

    def search(self, key):
        index = self.hash_function(key)
        for k, v in self.hash_table[index]:
            if k == key:
                return v
        return None


hash_table = HashTable(3)
hash_table.insert(5, "apple")
hash_table.insert(15, "banana")
hash_table.insert(25, "cherry")

print("Значення для ключа 5:", hash_table.search(5))
print("Значення для ключа 15:", hash_table.search(15))
print("Значення для ключа 25:", hash_table.search(25))
######################################################
def floyd_warshall(graph):
    n = len(graph)
    distance = [[float('inf')] * n for _ in range(n)]  # float('inf') - нескінченність, нескінченне число

    for i in range(n):
        for j in range(n):
            if i == j:
                distance[i][j] = 0
            elif graph[i][j] != 0:
                distance[i][j] = graph[i][j]

    for k in range(n):
        for i in range(n):
            for j in range(n):
                distance[i][j] = min(distance[i][j], distance[i][k] + distance[k][j])

    return distance


graph = [
    [0, 5, 0, 10],
    [0, 0, 3, 0],
    [0, 0, 0, 1],
    [0, 0, 0, 0]
]
print("Матриця найкоротших відстаней:")
for row in floyd_warshall(graph):
    print(row)
##########################################
def shannon_fano(data):
    if len(data) == 1:
        return {data[0]: '0'}

    data_freq = {char: data.count(char) for char in set(data)}
    sorted_data_freq = sorted(data_freq.items(), key=lambda x: x[1], reverse=True)

    def divide(freq_list):
        total_freq = sum(freq for _, freq in freq_list)
        running_total = 0
        split_index = None
        for i, (_, freq) in enumerate(freq_list):
            running_total += freq
            if running_total >= total_freq / 2:
                split_index = i
                break
        return freq_list[:split_index + 1], freq_list[split_index + 1:]

    def assign_codes(freq_list, code_prefix):
        if len(freq_list) == 1:
            return {freq_list[0][0]: code_prefix}
        left_freq, right_freq = divide(freq_list)
        codes = {}
        codes.update(assign_codes(left_freq, code_prefix + '0'))
        codes.update(assign_codes(right_freq, code_prefix + '1'))
        return codes

    codes = assign_codes(sorted_data_freq, '')
    return codes



test_data = "abbcccddddeeeee"
expected_codes = {'e': '00', 'd': '01', 'c': '10', 'b': '110', 'a': '111'}

print(shannon_fano(test_data), '\n', expected_codes)
####################################################
def bellman_ford(graph, start):
    distance = {node: float('inf') for node in graph}
    distance[start] = 0

    for _ in range(len(graph) - 1):
        for node in graph:
            for neighbor, weight in graph[node].items():
                if distance[node] + weight < distance[neighbor]:
                    distance[neighbor] = distance[node] + weight

    for node in graph:
        for neighbor, weight in graph[node].items():
            if distance[node] + weight < distance[neighbor]:
                raise ValueError("Граф містить цикл з від'ємною вагою")

    return distance

graph = {
    'A': {'B': -1, 'C': 4},
    'B': {'C': 3, 'D': 2, 'E': 2},
    'C': {},
    'D': {'B': 1, 'C': 5},
    'E': {'D': -3}
}
start_node = 'A'

print(bellman_ford(graph, start_node))
##############################################
import heapq
from collections import Counter


def huffman_encoding(data):
    freq = Counter(data)
    priority_queue = [[weight, [symbol, ""]] for symbol, weight in freq.items()]
    heapq.heapify(priority_queue)

    while len(priority_queue) > 1:
        left = heapq.heappop(priority_queue)
        right = heapq.heappop(priority_queue)
        for pair in left[1:]:
            pair[1] = '0' + pair[1]
        for pair in right[1:]:
            pair[1] = '1' + pair[1]
        heapq.heappush(priority_queue, [left[0] + right[0]] + left[1:] + right[1:])

    huffman_code = {}
    for pair in priority_queue[0][1:]:
        huffman_code[pair[0]] = pair[1]

    encoded_data = ''.join(huffman_code[char] for char in data)

    return encoded_data, huffman_code


def huffman_decoding(encoded_data, huffman_code):
    reverse_code = {code: char for char, code in huffman_code.items()}
    decoded_data = ''
    current_code = ''
    for bit in encoded_data:
        current_code += bit
        if current_code in reverse_code:
            decoded_data += reverse_code[current_code]
            current_code = ''
    return decoded_data



data = "hello, world!"

encoded_data, huffman_code = huffman_encoding(data)
decoded_data = huffman_decoding(encoded_data, huffman_code)

print("Закодовані дані:", encoded_data)
print("Декодовані дані:", decoded_data)
###########################################
def compute_lps_array(pattern):
    length = len(pattern)
    lps = [0] * length
    j = 0

    for i in range(1, length):
        while j > 0 and pattern[i] != pattern[j]:
            j = lps[j-1]
        if pattern[i] == pattern[j]:
            j += 1
        lps[i] = j
    return lps

def kmp_search(text, pattern):
    count = 0
    lps = compute_lps_array(pattern)
    i, j = 0, 0

    while i < len(text):
        if text[i] == pattern[j]:
            i += 1
            j += 1
        if j == len(pattern):
            count += 1
            j = lps[j-1]
        elif i < len(text) and text[i] != pattern[j]:
            if j != 0:
                j = lps[j-1]
            else:
                i += 1
    return count

text = "123 12 123 111"
pattern = "123"

matches_count = kmp_search(text, pattern)
print("Кількість входжень підстроки:", matches_count)




