#include <cstdio>
#include <cstdlib>
#include <ctime>
#include <chrono>

typedef struct Node {
    int data;
    struct Node *next;
    struct Node *prev;
} Node;

int generateRandomNumber(int min, int max) {
    return rand() % (max - min + 1) + min;
}

void selectionSortList(Node *head) {
    if (head == nullptr || head->next == nullptr) {
        return;
    }

    Node *current = head;
    while (current != nullptr) {
        Node *minNode = current;
        Node *temp = current->next;

        while (temp != nullptr) {
            if (temp->data < minNode->data) {
                minNode = temp;
            }
            temp = temp->next;
        }

        if (minNode != current) {
            int tempData = current->data;
            current->data = minNode->data;
            minNode->data = tempData;
        }

        current = current->next;
    }
}

void insertionSortArray(int arr[], int n) {
    for (int i = 1; i < n; i++) {
        int key = arr[i];
        int j = i - 1;

        while (j >= 0 && arr[j] > key) {
            arr[j + 1] = arr[j];
            j--;
        }

        arr[j + 1] = key;
    }
}

void insertionSortList(Node *head) {
    if (head == nullptr || head->next == nullptr) {
        return;
    }

    Node *sortedList = nullptr;
    Node *current = head;

    while (current != nullptr) {
        Node *newNode = (Node *)malloc(sizeof(Node));
        newNode->data = current->data;
        newNode->next = nullptr;
        newNode->prev = nullptr;

        if (sortedList == nullptr) {
            sortedList = newNode;
        } else {
            Node *temp = sortedList;

            while (temp != nullptr && temp->data < newNode->data) {
                temp = temp->next;
            }

            if (temp == nullptr) {
                newNode->next = sortedList;
                sortedList->prev = newNode;
                sortedList = newNode;
            } else {
                newNode->next = sortedList;
                sortedList->prev = newNode;
                sortedList = newNode;
            }
        }

        current = current->next;
    }

    head = sortedList;
    free(current);
}

Node *createRandomList(int size) {
    if (size <= 0) {
        return nullptr;
    }

    Node *head = (Node *)malloc(sizeof(Node));
    head->data = generateRandomNumber(0, 100);
    head->next = nullptr;
    head->prev = nullptr;

    Node *prev = head;
    for (int i = 1; i < size; i++) {
        Node *newNode = (Node *)malloc(sizeof(Node));
        newNode->data = generateRandomNumber(0, 100);
        newNode->next = nullptr;

        newNode->prev = prev;
        prev->next = newNode;

        prev = newNode;
    }

    return head;
}


int main() {
    srand(time(nullptr));
    int arr[] = {10, 100, 500, 1000, 2000, 5000, 10000};
    for (int size : arr) {
        int *array = (int *)malloc(size * sizeof(int));
        Node *list = createRandomList(size);

        auto start = std::chrono::high_resolution_clock::now();
        selectionSortList(list);
        auto end = std::chrono::high_resolution_clock::now();
        auto duration = std::chrono::duration_cast<std::chrono::nanoseconds>(end - start);
        long selectionSortTime = duration.count();
        printf("selectionSortList (doubly linked list), size list %d: %ld\n", size, selectionSortTime);

        start = std::chrono::high_resolution_clock::now();
        insertionSortArray(array, size);
        end = std::chrono::high_resolution_clock::now();
        duration = std::chrono::duration_cast<std::chrono::nanoseconds>(end - start);
        selectionSortTime = duration.count();
        printf("insertionSortArray (array[]), size %d: %ld\n", size, selectionSortTime);

        start = std::chrono::high_resolution_clock::now();
        insertionSortList(list);
        end = std::chrono::high_resolution_clock::now();
        duration = std::chrono::duration_cast<std::chrono::nanoseconds>(end - start);
        selectionSortTime = duration.count();
        printf("insertionSortList (doubly linked list),  %d: %ld\n", size, selectionSortTime);
        printf("\n");
        free(array);
    }

    return 0;
}
